namespace CallWeb
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.list_data = new System.Windows.Forms.TextBox();
            this.ddlMethod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Panel_Parameter = new System.Windows.Forms.Panel();
            this.btn_addParameter = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(338, 42);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "查詢";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_URL
            // 
            this.txt_URL.Location = new System.Drawing.Point(71, 44);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(246, 22);
            this.txt_URL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL";
            this.label1.UseMnemonic = false;
            // 
            // list_data
            // 
            this.list_data.Location = new System.Drawing.Point(23, 107);
            this.list_data.Multiline = true;
            this.list_data.Name = "list_data";
            this.list_data.Size = new System.Drawing.Size(229, 254);
            this.list_data.TabIndex = 4;
            // 
            // ddlMethod
            // 
            this.ddlMethod.FormattingEnabled = true;
            this.ddlMethod.Location = new System.Drawing.Point(71, 12);
            this.ddlMethod.Name = "ddlMethod";
            this.ddlMethod.Size = new System.Drawing.Size(159, 20);
            this.ddlMethod.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "HttpMethod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "參數";
            // 
            // Panel_Parameter
            // 
            this.Panel_Parameter.Location = new System.Drawing.Point(278, 104);
            this.Panel_Parameter.Name = "Panel_Parameter";
            this.Panel_Parameter.Size = new System.Drawing.Size(407, 257);
            this.Panel_Parameter.TabIndex = 8;
            // 
            // btn_addParameter
            // 
            this.btn_addParameter.Location = new System.Drawing.Point(586, 71);
            this.btn_addParameter.Name = "btn_addParameter";
            this.btn_addParameter.Size = new System.Drawing.Size(23, 23);
            this.btn_addParameter.TabIndex = 9;
            this.btn_addParameter.Text = "+";
            this.btn_addParameter.UseVisualStyleBackColor = true;
            this.btn_addParameter.Click += new System.EventHandler(this.btn_addParameter_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(615, 71);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(23, 23);
            this.btn_Remove.TabIndex = 10;
            this.btn_Remove.Text = "-";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 403);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_addParameter);
            this.Controls.Add(this.Panel_Parameter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlMethod);
            this.Controls.Add(this.list_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_URL);
            this.Controls.Add(this.btn_search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox list_data;
        private System.Windows.Forms.ComboBox ddlMethod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Panel_Parameter;
        private System.Windows.Forms.Button btn_addParameter;
        private System.Windows.Forms.Button btn_Remove;
    }
}

