using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using NetSeal_Helper.Extensions;

namespace NetSeal_Helper.NetSeal.Echange
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
