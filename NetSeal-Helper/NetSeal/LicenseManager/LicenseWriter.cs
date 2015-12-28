//    Copyright(C) 2015/2016 Alcatraz Developer
//
//    This file is part of NetSeal Helper
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.If not, see<http://www.gnu.org/licenses/>.

using System;
using System.IO;

namespace NetSeal_Helper.NetSeal.LicenseManager
{
    class LicenseWriter : LicenseManagerBase
    {
        private void InternalWriteLicense(string filePath, string netsealId, LicenseFile licenseFile, FileAttributes attributes)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var binaryWriter = new BinaryWriter(memoryStream))
                {
                    binaryWriter.Write(licenseFile.GUID);
                    binaryWriter.Write(licenseFile.Unknown);
                    binaryWriter.Write(licenseFile.Remember);
                    if (licenseFile.Remember)
                    {
                        binaryWriter.Write(licenseFile.Username);
                        binaryWriter.Write(licenseFile.Sha1Password);
                    }
                }

                byte[] derivation = null;

                if (licenseFile.Framework == LicenseFramework.Framework2_0)
                    derivation = GetDerivationFr2_0(netsealId);
                else if (licenseFile.Framework == LicenseFramework.Framework4_5)
                    derivation = GetDerivationFr4_5(netsealId);
                else
                    throw new Exception("License Framework");


                var encrypted = EncryptLicense(memoryStream.ToArray(), derivation);


                if (attributes == 0)
                    attributes = FileAttributes.Hidden | FileAttributes.NotContentIndexed | FileAttributes.ReadOnly | FileAttributes.System;

                if (File.Exists(filePath))
                    File.SetAttributes(filePath, FileAttributes.Normal);

                File.WriteAllBytes(filePath, encrypted);
                File.SetAttributes(filePath, attributes);
            }
        }
        internal void WriteLicense(string path, string netsealId, string guid, bool remember, string username, string password, FileAttributes attributes = 0)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new Exception("path");

            var licenseFile = new LicenseFile
            {
                GUID = guid,
                Remember = remember,
                Username = username,
                Sha1Password = password
            };

            InternalWriteLicense(path, netsealId, licenseFile, attributes);
        }
        internal void WriteLicense(string path, string netsealId, LicenseFile licenseFile, FileAttributes attributes = 0)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new Exception("path");

            InternalWriteLicense(path, netsealId, licenseFile, attributes);
        }
    }
}