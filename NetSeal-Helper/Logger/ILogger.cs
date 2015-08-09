using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSeal_Helper.Logger
{
    public interface ILogger
    {
        void Log(string message, LoggingEventType eventType);
    }
}
