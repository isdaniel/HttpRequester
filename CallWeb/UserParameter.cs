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

        public string GetKey()
        {
            return txt_Key.Text;
        }

        public string GetValue()
        {
            return txt_Value.Text;
        }
    }
}