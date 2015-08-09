using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetSeal_Helper.Extensions;

namespace NetSeal_Helper.NetSeal.LicenseManager
{
    internal class LicenseReader : LicenseManagerBase
    {
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

            var memoryStream = new MemoryStream(decrypted);
            var binaryReader = new BinaryReader(memoryStream);

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

            memoryStream.Dispose();
            binaryReader.Dispose();
            derivation = null;

            return license;
        }
        internal LicenseFile ReadLocaLicense(string netsealId)
        {
            var licenseFile = ReadLicenseFrom(LocalPath + netsealId.GetMD5("X2"), netsealId);
            return licenseFile;
        }
    }
}