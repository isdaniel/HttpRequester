using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IFactoryMethod
    {
        /// <summary>
        /// 取得一個實體(實現IMethod的實體Http模式)
        /// </summary>
        /// <param name="Url">網址</param>
        /// <param name="parameter">參數</param>
        /// <returns></returns>
        IMethod GetInstance(string Url, Dictionary<string, string> parameter);
    }
}