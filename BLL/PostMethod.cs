using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PostMethod : IFactoryMethod
    {
        /// <summary>
        /// 返回一個Post實體
        /// </summary>
        /// <param name="Url"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public IMethod GetInstance(string Url, Dictionary<string, string> parameter)
        {
            return new Post(Url, parameter);
        }
    }
}