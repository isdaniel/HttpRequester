using CallWeb;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public class UiControl
    {
        private int ParameterCount = 0;

        /// <summary>
        /// 案一下加一列
        /// </summary>
        public void AddParameter(Control Panel_Parameter)
        {
            UserParameter user = new UserParameter();
            user.Name = "Parameter" + ParameterCount;
            user.TabIndex = ParameterCount;
            user.Location = new Point(Panel_Parameter.Width / 5,
                (ParameterCount) * 51);
            user.Size = new Size(342, 51);
            Panel_Parameter.Controls.Add(user);
            ParameterCount = ParameterCount <= 4 ? ParameterCount + 1
                : ParameterCount;//最多五個參數
        }

        /// <summary>
        /// 移除參數
        /// </summary>
        /// <param name="Panel_Parameter"></param>
        /// <returns></returns>
        public void RemoveParameter(Control Panel_Parameter)
        {
            int removeIndex = (ParameterCount - 1);
            Panel_Parameter.Controls.RemoveByKey("Parameter" + removeIndex);
            ParameterCount = ParameterCount > 0 ? ParameterCount - 1
                : ParameterCount;//不能小於0
        }
    }
}