using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GetMethod : IFactoryMethod
    {
        /// <summary>
        /// 返回一個Get模式實體
        /// </summary>
        /// <param name="Url">網址</param>
        /// <param name="parameter">參數</param>
        /// <returns>Get模式</returns>
        public IMethod GetInstance(string Url, Dictionary<string, string> parameter)
        {
            return new Get(Url, parameter);
        }
    }
}