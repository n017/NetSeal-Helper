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
using System.Security.Cryptography;
using System.Text;

namespace NetSeal_Helper.Extensions
{
    /// <summary>
    /// A set of Extensions for Byte Arrays
    /// </summary>
    public static class ByteExtensions
    {
        /// <summary>
        /// Returns a <see cref="byte[]"/> as <see cref="string"/>
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="format">The format which will be used to format each byte/></param>
        /// <returns>String</returns>
        public static string GetByteArrayAsString(this byte[] bytes, string format)
        {
            StringBuilder result = new StringBuilder();

            foreach (var i in bytes)
            {
                result.Append(i.ToString(format));
            }
            return result.ToString();
        }
        /// <summary>
        /// Returns the MD5 of a <see cref="byte[]"/> as <see cref="string"/>
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="format">The format which will be used to format each byte</param>
        /// <returns>A MD5 string</returns>
        public static string GetMD5(this byte[] bytes, string format)
        {
            return MD5CryptoServiceProvider.Create().ComputeHash(bytes).GetByteArrayAsString(format);
        }
        /// <summary>
        /// Returns the SHA1 of a <see cref="byte[]"/> as <see cref="string"/>
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="format">The format which will be used to format each byte</param>
        /// <returns>String</returns>
        public static string GetSHA1(this byte[] bytes, string format)
        {
            return SHA1CryptoServiceProvider.Create().ComputeHash(bytes).GetByteArrayAsString(format);
        }
        /// <summary>
        /// Resturns the String from a <see cref="byte[]"/> using <see cref="ASCIIEncoding"/>
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns>String</returns>
        public static string ToAsciiString(this byte[] bytes)
        {
            return ASCIIEncoding.ASCII.GetString(bytes);
        }
        /// <summary>
        /// Resturns the String from a <see cref="byte[]"/> using <see cref="UTF8Encoding"/>
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns>String</returns>
        public static string ToUtf8String(this byte[] bytes)
        {
            return UTF8Encoding.UTF8.GetString(bytes);
        }
        /// <summary>
        /// Returns a Base64 String
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns>String</returns>
        public static string ToBase64String(this byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }
    }
}