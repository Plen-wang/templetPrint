namespace PrintThemp
{
    partial class FrmEditfrom
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditfrom));
            this.P_bgimg = new System.Windows.Forms.Panel();
            this.CMS_editaddcontrol = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tool_controladd = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_CustomMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tool_remove = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_pagemenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tool_close = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_preview = new System.Windows.Forms.ToolStripMenuItem();
            this.Print_Dialog = new System.Windows.Forms.PrintPreviewDialog();
            this.CMS_editaddcontrol.SuspendLayout();
            this.CMS_CustomMenu.SuspendLayout();
            this.CMS_pagemenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_bgimg
            // 
            this.P_bgimg.BackColor = System.Drawing.Color.White;
            this.P_bgimg.ContextMenuStrip = this.CMS_editaddcontrol;
            this.P_bgimg.Location = new System.Drawing.Point(78, 0);
            this.P_bgimg.Name = "P_bgimg";
            this.P_bgimg.Size = new System.Drawing.Size(386, 505);
            this.P_bgimg.TabIndex = 2;
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
            this.Tool_controladd.Click += new System.EventHandler(this.Tool_controladd_Click);
            // 
            // CMS_CustomMenu
            // 
            this.CMS_CustomMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_remove});
            this.CMS_CustomMenu.Name = "CMS_CustomMenu";
            this.CMS_CustomMenu.Size = new System.Drawing.Size(137, 26);
            // 
            // Tool_remove
            // 
            this.Tool_remove.Name = "Tool_remove";
            this.Tool_remove.Size = new System.Drawing.Size(136, 22);
            this.Tool_remove.Text = "移除控件(&R)";
            this.Tool_remove.Click += new System.EventHandler(this.Tool_remove_Click);
            // 
            // CMS_pagemenu
            // 
            this.CMS_pagemenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_close,
            this.Tool_preview});
            this.CMS_pagemenu.Name = "contextMenuStrip1";
            this.CMS_pagemenu.Size = new System.Drawing.Size(113, 48);
            // 
            // Tool_close
            // 
            this.Tool_close.Name = "Tool_close";
            this.Tool_close.Size = new System.Drawing.Size(112, 22);
            this.Tool_close.Text = "关闭(&C)";
            this.Tool_close.Click += new System.EventHandler(this.Tool_close_Click);
            // 
            // Tool_preview
            // 
            this.Tool_preview.Name = "Tool_preview";
            this.Tool_preview.Size = new System.Drawing.Size(112, 22);
            this.Tool_preview.Text = "预览(&P)";
            this.Tool_preview.Click += new System.EventHandler(this.Tool_preview_Click);
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
            // FrmEditfrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(920, 505);
            this.Controls.Add(this.P_bgimg);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditfrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabPageContextMenuStrip = this.CMS_pagemenu;
            this.Load += new System.EventHandler(this.FrmEditfrom_Load);
            this.Activated += new System.EventHandler(this.FrmEditfrom_Activated);
            this.CMS_editaddcontrol.ResumeLayout(false);
            this.CMS_CustomMenu.ResumeLayout(false);
            this.CMS_pagemenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip CMS_CustomMenu;
        private System.Windows.Forms.ToolStripMenuItem Tool_remove;
        private System.Windows.Forms.ContextMenuStrip CMS_pagemenu;
        private System.Windows.Forms.ToolStripMenuItem Tool_close;
        private System.Windows.Forms.PrintPreviewDialog Print_Dialog;
        private System.Windows.Forms.ToolStripMenuItem Tool_preview;
        private System.Windows.Forms.ContextMenuStrip CMS_editaddcontrol;
        private System.Windows.Forms.ToolStripMenuItem Tool_controladd;
        private System.Windows.Forms.Panel P_bgimg;
    }
}