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
        private Dictionary<string, string> _Parameters;
        private string _Url;

        public Factory(string url, Dictionary<string, string> parameter)
        {
            this._Parameters = parameter;
            this._Url = url;
        }

        public IMethod GetInstace(string type)
        {
            string assemblyName = ConfigurationManager.AppSettings["MethodNameSapce"];
            string ClassName = assemblyName + "." + type + "Method";
            IFactoryMethod MethodObj = (IFactoryMethod)Assembly.Load(assemblyName).
                CreateInstance(ClassName);
            return MethodObj.GetInstance(_Url, _Parameters);
        }
    }
}