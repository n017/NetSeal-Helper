using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace NetSeal_Helper.Extensions
{
    public static class StringExtensions
    {
        public static string GetMD5(this string input, string format)
        {
            return UTF8Encoding.UTF8.GetBytes(input).GetMD5(format);
        }
        public static string GetSHA1(this string input, string format)
        {
            return UTF8Encoding.UTF8.GetBytes(input).GetSHA1(format);
        }
        public static byte[] GetAsciiBytes(this string input)
        {
            var bytes = ASCIIEncoding.ASCII.GetBytes(input);
            return bytes;
        }
        public static byte[] FromBase64String(this string base64String)
        {
            return Convert.FromBase64String(base64String);
        }
    }
}
