namespace PrintThemp
{
    partial class FrmEditControlList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditControlList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lb_controlcount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lb_cname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_enter = new System.Windows.Forms.Button();
            this.DGV_CustomControlList = new System.Windows.Forms.DataGridView();
            this.tbindex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ismuiline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cms_multline = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tool_multis = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_multno = new System.Windows.Forms.ToolStripMenuItem();
            this.iswarp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cms_wrap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tool_wrapis = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_warpno = new System.Windows.Forms.ToolStripMenuItem();
            this.controltype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cms_controltype = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pointy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CustomControlList)).BeginInit();
            this.Cms_multline.SuspendLayout();
            this.Cms_wrap.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lb_controlcount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Lb_cname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Bt_enter);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // Lb_controlcount
            // 
            resources.ApplyResources(this.Lb_controlcount, "Lb_controlcount");
            this.Lb_controlcount.Name = "Lb_controlcount";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Lb_cname
            // 
            resources.ApplyResources(this.Lb_cname, "Lb_cname");
            this.Lb_cname.Name = "Lb_cname";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Bt_enter
            // 
            this.Bt_enter.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Bt_enter, "Bt_enter");
            this.Bt_enter.Name = "Bt_enter";
            this.Bt_enter.UseVisualStyleBackColor = false;
            this.Bt_enter.Click += new System.EventHandler(this.Bt_enter_Click);
            // 
            // DGV_CustomControlList
            // 
            this.DGV_CustomControlList.AllowUserToAddRows = false;
            this.DGV_CustomControlList.AllowUserToDeleteRows = false;
            this.DGV_CustomControlList.AllowUserToResizeRows = false;
            this.DGV_CustomControlList.BackgroundColor = System.Drawing.Color.White;
            this.DGV_CustomControlList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_CustomControlList.CausesValidation = false;
            this.DGV_CustomControlList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGV_CustomControlList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGV_CustomControlList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CustomControlList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbindex,
            this.cname,
            this.ename,
            this.width,
            this.height,
            this.ismuiline,
            this.iswarp,
            this.controltype,
            this.pointy,
            this.pointx});
            resources.ApplyResources(this.DGV_CustomControlList, "DGV_CustomControlList");
            this.DGV_CustomControlList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DGV_CustomControlList.MultiSelect = false;
            this.DGV_CustomControlList.Name = "DGV_CustomControlList";
            this.DGV_CustomControlList.RowHeadersVisible = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.DGV_CustomControlList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_CustomControlList.RowTemplate.Height = 18;
            this.DGV_CustomControlList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CustomControlList.StandardTab = true;
            this.DGV_CustomControlList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DGV_CustomControlList_DataError);
            // 
            // tbindex
            // 
            this.tbindex.DataPropertyName = "TAB_INDEX";
            resources.ApplyResources(this.tbindex, "tbindex");
            this.tbindex.Name = "tbindex";
            // 
            // cname
            // 
            this.cname.DataPropertyName = "ITEM_CNAME";
            resources.ApplyResources(this.cname, "cname");
            this.cname.Name = "cname";
            // 
            // ename
            // 
            this.ename.DataPropertyName = "ITEM_ENAME";
            resources.ApplyResources(this.ename, "ename");
            this.ename.Name = "ename";
            // 
            // width
            // 
            this.width.DataPropertyName = "ITEM_WIDTH";
            resources.ApplyResources(this.width, "width");
            this.width.Name = "width";
            // 
            // height
            // 
            this.height.DataPropertyName = "ITEM_HEIGHT";
            resources.ApplyResources(this.height, "height");
            this.height.Name = "height";
            // 
            // ismuiline
            // 
            this.ismuiline.ContextMenuStrip = this.Cms_multline;
            this.ismuiline.DataPropertyName = "MULTILINE";
            resources.ApplyResources(this.ismuiline, "ismuiline");
            this.ismuiline.Name = "ismuiline";
            this.ismuiline.ReadOnly = true;
            // 
            // Cms_multline
            // 
            this.Cms_multline.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_multis,
            this.Tool_multno});
            this.Cms_multline.Name = "Cms_multline";
            resources.ApplyResources(this.Cms_multline, "Cms_multline");
            this.Cms_multline.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Cms_multline_ItemClicked);
            // 
            // Tool_multis
            // 
            this.Tool_multis.Name = "Tool_multis";
            resources.ApplyResources(this.Tool_multis, "Tool_multis");
            // 
            // Tool_multno
            // 
            this.Tool_multno.Name = "Tool_multno";
            resources.ApplyResources(this.Tool_multno, "Tool_multno");
            // 
            // iswarp
            // 
            this.iswarp.ContextMenuStrip = this.Cms_wrap;
            this.iswarp.DataPropertyName = "WORD_WRAP";
            resources.ApplyResources(this.iswarp, "iswarp");
            this.iswarp.Name = "iswarp";
            this.iswarp.ReadOnly = true;
            // 
            // Cms_wrap
            // 
            this.Cms_wrap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_wrapis,
            this.Tool_warpno});
            this.Cms_wrap.Name = "Cms_wrap";
            resources.ApplyResources(this.Cms_wrap, "Cms_wrap");
            this.Cms_wrap.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Cms_wrap_ItemClicked);
            // 
            // Tool_wrapis
            // 
            this.Tool_wrapis.Name = "Tool_wrapis";
            resources.ApplyResources(this.Tool_wrapis, "Tool_wrapis");
            // 
            // Tool_warpno
            // 
            this.Tool_warpno.Name = "Tool_warpno";
            resources.ApplyResources(this.Tool_warpno, "Tool_warpno");
            // 
            // controltype
            // 
            this.controltype.ContextMenuStrip = this.Cms_controltype;
            this.controltype.DataPropertyName = "ITEM_TYPE";
            resources.ApplyResources(this.controltype, "controltype");
            this.controltype.Name = "controltype";
            this.controltype.ReadOnly = true;
            // 
            // Cms_controltype
            // 
            this.Cms_controltype.Name = "Cms_controltype";
            resources.ApplyResources(this.Cms_controltype, "Cms_controltype");
            this.Cms_controltype.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Cms_controltype_ItemClicked);
            // 
            // pointy
            // 
            this.pointy.DataPropertyName = "POS_Y";
            resources.ApplyResources(this.pointy, "pointy");
            this.pointy.Name = "pointy";
            // 
            // pointx
            // 
            this.pointx.DataPropertyName = "POS_X";
            resources.ApplyResources(this.pointx, "pointx");
            this.pointx.Name = "pointx";
            // 
            // FrmEditControlList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DGV_CustomControlList);
            this.Controls.Add(this.panel1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "FrmEditControlList";
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockBottomAutoHide;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmEditControlList_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEditControlList_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CustomControlList)).EndInit();
            this.Cms_multline.ResumeLayout(false);
            this.Cms_wrap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Bt_enter;
        private System.Windows.Forms.DataGridView DGV_CustomControlList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_cname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip Cms_multline;
        private System.Windows.Forms.ContextMenuStrip Cms_wrap;
        private System.Windows.Forms.ContextMenuStrip Cms_controltype;
        private System.Windows.Forms.Label Lb_controlcount;
        private System.Windows.Forms.ToolStripMenuItem Tool_multis;
        private System.Windows.Forms.ToolStripMenuItem Tool_multno;
        private System.Windows.Forms.ToolStripMenuItem Tool_wrapis;
        private System.Windows.Forms.ToolStripMenuItem Tool_warpno;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbindex;
        private System.Windows.Forms.DataGridViewTextBoxColumn cname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ename;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn height;
        private System.Windows.Forms.DataGridViewTextBoxColumn ismuiline;
        private System.Windows.Forms.DataGridViewTextBoxColumn iswarp;
        private System.Windows.Forms.DataGridViewTextBoxColumn controltype;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointy;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointx;

    }
}