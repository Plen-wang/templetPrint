namespace PrintThemp
{
    partial class FrmEditInfoBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.P_menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_edit = new System.Windows.Forms.Button();
            this.Lb_lastaccesstime = new System.Windows.Forms.Label();
            this.Lb_lastwritetime = new System.Windows.Forms.Label();
            this.Lb_createtime = new System.Windows.Forms.Label();
            this.Lb_editname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.P_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.P_menu);
            this.panel1.Controls.Add(this.Bt_edit);
            this.panel1.Controls.Add(this.Lb_lastaccesstime);
            this.panel1.Controls.Add(this.Lb_lastwritetime);
            this.panel1.Controls.Add(this.Lb_createtime);
            this.panel1.Controls.Add(this.Lb_editname);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 158);
            this.panel1.TabIndex = 1;
            // 
            // P_menu
            // 
            this.P_menu.BackColor = System.Drawing.Color.SlateGray;
            this.P_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_menu.Controls.Add(this.label1);
            this.P_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.P_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_menu.Location = new System.Drawing.Point(0, 0);
            this.P_menu.Name = "P_menu";
            this.P_menu.Size = new System.Drawing.Size(422, 17);
            this.P_menu.TabIndex = 2;
            this.P_menu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.P_menu_MouseMove);
            this.P_menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_menu_MouseDown);
            this.P_menu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P_menu_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "模板信息:";
            // 
            // Bt_edit
            // 
            this.Bt_edit.Location = new System.Drawing.Point(332, 129);
            this.Bt_edit.Name = "Bt_edit";
            this.Bt_edit.Size = new System.Drawing.Size(75, 23);
            this.Bt_edit.TabIndex = 1;
            this.Bt_edit.Text = "编辑";
            this.Bt_edit.UseVisualStyleBackColor = true;
            this.Bt_edit.Click += new System.EventHandler(this.Bt_edit_Click);
            // 
            // Lb_lastaccesstime
            // 
            this.Lb_lastaccesstime.AutoSize = true;
            this.Lb_lastaccesstime.Location = new System.Drawing.Point(151, 134);
            this.Lb_lastaccesstime.Name = "Lb_lastaccesstime";
            this.Lb_lastaccesstime.Size = new System.Drawing.Size(59, 12);
            this.Lb_lastaccesstime.TabIndex = 0;
            this.Lb_lastaccesstime.Text = "2010-10-9";
            // 
            // Lb_lastwritetime
            // 
            this.Lb_lastwritetime.AutoSize = true;
            this.Lb_lastwritetime.Location = new System.Drawing.Point(151, 105);
            this.Lb_lastwritetime.Name = "Lb_lastwritetime";
            this.Lb_lastwritetime.Size = new System.Drawing.Size(59, 12);
            this.Lb_lastwritetime.TabIndex = 0;
            this.Lb_lastwritetime.Text = "2010-10-8";
            // 
            // Lb_createtime
            // 
            this.Lb_createtime.AutoSize = true;
            this.Lb_createtime.Location = new System.Drawing.Point(151, 78);
            this.Lb_createtime.Name = "Lb_createtime";
            this.Lb_createtime.Size = new System.Drawing.Size(59, 12);
            this.Lb_createtime.TabIndex = 0;
            this.Lb_createtime.Text = "2010-10-7";
            // 
            // Lb_editname
            // 
            this.Lb_editname.AutoSize = true;
            this.Lb_editname.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Lb_editname.Location = new System.Drawing.Point(150, 50);
            this.Lb_editname.Name = "Lb_editname";
            this.Lb_editname.Size = new System.Drawing.Size(35, 14);
            this.Lb_editname.TabIndex = 0;
            this.Lb_editname.Text = "合同";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "最经访问时间:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "最经修改时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "创建时间:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "模板名称:";
            // 
            // FrmEditInfoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(424, 158);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditInfoBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmEditInfoBox";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Deactivate += new System.EventHandler(this.FrmEditInfoBox_Deactivate);
            this.Load += new System.EventHandler(this.FrmEditInfoBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.P_menu.ResumeLayout(false);
            this.P_menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lb_createtime;
        private System.Windows.Forms.Label Lb_editname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lb_lastaccesstime;
        private System.Windows.Forms.Label Lb_lastwritetime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Bt_edit;
        private System.Windows.Forms.Panel P_menu;
        private System.Windows.Forms.Label label1;
    }
}