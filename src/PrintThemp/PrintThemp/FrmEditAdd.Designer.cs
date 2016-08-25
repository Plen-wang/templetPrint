namespace PrintThemp
{
    partial class FrmEditAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_bmppath = new System.Windows.Forms.TextBox();
            this.Bt_browser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_cname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Bt_enter = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_ename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tb_code = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "模板底图:";
            // 
            // Tb_bmppath
            // 
            this.Tb_bmppath.Location = new System.Drawing.Point(101, 103);
            this.Tb_bmppath.Name = "Tb_bmppath";
            this.Tb_bmppath.ReadOnly = true;
            this.Tb_bmppath.Size = new System.Drawing.Size(233, 21);
            this.Tb_bmppath.TabIndex = 4;
            // 
            // Bt_browser
            // 
            this.Bt_browser.Location = new System.Drawing.Point(340, 103);
            this.Bt_browser.Name = "Bt_browser";
            this.Bt_browser.Size = new System.Drawing.Size(75, 23);
            this.Bt_browser.TabIndex = 5;
            this.Bt_browser.Text = "浏览";
            this.Bt_browser.UseVisualStyleBackColor = true;
            this.Bt_browser.Click += new System.EventHandler(this.Bt_browser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "模板中文名称:";
            // 
            // Tb_cname
            // 
            this.Tb_cname.Location = new System.Drawing.Point(101, 6);
            this.Tb_cname.Name = "Tb_cname";
            this.Tb_cname.Size = new System.Drawing.Size(180, 21);
            this.Tb_cname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "注:模板底图对应模板打印时的纸面信息，模板名称对应编辑模板时的名称";
            // 
            // Bt_enter
            // 
            this.Bt_enter.Location = new System.Drawing.Point(432, 170);
            this.Bt_enter.Name = "Bt_enter";
            this.Bt_enter.Size = new System.Drawing.Size(75, 23);
            this.Bt_enter.TabIndex = 6;
            this.Bt_enter.Text = "确定";
            this.Bt_enter.UseVisualStyleBackColor = true;
            this.Bt_enter.Click += new System.EventHandler(this.Bt_enter_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = ".BMP|*.bmp";
            this.openFileDialog1.Title = "浏览模板底图";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "模板英文名称:";
            // 
            // Tb_ename
            // 
            this.Tb_ename.Location = new System.Drawing.Point(101, 40);
            this.Tb_ename.Name = "Tb_ename";
            this.Tb_ename.Size = new System.Drawing.Size(180, 21);
            this.Tb_ename.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "模板代码:";
            // 
            // Tb_code
            // 
            this.Tb_code.Location = new System.Drawing.Point(101, 72);
            this.Tb_code.Name = "Tb_code";
            this.Tb_code.Size = new System.Drawing.Size(180, 21);
            this.Tb_code.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(287, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(287, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "*";
            // 
            // FrmEditAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 200);
            this.Controls.Add(this.Tb_code);
            this.Controls.Add(this.Tb_ename);
            this.Controls.Add(this.Tb_cname);
            this.Controls.Add(this.Bt_enter);
            this.Controls.Add(this.Bt_browser);
            this.Controls.Add(this.Tb_bmppath);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加模板";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_bmppath;
        private System.Windows.Forms.Button Bt_browser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_cname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bt_enter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tb_ename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tb_code;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}