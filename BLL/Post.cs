using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Post : MethodBase
    {
        /// <summary>
        /// 初始化Post模式
        /// </summary>
        /// <param name="targetUrl">網址</param>
        /// <param name="parameters">參數</param>
        public Post(string url, Dictionary<string, string> parameters)
            : base(url, parameters)
        { }

        protected override HttpWebRequest GetWebRequest()
        {
            byte[] dataBytes = ParameterToByte();
            HttpWebRequest request = HttpWebRequest.Create(_Url) as HttpWebRequest;
            request.Method = "Post";//使用post
            request.ContentLength = dataBytes.Length;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Timeout = 30000;
            request.GetRequestStream().Write(dataBytes, 0, dataBytes.Length);
            return request;
        }

        /// <summary>
        /// 將Post參數轉程二進制流
        /// </summary>
        /// <returns>二進制流的參數</returns>
        private byte[] ParameterToByte()
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, string> item in _Parameter)
            {
                sb.Append(item.Key + "=" + item.Value + "&");
            }
            if (_Parameter.Count > 0)
                sb = sb.Remove(sb.Length - 1, 1);
            return Encoding.UTF8.GetBytes(sb.ToString());
        }
    }
}