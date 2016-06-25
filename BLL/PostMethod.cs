using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PostMethod : IFactoryMethod
    {
        public IMethod GetInstance(string Url, Dictionary<string, string> parameter)
        {
            return new Post(Url, parameter);
        }
    }
}