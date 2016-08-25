namespace PrintThempActiveX
{
    partial class FrmEditFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditFrm));
            this.Tool_close = new System.Windows.Forms.ToolStripMenuItem();
            this.P_bgimg = new System.Windows.Forms.Panel();
            this.CMS_editaddcontrol = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tool_controladd = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_pagemenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tool_preview = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_CustomMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Print_Dialog = new System.Windows.Forms.PrintPreviewDialog();
            this.CMS_editaddcontrol.SuspendLayout();
            this.CMS_pagemenu.SuspendLayout();
            this.CMS_CustomMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tool_close
            // 
            this.Tool_close.Name = "Tool_close";
            this.Tool_close.Size = new System.Drawing.Size(112, 22);
            this.Tool_close.Text = "关闭(&C)";
            // 
            // P_bgimg
            // 
            this.P_bgimg.BackColor = System.Drawing.Color.White;
            this.P_bgimg.ContextMenuStrip = this.CMS_editaddcontrol;
            this.P_bgimg.Location = new System.Drawing.Point(145, 3);
            this.P_bgimg.Name = "P_bgimg";
            this.P_bgimg.Size = new System.Drawing.Size(427, 510);
            this.P_bgimg.TabIndex = 3;
            this.P_bgimg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.P_bgimg_MouseMove);
            this.P_bgimg.Click += new System.EventHandler(this.P_bgimg_Click);
            this.P_bgimg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.P_bgimg_MouseDown);
            this.P_bgimg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.P_bgimg_MouseUp);
            // 
            // CMS_editaddcontrol
            // 
            this.CMS_editaddcontrol.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_controladd});
            this.CMS_editaddcontrol.Name = "CMS_editaddcontrol";
            this.CMS_editaddcontrol.Size = new System.Drawing.Size(137, 26);
            // 
            // Tool_controladd
            // 
            this.Tool_controladd.Name = "Tool_controladd";
            this.Tool_controladd.Size = new System.Drawing.Size(136, 22);
            this.Tool_controladd.Text = "添加控件(&A)";
            // 
            // CMS_pagemenu
            // 
            this.CMS_pagemenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_close,
            this.Tool_preview});
            this.CMS_pagemenu.Name = "contextMenuStrip1";
            this.CMS_pagemenu.Size = new System.Drawing.Size(113, 48);
            // 
            // Tool_preview
            // 
            this.Tool_preview.Name = "Tool_preview";
            this.Tool_preview.Size = new System.Drawing.Size(112, 22);
            this.Tool_preview.Text = "预览(&P)";
            // 
            // Tool_remove
            // 
            this.Tool_remove.Name = "Tool_remove";
            this.Tool_remove.Size = new System.Drawing.Size(136, 22);
            this.Tool_remove.Text = "移除控件(&R)";
            // 
            // CMS_CustomMenu
            // 
            this.CMS_CustomMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_remove});
            this.CMS_CustomMenu.Name = "CMS_CustomMenu";
            this.CMS_CustomMenu.Size = new System.Drawing.Size(137, 26);
            // 
            // Print_Dialog
            // 
            this.Print_Dialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.Print_Dialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.Print_Dialog.ClientSize = new System.Drawing.Size(400, 300);
            this.Print_Dialog.Enabled = true;
            this.Print_Dialog.Icon = ((System.Drawing.Icon)(resources.GetObject("Print_Dialog.Icon")));
            this.Print_Dialog.Name = "Print_Dialog";
            this.Print_Dialog.UseAntiAlias = true;
            this.Print_Dialog.Visible = false;
            // 
            // FrmEditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.P_bgimg);
            this.Name = "FrmEditFrm";
            this.Size = new System.Drawing.Size(761, 516);
            this.Load += new System.EventHandler(this.FrmEditFrm_Load);
            this.CMS_editaddcontrol.ResumeLayout(false);
            this.CMS_pagemenu.ResumeLayout(false);
            this.CMS_CustomMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem Tool_close;
        private System.Windows.Forms.ContextMenuStrip CMS_editaddcontrol;
        private System.Windows.Forms.ToolStripMenuItem Tool_controladd;
        private System.Windows.Forms.ContextMenuStrip CMS_pagemenu;
        private System.Windows.Forms.ToolStripMenuItem Tool_preview;
        private System.Windows.Forms.ToolStripMenuItem Tool_remove;
        private System.Windows.Forms.ContextMenuStrip CMS_CustomMenu;
        private System.Windows.Forms.PrintPreviewDialog Print_Dialog;
        public System.Windows.Forms.Panel P_bgimg;
    }
}
