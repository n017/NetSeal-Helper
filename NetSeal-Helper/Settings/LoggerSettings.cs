using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSeal_Helper.Settings
{
    [Serializable]
    public struct LoggerSettings
    {
        public string TimeColor 
        {
            get;
            set;
        }
        public string InformationColor 
        {
            get;
            set;
        }
        public string ErrorColor 
        {
            get;
            set;
        }
        public string WarningColor 
        {
            get;
            set;
        }
        public string BackColor 
        {
            get;
            set;
        }
    }
}
