using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSeal_Helper
{
    struct IdsDataBaseFormat
    {
        public string MD5Hash;
        public string ID;
        public string ProgramName;

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", MD5Hash, ID, ProgramName);
        }
    }
}
