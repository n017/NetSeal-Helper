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

namespace NetSeal_Helper.NetSeal
{
    enum LoginStatus : byte
    {
        /// <summary>
        /// Success logging in
        /// </summary>
        Success = 0,
        /// <summary>
        /// Failed to log in
        /// </summary>
        Failed = 1,
        /// <summary>
        /// Bad Parameters (not sure what's this)
        /// </summary>
        BadParams = 4,
        /// <summary>
        /// Bad Length
        /// </summary>
        BadLength = 5,
        /// <summary>
        /// The username contains invalid characters
        /// </summary>
        InvalidChars = 6,
        /// <summary>
        /// No license found in your system
        /// </summary>
        NullValue = 7,
        /// <summary>
        /// Used value
        /// </summary>
        UsedValue = 8,
        /// <summary>
        /// Access denied
        /// </summary>
        AccessDenied = 9,
        /// <summary>
        /// Limit reached
        /// </summary>
        LimitReached = 10,
        
        /// <summary>
        /// The license has expired
        /// </summary>
        Expired = 13,
        /// <summary>
        /// Local lock of your license
        /// </summary>
        Locked = 14,
        /// <summary>
        /// License banned on the server
        /// </summary>
        Banned = 15,

        /// <summary>
        /// Netseal system is offline
        /// </summary>
        SystemOffline = 255,
    }
}