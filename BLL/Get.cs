using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Get : MethodBase
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="targetUrl"></param>
        /// <param name="parameters"></param>
        public Get(string url, Dictionary<string, string> parameters)
            : base(url, parameters)
        { }

        /// <summary>
        /// HttpGet請求
        /// </summary>
        /// <returns>Get的二進制流返回值</returns>
        protected override HttpWebRequest GetWebRequest()
        {
            UrlWithParameter();
            byte[] RequsetData = { 0 };
            HttpWebRequest request = HttpWebRequest.Create(_Url) as HttpWebRequest;
            request.Method = "Get";//使用get
            request.ContentType = "application/x-www-form-urlencoded";
            request.Timeout = 30000;
            return request;
        }

        private void UrlWithParameter()
        {
            if (_Parameter.Count > 0)
            {
                _Url = _Url + "?";//因為是get所以url後要加?
                foreach (var item in _Parameter)
                {
                    _Url += item.Key + "=" + item.Value + "&";
                }
                _Url = _Url.Remove(_Url.Length - 1);
            }
        }
    }
}