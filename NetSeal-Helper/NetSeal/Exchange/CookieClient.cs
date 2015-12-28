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

using System;
using System.Net;

namespace NetSeal_Helper.NetSeal.Exchange
{
    [System.ComponentModel.DesignerCategory("Code")]
    internal sealed class CookieClient : WebClient
    {
        private HttpWebRequest Request;

        public CookieContainer Cookies = new CookieContainer();
        protected override WebRequest GetWebRequest(Uri address)
        {
            Request = (HttpWebRequest)base.GetWebRequest(address);
            Request.Timeout = 8000;
            Request.ReadWriteTimeout = 30000;
            Request.KeepAlive = false;
            Request.CookieContainer = Cookies;
            Request.Proxy = null;
            return Request;
        }

        public void ClearCookies()
        {
            Cookies = new CookieContainer();
        }
    }
}