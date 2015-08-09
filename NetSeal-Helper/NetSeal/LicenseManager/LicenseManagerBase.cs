using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NetSeal_Helper.Extensions;

namespace NetSeal_Helper.NetSeal.LicenseManager
{
    internal class LicenseManagerBase
    {
        internal string LocalPath
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Nimoru\\");
            }
        }
        protected byte[] Rfc2898DerivationBase
        {
            get
            {
                return new byte[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251 };
            }
        }
       
        protected byte[] DecryptLicense(byte[] data, byte[] derivation)
        {
            using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(derivation, new byte[8], 1))
            {
                using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
                {
                    rijndaelManaged.BlockSize = 256;
                    rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(32);
                    rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(32);
                    var crypto = rijndaelManaged.CreateDecryptor().TransformFinalBlock(data, 0, data.Length);
                    return crypto;
                }
            }
        }
        protected byte[] EncryptLicense(byte[] data, byte[] derivation)
        {
            using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(derivation, new byte[8], 1))
            {
                using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
                {
                    rijndaelManaged.BlockSize = 256;
                    rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(32);
                    rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(32);
                    var crypto = rijndaelManaged.CreateEncryptor().TransformFinalBlock(data, 0, data.Length);
                    return crypto;
                }
            }
        }

        protected byte[] GetDerivationFr2_0(string netsealId)
        {
            var derivation = Rfc2898DerivationBase;
            
            var id = netsealId;
            id = id.GetMD5("X2");
            id += id.Substring(0, 16).GetMD5("X2");
            id = id.Remove(derivation.Length - 1);            

            System.Collections.GenericFr2_0.GenericArraySortHelper<char, byte>.QuickSort(id.ToCharArray(), derivation, 0, id.Length - 1);

            return derivation;
        }
        protected byte[] GetDerivationFr4_5(string netsealId)
        {
            var derivation = Rfc2898DerivationBase;

            var id = netsealId;
            id = id.GetMD5("X2");
            id += id.Substring(0, 16).GetMD5("X2");
            id = id.Remove(derivation.Length - 1);    

            System.Collections.GenericFr4_5.GenericArraySortHelper<char, byte>.IntrospectiveSort(id.ToCharArray(), derivation, 0, id.Length);

            return derivation;
        }
    }
}

