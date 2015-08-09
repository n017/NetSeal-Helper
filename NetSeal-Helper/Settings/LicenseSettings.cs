using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSeal_Helper.Settings
{
    [Serializable]
    public struct LicenseSettings
    {
        public bool LoadCredentials 
        {
            get;
            set;
        }
        public string UserName 
        {
            get;
            set;
        }
        public string Password 
        {
            get;
            set;
        }
    }
}
