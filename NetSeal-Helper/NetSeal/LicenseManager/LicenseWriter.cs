using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSeal_Helper.Extensions;

namespace NetSeal_Helper.NetSeal.LicenseManager
{
    class LicenseWriter : LicenseManagerBase
    {
        private void InternalWriteLicense(string filePath, string netsealId, LicenseFile licenseFile, FileAttributes attributes)
        {
            var memoryStream = new MemoryStream();
            var binaryReader = new BinaryWriter(memoryStream);

            binaryReader.Write(licenseFile.GUID);
            binaryReader.Write(licenseFile.Unknown);
            binaryReader.Write(licenseFile.Remember);
            if (licenseFile.Remember)
            {
                binaryReader.Write(licenseFile.Username);
                binaryReader.Write(licenseFile.Sha1Password);
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

            if(File.Exists(filePath))
                File.SetAttributes(filePath, FileAttributes.Normal);

            File.WriteAllBytes(filePath, encrypted);
            File.SetAttributes(filePath, attributes);
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
