using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSeal_Helper.NetSeal
{
    enum LicenseStatus : byte
    {
        Success = 0,
        Failed = 1,
        BadParams = 4,
        BadLength = 5,
        InvalidChars = 6,
        NullValue = 7,
        UsedValue = 8,
        AccessDenied = 9,
        LimitReached = 10,
        
        Expired = 13,
        Locked = 14,
        Banned = 15,

        SystemOffline = 255,
    }
}
