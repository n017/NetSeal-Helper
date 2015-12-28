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

using System.IO;
using NetSeal_Helper.Extensions;

namespace NetSeal_Helper.NetSeal.LicenseManager
{
    internal class LicenseReader : LicenseManagerBase
    {
        /// <summary>
        /// Reads a netseal license file 
        /// </summary>
        /// <param name="licensePath">License File Path</param>
        /// <param name="netsealId">NetSeal ID</param>
        /// <returns>Returns a <see cref="LicenseFile"/></returns>
        /// <exception cref="FileNotFoundException"
        internal LicenseFile ReadLicenseFrom(string licensePath, string netsealId)
        {
            if (!File.Exists(licensePath))
                throw new FileNotFoundException("License file not found");

            byte[] derivation = null;
            byte[] decrypted = null;
            var framework = LicenseFramework.Null;
                        
            try {
                derivation = GetDerivationFr2_0(netsealId);
                decrypted = DecryptLicense(File.ReadAllBytes(licensePath), derivation);
                framework = LicenseFramework.Framework2_0;
            }
            catch { 
                derivation = GetDerivationFr4_5(netsealId);
                decrypted = DecryptLicense(File.ReadAllBytes(licensePath), derivation);
                framework = LicenseFramework.Framework4_5;
            }

            using (var memoryStream = new MemoryStream(decrypted))
            {
                using (var binaryReader = new BinaryReader(memoryStream))
                {

                    var license = new LicenseFile();
                    license.LicenseName = Path.GetFileName(licensePath);
                    license.ID = netsealId;
                    license.GUID = binaryReader.ReadString();
                    license.Unknown = binaryReader.ReadBoolean();
                    license.Remember = binaryReader.ReadBoolean();
                    license.Framework = framework;
                    if (license.Remember)
                    {
                        license.Username = binaryReader.ReadString();
                        license.Sha1Password = binaryReader.ReadString();
                    }
                    else
                    {
                        license.Username = string.Empty;
                        license.Sha1Password = string.Empty;
                    }
                    derivation = null;
                    decrypted = null;
                    return license;
                }
            }
        }
        /// <summary>
        /// Reads a netseal license file from local path
        /// </summary>
        /// <param name="netsealId">NetSeal ID</param>
        /// <returns>Returns a <see cref="LicenseFile"/></returns>
        internal LicenseFile ReadLocaLicense(string netsealId)
        {
            var licenseFile = ReadLicenseFrom(LocalPath + netsealId.GetMD5("X2"), netsealId);
            return licenseFile;
        }
    }
}