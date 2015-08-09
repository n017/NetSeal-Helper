using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSeal_Helper.Logger;

namespace NetSeal_Helper.Extensions
{
    public static class LoggerExtensions
    {
        public static void LogInformation(this ILogger logger, string message)
        {
            logger.Log(message, LoggingEventType.Information);
        }
        public static void LogError(this ILogger logger, string message)
        {
            logger.Log(message, LoggingEventType.Error);
        }
        public static void LogWarning(this ILogger logger, string message)
        {
            logger.Log(message, LoggingEventType.Warning);
        }
    }
}
