using BLL;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CallWeb
{
    public partial class Form1 : Form
    {
        private UiControl control = new UiControl();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 移除參數按鈕【+】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addParameter_Click(object sender, EventArgs e)
        {
            control.AddParameter(this.Panel_Parameter);
        }

        /// <summary>
        /// 移除參數按鈕【-】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            control.RemoveParameter(this.Panel_Parameter);
        }

        /// <summary>
        /// 查詢按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> parameters = FillParameter();
            list_data.Text = "";
            string selectMethod = ddlMethod.SelectedItem.ToString();
            string url = txt_URL.Text;
            byte[] DataBytes = { 0 };
            Factory factory = new Factory(url, parameters);
            MethodBase MethodObj = factory.GetInstace(selectMethod);
            DataBytes = MethodObj.StreamByte();
            list_data.Text = Encoding.UTF8.GetString(DataBytes);
        }

        /// <summary>
        /// 控件中的值以參數形式填入Dictionary<string,string>中
        /// </summary>
        /// <returns>Key=Dictionary.key Value=Dictionary.value</returns>
        private Dictionary<string, string> FillParameter()
        {
            Dictionary<string, string> dir = new Dictionary<string, string>();
            var paras = this.Panel_Parameter.Controls;
            foreach (var item in paras)
            {
                UserParameter content = (UserParameter)item;
                dir.Add(content.GetKey(), content.GetValue());
            }
            return dir;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region ddlMethod預設值

            this.ddlMethod.Items.Add("Get");
            this.ddlMethod.Items.Add("Post");

            #endregion ddlMethod預設值

            ddlMethod.SelectedItem = "Get";//預設Get
        }
    }
}