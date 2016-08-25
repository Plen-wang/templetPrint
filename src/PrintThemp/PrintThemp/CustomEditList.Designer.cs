namespace PrintThemp
{
    partial class CustomEditList
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Pb_editbg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_editbg)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_editbg
            // 
            this.Pb_editbg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pb_editbg.Location = new System.Drawing.Point(0, 0);
            this.Pb_editbg.Name = "Pb_editbg";
            this.Pb_editbg.Size = new System.Drawing.Size(166, 228);
            this.Pb_editbg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_editbg.TabIndex = 0;
            this.Pb_editbg.TabStop = false;
            this.Pb_editbg.MouseLeave += new System.EventHandler(this.Pb_editbg_MouseLeave);
            this.Pb_editbg.Click += new System.EventHandler(this.Pb_editbg_Click);
            this.Pb_editbg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pb_editbg_MouseDown);
            this.Pb_editbg.MouseEnter += new System.EventHandler(this.Pb_editbg_MouseEnter);
            // 
            // CustomEditList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Pb_editbg);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "CustomEditList";
            this.Size = new System.Drawing.Size(166, 228);
            ((System.ComponentModel.ISupportInitialize)(this.Pb_editbg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_editbg;
    }
}
