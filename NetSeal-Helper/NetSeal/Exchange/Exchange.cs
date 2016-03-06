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
using System.Collections.Specialized;
using System.Security.Cryptography;

namespace NetSeal_Helper.NetSeal.Exchange
{
    class Exchange
    {
        private CookieClient _client;
        internal CookieClient Client 
        {
            get
            {
                if (_client != null)
                    return _client;
                throw new Exception("The client is null");
            }
            private set { _client = value; }
        }

        internal byte[] LastData { get; set; }

        public Exchange()
        {
            Client = new CookieClient();
        }        

        internal byte[] UploadValues(string address, NameValueCollection data)
        {
            var response = Client.UploadValues(address, data);
            this.LastData = response;
            return response;
        }
        internal byte[] DownloadData(string address)
        {
            var response = Client.DownloadData(address);
            this.LastData = response;
            return response;
        }

        internal string Encrypt(byte[] input, byte[] key)
        {
            var aes = new AesCryptoServiceProvider();
            aes.Padding = PaddingMode.Zeros;
            aes.Mode = CipherMode.CBC;
            aes.Key = key;
            aes.IV = key;

            var crypto = aes.CreateEncryptor();
            var crypted = crypto.TransformFinalBlock(input, 0, input.Length);

            var newCryptedValue = new byte[crypted.Length + 4];
            Buffer.BlockCopy(BitConverter.GetBytes(input.Length), 0, newCryptedValue, 0, 4);
            Buffer.BlockCopy(crypted, 0, newCryptedValue, 4, crypted.Length);

            aes.Dispose();

            this.LastData = newCryptedValue;

            return Convert.ToBase64String(newCryptedValue);
        }
        internal byte[] Decrypt(byte[] input, byte[] key)
        {
            var aes = new AesCryptoServiceProvider();
            aes.Padding = PaddingMode.Zeros;
            aes.Mode = CipherMode.CBC;
            aes.Key = key;
            aes.IV = key;

            var crypto = aes.CreateDecryptor();
            var decrypted = crypto.TransformFinalBlock(input, 4, input.Length - 4);

            aes.Dispose();

            this.LastData = decrypted;

            return decrypted;
        }
        internal byte[] Decrypt(string base64String, byte[] key)
        {
            var bytes = Convert.FromBase64String(base64String);
            return this.Decrypt(bytes, key);
        }


        internal void ClearCookies()
        {
            this.Client.ClearCookies();
        }
    }
}