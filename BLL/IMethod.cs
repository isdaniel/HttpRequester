using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IMethod
    {
        /// <summary>
        /// 返回請求後的二進制流
        /// </summary>
        /// <returns>二進制流的返回值</returns>
        byte[] StreamByte();
    }
}