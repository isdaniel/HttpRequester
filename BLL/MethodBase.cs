using Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class MethodBase
    {
        /// <summary>
        /// 初始網址和參數
        /// </summary>
        /// <param name="url">網址列</param>
        /// <param name="parameter">參數</param>
        protected MethodBase(string url, Dictionary<string, string> parameter)
        {
            this._Parameter = parameter;
            this._Url = url;
        }

        /// <summary>
        /// 參數
        /// </summary>
        protected Dictionary<string, string> _Parameter { get; set; }

        /// <summary>
        /// 網址
        /// </summary>
        protected string _Url { get; set; }

        /// <summary>
        /// 返回請求後的二進制流
        /// </summary>
        /// <returns>二進制流的返回值</returns>
        public byte[] StreamByte()
        {
            LogWriter log = new LogWriter("MyLog");
            byte[] Data = { 0 };
            try
            {
                HttpWebRequest request = GetWebRequest();//此方法會有子類來實做
                using (HttpWebResponse response =
                    request.GetResponse() as HttpWebResponse)
                {
                    Stream stream = response.GetResponseStream();
                    MemoryStream memory = new MemoryStream();
                    stream.CopyTo(memory);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        Data = new byte[memory.Length];
                        memory.Position = 0;
                        memory.Read(Data, 0, Convert.ToInt32(memory.Length));
                    }
                    stream.Close();
                    memory.Close();
                    log.WriteLog("撈取成功");
                }
            }
            catch (Exception ex)
            {
                log.WriteErrorLog("MethodBase錯誤", ex);
            }
            return Data;
        }

        /// <summary>
        /// 繼承的子類必須要實現他(設置WebReqest的值)
        /// </summary>
        /// <returns></returns>
        protected abstract HttpWebRequest GetWebRequest();
    }
}