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
using System.Reflection;
using System.IO;
using System.Net;
using NetSeal_Helper.Extensions;

namespace NetSeal_Helper.NetSeal
{
    /* -In Order to LogIn-
     *  -RunWE
     *  -SetID 
     *  -SetGUID
     *  -Exchange
     *  -SignIn
     *  -GetStatus
     *  -Sanction
     */

    class License
    {
        private const string END_POINT = "http://seal.nimoru.com/"; //Here's where netseal makes its API Calls, might change in a future update.
        private const string NETSEAL_VERSION = "2.0.0.6"; //Current NetSeal License Version.
        private const string DEFAULT_VERSION = "1.0.0.0";

        #region Properties

        /// <summary>
        /// Target file path which uses Netseal
        /// </summary>
        private string TargetPath { get; set; }
        /// <summary>
        /// Instance object of the Netseal API class
        /// </summary>
        private object ApiInstance 
        {
            get
            {
                return Share.GetField("APIInstance", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null);
            }
            set
            {
                Share.GetField("APIInstance", BindingFlags.Static | BindingFlags.NonPublic).SetValue(API, value);
            }
        }

        /// <summary>
        /// Gets the Type Share from Netseal
        /// </summary>
        private Type Share 
        {
            get 
            { 
                return Assembly.ManifestModule.GetType("Share"); 
            }
        }
        /// <summary>
        /// Gets the Type API from Netseal
        /// </summary>
        private Type API 
        {
            get
            {
                return Assembly.ManifestModule.GetType("API");
            }
        }

        private Assembly _assembly;
        /// <summary>
        /// Netseal Assembly
        /// </summary>
        internal Assembly Assembly 
        {
            get 
            {
                if (_assembly != null)
                    return _assembly;
                throw new Exception("License assembly is null");
            }
            set { _assembly = value; }
        }

        private string _id;
        /// <summary>
        /// Netseal Program ID
        /// </summary>
        internal string ID 
        {
            get
            {
                if (!string.IsNullOrEmpty(_id))                
                    return _id;                
                throw new Exception("The ID is null or empty");
            }
            private set { _id = value; }

        }

        /// <summary>
        /// Returns the last data
        /// </summary>
        internal byte[] LastData 
        {
            get
            {
                var data = (byte[])API.GetField("LastData", BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance).GetValue(ApiInstance);

                if (data != null)
                    return data;
                else
                    return new byte[1];
            }
        }

        private string guid;
        /// <summary>
        /// Netseal License GUID
        /// </summary>
        internal string GUID
        {
            get
            {
                if (!string.IsNullOrEmpty(guid))
                    return guid;
                else
                    throw new Exception("GUID null or empty");
            }
            set { this.guid = value; }
        }
        /// <summary>
        /// Netseal Users Online
        /// </summary>
        internal int UsersOnline 
        {
            get
            {
                return (int)Share.GetMethod("GetUsersOnline").Invoke(null, new object[] { });
            }
        }
        /// <summary>
        /// Netseal Users Count
        /// </summary>
        internal int UsersCount 
        {
            get {
                return (int)Share.GetMethod("GetUsersCount").Invoke(null, new object[] { });
            }
        }
        /// <summary>
        /// Netseal Username
        /// </summary>
        internal string Username 
        { 
            get {
                return (string)Share.GetMethod("GetUsername").Invoke(null, null);
            }
        }
        /// <summary>
        /// Netseal Update Available
        /// </summary>
        internal bool UpdateAvailable 
        { 
            get {
                return (bool)Share.GetMethod("GetUpdateAvailable").Invoke(null, null);
            }
        }
        /// <summary>
        /// Netseal Remaining Time
        /// </summary>
        internal TimeSpan RemainingTime 
        {
            get {
                return (TimeSpan)Share.GetMethod("GetRemaining").Invoke(null, null);                
            }
        }
        /// <summary>
        /// Netseal Public Token
        /// </summary>
        internal string PublicToken 
        {
            get {
                return (string)Share.GetMethod("GetPublicToken").Invoke(null, null);
            }
        }
        /// <summary>
        /// Netseal Private Key
        /// </summary>
        internal byte[] PrivateKey 
        {
            get {
                return (byte[])Share.GetMethod("GetPrivateKey").Invoke(null, null);
            }
        }
        /// <summary>
        /// Netseal Points Count
        /// </summary>
        internal int PointsCount 
        {
            get {
                return (int)Share.GetMethod("GetPoints").Invoke(null, null);
            }
        }
        /// <summary>
        /// Netseal Global Message
        /// </summary>
        internal string GlobalMessage 
        {
            get {
                return (string)Share.GetMethod("GetMessage").Invoke(null, null);
            }
        }
        /// <summary>
        /// Netseal License Type
        /// </summary>
        internal LicenseType LicenseType 
        {
            get {
                return (LicenseType)Share.GetMethod("GetLicenseType").Invoke(null, null);
            }
        }
        /// <summary>
        /// Netseal IP Address
        /// </summary>
        internal IPAddress IPAddress 
        {
            get {
                return (IPAddress)Share.GetMethod("GetIPAddress").Invoke(null, null);
            }
        }
        /// <summary>
        /// Netseal Expiration Time
        /// </summary>
        internal DateTime Expiration 
        {
            get {
                return (DateTime)Share.GetMethod("GetExpiration").Invoke(null, null);
            }
        }
        /// <summary>
        /// Netseal Magic Number
        /// </summary>
        internal string MagicNumber
        {
            get {
                return Share.GetField("MagicNumber", BindingFlags.Static | BindingFlags.NonPublic).GetValue(null) as string;
            }
        }

