using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Post : IMethod
    {
        private Dictionary<string, string> _Parameters;

        private string _Url;

        public Post(string targetUrl, Dictionary<string, string> parameters)
        {
            this._Parameters = parameters;
            this._Url = targetUrl;
        }

        /// <summary>
        /// HttpPost請求
        /// </summary>
        /// <param name="targetUrl">網址</param>
        /// <param name="parameters">參數(可多個)</param>
        /// <returns>回傳請求後的流 回傳0為失敗</returns>
        public byte[] StreamByte()
        {
            byte[] RequsetData = { 0 };
            byte[] dataBytes = ParameterToByte();
            HttpWebRequest request = HttpWebRequest.Create(_Url) as HttpWebRequest;
            request.Method = "Post";//使用post
            request.ContentLength = dataBytes.Length;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Timeout = 30000;
            request.GetRequestStream().Write(dataBytes, 0, dataBytes.Length);
            using (HttpWebResponse response =
                request.GetResponse() as HttpWebResponse)
            {
                Stream stream = response.GetResponseStream();
                MemoryStream memory = new MemoryStream();
                stream.CopyTo(memory);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    RequsetData = new byte[memory.Length];
                    memory.Position = 0;
                    memory.Read(RequsetData, 0, Convert.ToInt32(memory.Length));
                }
                stream.Close();
                memory.Close();
            }
            return RequsetData;
        }

        private byte[] ParameterToByte()
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, string> item in _Parameters)
            {
                sb.Append(item.Key + "=" + item.Value + "&");
            }
            if (_Parameters.Count > 0)
                sb = sb.Remove(sb.Length - 1, 1);
            return Encoding.UTF8.GetBytes(sb.ToString());
        }
    }
}