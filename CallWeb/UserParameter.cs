using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallWeb
{
    public partial class UserParameter : UserControl
    {
        public UserParameter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 取得參數的Key
        /// </summary>
        /// <returns>Key</returns>
        public string GetKey()
        {
            return txt_Key.Text;
        }

        /// <summary>
        /// 取得參數的value
        /// </summary>
        /// <returns>value</returns>
        public string GetValue()
        {
            return txt_Value.Text;
        }
    }
}