        #endregion

        public License(string licensePath)
        {
            if (!File.Exists(licensePath))
                throw new FileNotFoundException("License file not found");

            byte[] assemblyBytes = File.ReadAllBytes(licensePath);
            Assembly = AppDomain.CurrentDomain.Load(assemblyBytes);
        }

        /// <summary>
        /// Initializes the Netseal system
        /// </summary>
        /// <param name="targetPath"></param>
        /// <exception cref="FileNotFoundException"
        internal void RunWE(string targetPath)
        {
            if (!File.Exists(targetPath))            
                throw new FileNotFoundException("The target path doesn't exist");      
      
            this.TargetPath = targetPath;

            Share.GetMethod("RunWE").Invoke(null, new object[]
            {
               new Version(NETSEAL_VERSION),
               new Version(DEFAULT_VERSION),
               END_POINT,
               targetPath 
            });
        }
        /// <summary>
        /// Set current Netseal ID
        /// </summary>
        /// <param name="id"></param>
        internal void SetID(string id)
        { 
            Share.GetMethod("SetID").Invoke(null, new object[] { id });            
            this.ID = id;
        }
        /// <summary>
        /// Set current Netseal license guid
        /// </summary>
        /// <param name="guid"></param>
        internal void SetGUID(string guid)
        {
            this.GUID = guid;
        }
        /// <summary>
        /// Invokes the Exchange
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        internal bool Exchange() 
        {
            this.ApiInstance = Activator.CreateInstance(API);

            if (string.IsNullOrWhiteSpace(this.ID))
                throw new Exception("ID");                        

            var exchange = (bool)API.GetMethod("Exchange").Invoke(ApiInstance, null);

            return exchange;
        }
        /// <summary>
        /// SignIn Netseal
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="sha1Password">Password as <see cref="SHA1"/></param>
        /// <returns></returns>
        internal bool SignIn(string username, string sha1Password)
        {
            return (bool)API.GetMethod("SignIn").Invoke(ApiInstance, new object[]
            {
                username,
                sha1Password
            });
        }
        /// <summary>
        /// Returns true if the Status is ok, false if not
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        internal bool GetStatus()
        {
            return (bool)API.GetMethod("GetStatus", BindingFlags.Public | BindingFlags.Instance).Invoke(ApiInstance, new object[] 
            {
                this.ID
            });
        }
        /// <summary>
        /// Check Netseal Saction
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Exception"
        internal bool Sanction()
        {
            if (string.IsNullOrWhiteSpace(this.GUID) || this.GUID.Length != 32)
                throw new Exception("GUID");                    

            return (bool)API.GetMethod("Sanction", BindingFlags.Public | BindingFlags.Instance).Invoke(ApiInstance, new object[]
            {
                this.ID,
                this.GUID,
                File.ReadAllBytes(TargetPath).GetMD5("x2"), // if this program has md5 check, your license could get banned if it's a invalid MD5 hash
                DEFAULT_VERSION
            });            
        }

        /// <summary>
        /// Fetch a variable from netseal
        /// </summary>
        /// <param name="variableName">Variable Name</param>
        /// <returns><see cref="string"/></returns>
        internal string GetVariable(string variableName)
        {
            return (string)Share.GetMethod("GetVariable").Invoke(null, new object[]
            {
                variableName
            });
        }
        /// <summary>
        /// Fetch news from netseal
        /// </summary>
        /// <returns><see cref="string"/></returns>
        internal object[] GetNews()
        {
            return (object[])Share.GetMethod("GetNews").Invoke(null, null);
        }
        /// <summary>
        /// Fetch a netseal post message from index 
        /// </summary>
        /// <param name="index"></param>
        /// <returns><see cref="string"/></returns>
        internal string GetPostMessage(int index)
        {
            return (string)Share.GetMethod("GetPostMessage").Invoke(null, new object[]
            {
               index 
            });
        }
        /// <summary>
        /// Spend Netseal points
        /// </summary>
        /// <param name="count">Number of points to spend</param>
        /// <returns><see cref="bool"/></returns>
        internal bool SpendPoints(int count)
        {
            return (bool)Share.GetMethod("SpendPoints").Invoke(null, new object[] 
            {
                count
            });
        }
        /// <summary>
        /// Not yet implemented
        /// </summary>
        internal void InstallUpdates()
        {
            //No yet implemented
        }
    }
}