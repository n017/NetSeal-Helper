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

using NetSeal_Helper.Logger;

namespace NetSeal_Helper.Extensions
{
    public static class LoggerExtensions
    {
        /// <summary>
        /// Logs the <see cref="LoggingEventType.Information"/> event for an <see cref="ILogger"/> Object
        /// </summary>
        /// <param name="logger">ILogger object</param>
        /// <param name="message">Message to display</param>
        public static void LogInformation(this ILogger logger, string message)
        {
            logger.Log(message, LoggingEventType.Information);
        }
        /// <summary>
        /// Logs the <see cref="LoggingEventType.Error"/> event for an <see cref="ILogger"/> Object
        /// </summary>
        /// <param name="logger">ILogger object</param>
        /// <param name="message">Message to display</param>
        public static void LogError(this ILogger logger, string message)
        {
            logger.Log(message, LoggingEventType.Error);
        }
        /// <summary>
        /// Logs the <see cref="LoggingEventType.Warning"/> event for an <see cref="ILogger"/> Object
        /// </summary>
        /// <param name="logger">ILogger object</param>
        /// <param name="message">Message to display</param>
        public static void LogWarning(this ILogger logger, string message)
        {
            logger.Log(message, LoggingEventType.Warning);
        }
    }
}