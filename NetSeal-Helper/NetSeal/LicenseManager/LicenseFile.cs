using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSeal_Helper.NetSeal.LicenseManager
{
    struct LicenseFile
    {
        public string LicenseName;

        public string ID;
        public string GUID;

        public bool Unknown; //Never used
        public bool Remember;

        public string Username;
        public string Sha1Password;

        public LicenseFramework Framework;
    }
}
