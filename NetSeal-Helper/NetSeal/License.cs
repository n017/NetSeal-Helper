using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Security.Cryptography;
using System.Net;
using NetSeal_Helper.Extensions;
using NetSeal_Helper.NetSeal.LicenseManager;

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

        private string TargetPath { get; set; }
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

        private Type Share 
        {
            get 
            { 
                return Assembly.ManifestModule.GetType("Share"); 
            }
        }
        private Type API 
        {
            get
            {
                return Assembly.ManifestModule.GetType("API");
            }
        }

        private Assembly _assembly;
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
        internal int UsersOnline 
        {
            get
            {
                return (int)Share.GetMethod("GetUsersOnline").Invoke(null, new object[] { });
            }
        }
        internal int UsersCount 
        {
            get {
                return (int)Share.GetMethod("GetUsersCount").Invoke(null, new object[] { });
            }
        }
        internal string Username 
        { 
            get {
                return (string)Share.GetMethod("GetUsername").Invoke(null, null);
            }
        }
        internal bool UpdateAvailable 
        { 
            get {
                return (bool)Share.GetMethod("GetUpdateAvailable").Invoke(null, null);
            }
        }
        internal TimeSpan RemainingTime 
        {
            get {
                return (TimeSpan)Share.GetMethod("GetRemaining").Invoke(null, null);                
            }
        }
        internal string PublicToken 
        {
            get {
                return (string)Share.GetMethod("GetPublicToken").Invoke(null, null);
            }
        }
        internal byte[] PrivateKey 
        {
            get {
                return (byte[])Share.GetMethod("GetPrivateKey").Invoke(null, null);
            }
        }
        internal int PointsCount 
        {
            get {
                return (int)Share.GetMethod("GetPoints").Invoke(null, null);
            }
        }
        internal string GlobalMessage 
        {
            get {
                return (string)Share.GetMethod("GetMessage").Invoke(null, null);
            }
        }
        internal LicenseType LicenseType 
        {
            get {
                return (LicenseType)Share.GetMethod("GetLicenseType").Invoke(null, null);
            }
        }
        internal IPAddress IPAddress 
        {
            get {
                return (IPAddress)Share.GetMethod("GetIPAddress").Invoke(null, null);
            }
        }
        internal DateTime Expiration 
        {
            get {
                return (DateTime)Share.GetMethod("GetExpiration").Invoke(null, null);
            }
        }
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
        internal void SetID(string id)
        { 
            Share.GetMethod("SetID").Invoke(null, new object[] { id });            
            this.ID = id;
        }
        internal void SetGUID(string guid)
        {
            this.GUID = guid;
        }
        internal bool Exchange() 
        {
            this.ApiInstance = Activator.CreateInstance(API);

            if (string.IsNullOrWhiteSpace(this.ID))
                throw new Exception("ID");                        

            var exchange = (bool)API.GetMethod("Exchange").Invoke(ApiInstance, null);

            return exchange;
        }
        internal bool SignIn(string username, string sha1Password)
        {
            return (bool)API.GetMethod("SignIn").Invoke(ApiInstance, new object[]
            {
                username,
                sha1Password
            });
        }
        internal bool GetStatus()
        {
            return (bool)API.GetMethod("GetStatus", BindingFlags.Public | BindingFlags.Instance).Invoke(ApiInstance, new object[] 
            {
                this.ID
            });
        }
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

        internal string GetVariable(string variableName)
        {
            return (string)Share.GetMethod("GetVariable").Invoke(null, new object[]
            {
                variableName
            });
        }
        internal object[] GetNews()
        {
            return (object[])Share.GetMethod("GetNews").Invoke(null, null);
        }
        internal string GetPostMessage(int index)
        {
            return (string)Share.GetMethod("GetPostMessage").Invoke(null, new object[]
            {
               index 
            });
        }
        internal bool SpendPoints(int count)
        {
            return (bool)Share.GetMethod("SpendPoints").Invoke(null, new object[] 
            {
                count
            });
        }
        internal void InstallUpdates()
        {
            //No yet implemented
        }
    }
}