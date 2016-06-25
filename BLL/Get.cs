using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Get : IMethod
    {
        private Dictionary<string, string> _Parameters;

        private string _Url;

        public Get(string targetUrl, Dictionary<string, string> parameters)
        {
            this._Parameters = parameters;
            this._Url = targetUrl + "?";
        }

        public byte[] StreamByte()
        {
            UrlWithParameter();
            byte[] RequsetData = { 0 };
            HttpWebRequest request = HttpWebRequest.Create(_Url) as HttpWebRequest;
            request.Method = "Get";//使用get
            request.ContentType = "application/x-www-form-urlencoded";
            request.Timeout = 30000;
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

        private void UrlWithParameter()
        {
            foreach (var item in _Parameters)
            {
                _Url += item.Key + "=" + item.Value + "&";
            }
            if (_Parameters.Count > 0)
                _Url = _Url.Remove(_Url.Length - 1);
        }
    }
}