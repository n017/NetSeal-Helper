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
using System.Text;

namespace NetSeal_Helper.Extensions
{
    /// <summary>
    /// A set of Extensions for Strings
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Returns the MD5 of a <see cref="string"/>
        /// </summary>
        /// <param name="input"></param>
        /// <param name="format">The format which will be used to format each byte</param>
        /// <returns>String</returns>
        public static string GetMD5(this string input, string format)
        {
            return UTF8Encoding.UTF8.GetBytes(input).GetMD5(format);
        }
        /// <summary>
        /// Returns the SHA1 of a <see cref="string"/>
        /// </summary>
        /// <param name="input"></param>
        /// <param name="format">The format which will be used to format each byte</param>
        /// <returns>String</returns>
        public static string GetSHA1(this string input, string format)
        {
            return UTF8Encoding.UTF8.GetBytes(input).GetSHA1(format);
        }
        /// <summary>
        /// Resturns the <see cref="byte[]"/> from a <see cref="string"/> using <see cref="ASCIIEncoding
        /// </summary>
        /// <param name="input"></param>
        /// <returns><see cref="byte[]"/></returns>
        public static byte[] GetAsciiBytes(this string input)
        {
            var bytes = ASCIIEncoding.ASCII.GetBytes(input);
            return bytes;
        }
        /// <summary>
        /// Returns the <see cref="byte[]"/> from a Base64 string
        /// </summary>
        /// <param name="base64String"></param>
        /// <returns><see cref="byte[]"/></returns>
        public static byte[] FromBase64String(this string base64String)
        {
            return Convert.FromBase64String(base64String);
        }
    }
}