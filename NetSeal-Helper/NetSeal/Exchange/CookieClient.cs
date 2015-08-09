using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetSeal_Helper.NetSeal.Echange
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
