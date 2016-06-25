﻿using BLL;
using Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
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

        private void btn_addParameter_Click(object sender, EventArgs e)
        {
            control.AddParameter(this.Panel_Parameter);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            control.RemoveParameter(this.Panel_Parameter);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> parameters = FillParameter();
            list_data.Text = "";
            string selectMethod = ddlMethod.SelectedItem.ToString();
            string url = txt_URL.Text;
            byte[] DataBytes = { 0 };
            Factory factory = new Factory(url, parameters);
            IMethod MethodObj = factory.GetInstace(selectMethod);
            DataBytes = MethodObj.StreamByte();
            list_data.Text = Encoding.UTF8.GetString(DataBytes);
        }

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
            this.ddlMethod.Items.Add("Get");
            this.ddlMethod.Items.Add("Post");
        }
    }
}