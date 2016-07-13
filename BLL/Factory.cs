using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Factory
    {
        /// <summary>
        /// 參數
        /// </summary>
        private Dictionary<string, string> _Parameters;

        /// <summary>
        /// 網址
        /// </summary>
        private string _Url;

        /// <summary>
        /// 初始化網址的參數
        /// </summary>
        /// <param name="url">網址</param>
        /// <param name="parameter"><參數/param>
        public Factory(string url, Dictionary<string, string> parameter)
        {
            this._Parameters = parameter;
            this._Url = url;
        }

        /// <summary>
        /// 取得Http所使用的模式
        /// </summary>
        /// <param name="type">Http類型(Get,Post..)</param>
        /// <returns></returns>
        public MethodBase GetInstace(string type)
        {
            string assemblyName = ConfigurationManager.AppSettings["MethodNameSapce"];
            string ClassName = assemblyName + "." + type;
            return (MethodBase)Assembly.Load(assemblyName).CreateInstance(ClassName, true, BindingFlags.Default, null, new object[] { _Url, _Parameters }, null, null);
        }
    }
}