using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NetSeal_Helper.Extensions
{
    public static class ByteExtensions
    {
        public static string GetByteArrayAsString(this byte[] bytes, string format)
        {
            StringBuilder result = new StringBuilder();

            foreach (var i in bytes)
            {
                result.Append(i.ToString(format));
            }
            return result.ToString();
        }
        public static string GetMD5(this byte[] bytes, string format)
        {
            return MD5CryptoServiceProvider.Create().ComputeHash(bytes).GetByteArrayAsString(format);
        }
        public static string GetSHA1(this byte[] bytes, string format)
        {
            return SHA1CryptoServiceProvider.Create().ComputeHash(bytes).GetByteArrayAsString(format);
        }
        public static string ToAsciiString(this byte[] bytes)
        {
            return ASCIIEncoding.ASCII.GetString(bytes);
        }
        public static string ToUtf8String(this byte[] bytes)
        {
            return UTF8Encoding.UTF8.GetString(bytes);
        }
        public static string ToBase64String(this byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }
    }
}