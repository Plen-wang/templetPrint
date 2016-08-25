namespace PrintThempActiveX
{
    partial class FrmEditControlList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Cms_wrap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tool_wrapis = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_warpno = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_multno = new System.Windows.Forms.ToolStripMenuItem();
            this.Tool_multis = new System.Windows.Forms.ToolStripMenuItem();
            this.Cms_multline = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Cms_controltype = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Bt_enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lb_cname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lb_controlcount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGV_CustomControlList = new System.Windows.Forms.DataGridView();
            this.tbindex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ismuiline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iswarp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controltype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cms_wrap.SuspendLayout();
            this.Cms_multline.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CustomControlList)).BeginInit();
            this.SuspendLayout();
            // 
            // Cms_wrap
            // 
            this.Cms_wrap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_wrapis,
            this.Tool_warpno});
            this.Cms_wrap.Name = "Cms_wrap";
            this.Cms_wrap.Size = new System.Drawing.Size(83, 48);
            this.Cms_wrap.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Cms_wrap_ItemClicked);
            // 
            // Tool_wrapis
            // 
            this.Tool_wrapis.Name = "Tool_wrapis";
            this.Tool_wrapis.Size = new System.Drawing.Size(82, 22);
            this.Tool_wrapis.Text = "是";
            // 
            // Tool_warpno
            // 
            this.Tool_warpno.Name = "Tool_warpno";
            this.Tool_warpno.Size = new System.Drawing.Size(82, 22);
            this.Tool_warpno.Text = "否";
            // 
            // Tool_multno
            // 
            this.Tool_multno.Name = "Tool_multno";
            this.Tool_multno.Size = new System.Drawing.Size(82, 22);
            this.Tool_multno.Text = "否";
            // 
            // Tool_multis
            // 
            this.Tool_multis.Name = "Tool_multis";
            this.Tool_multis.Size = new System.Drawing.Size(82, 22);
            this.Tool_multis.Text = "是";
            // 
            // Cms_multline
            // 
            this.Cms_multline.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tool_multis,
            this.Tool_multno});
            this.Cms_multline.Name = "Cms_multline";
            this.Cms_multline.Size = new System.Drawing.Size(83, 48);
            this.Cms_multline.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Cms_multline_ItemClicked);
            // 
            // Cms_controltype
            // 
            this.Cms_controltype.Name = "Cms_controltype";
            this.Cms_controltype.Size = new System.Drawing.Size(61, 4);
            this.Cms_controltype.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Cms_controltype_ItemClicked);
            // 
            // Bt_enter
            // 
            this.Bt_enter.BackColor = System.Drawing.Color.Transparent;
            this.Bt_enter.Dock = System.Windows.Forms.DockStyle.Right;
            this.Bt_enter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Bt_enter.Location = new System.Drawing.Point(614, 0);
            this.Bt_enter.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Bt_enter.Name = "Bt_enter";
            this.Bt_enter.Size = new System.Drawing.Size(74, 24);
            this.Bt_enter.TabIndex = 0;
            this.Bt_enter.Text = "应用(&F5)";
            this.Bt_enter.UseVisualStyleBackColor = false;
            this.Bt_enter.Click += new System.EventHandler(this.Bt_enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "模板中文说明:";
            // 
            // Lb_cname
            // 
            this.Lb_cname.AutoSize = true;
            this.Lb_cname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_cname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lb_cname.Location = new System.Drawing.Point(115, 4);
            this.Lb_cname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_cname.Name = "Lb_cname";
            this.Lb_cname.Size = new System.Drawing.Size(29, 12);
            this.Lb_cname.TabIndex = 1;
            this.Lb_cname.Text = "合同";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(350, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(367, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "控件总数:";
            // 
            // Lb_controlcount
            // 
            this.Lb_controlcount.AutoSize = true;
            this.Lb_controlcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lb_controlcount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Lb_controlcount.Location = new System.Drawing.Point(464, 6);
            this.Lb_controlcount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_controlcount.Name = "Lb_controlcount";
            this.Lb_controlcount.Size = new System.Drawing.Size(17, 12);
            this.Lb_controlcount.TabIndex = 2;
            this.Lb_controlcount.Text = "10";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Lb_controlcount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Lb_cname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Bt_enter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 230);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 24);
            this.panel1.TabIndex = 3;
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
            this.DGV_CustomControlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_CustomControlList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DGV_CustomControlList.Location = new System.Drawing.Point(0, 0);
            this.DGV_CustomControlList.MultiSelect = false;
            this.DGV_CustomControlList.Name = "DGV_CustomControlList";
            this.DGV_CustomControlList.RowHeadersVisible = false;
            this.DGV_CustomControlList.RowHeadersWidth = 50;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            this.DGV_CustomControlList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_CustomControlList.RowTemplate.Height = 18;
            this.DGV_CustomControlList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_CustomControlList.Size = new System.Drawing.Size(688, 230);
            this.DGV_CustomControlList.StandardTab = true;
            this.DGV_CustomControlList.TabIndex = 4;
            // 
            // tbindex
            // 
            this.tbindex.DataPropertyName = "TAB_INDEX";
            this.tbindex.HeaderText = "Tab键索引";
            this.tbindex.Name = "tbindex";
            this.tbindex.Width = 120;
            // 
            // cname
            // 
            this.cname.DataPropertyName = "ITEM_CNAME";
            this.cname.HeaderText = "中文名称";
            this.cname.Name = "cname";
            this.cname.Width = 120;
            // 
            // ename
            // 
            this.ename.DataPropertyName = "ITEM_ENAME";
            this.ename.HeaderText = "英文名称";
            this.ename.Name = "ename";
            // 
            // width
            // 
            this.width.DataPropertyName = "ITEM_WIDTH";
            this.width.HeaderText = "宽度";
            this.width.Name = "width";
            // 
            // height
            // 
            this.height.DataPropertyName = "ITEM_HEIGHT";
            this.height.HeaderText = "高度";
            this.height.Name = "height";
            // 
            // ismuiline
            // 
            this.ismuiline.ContextMenuStrip = this.Cms_multline;
            this.ismuiline.DataPropertyName = "MULTILINE";
            this.ismuiline.HeaderText = "是否多行";
            this.ismuiline.Name = "ismuiline";
            this.ismuiline.ReadOnly = true;
            // 
            // iswarp
            // 
            this.iswarp.ContextMenuStrip = this.Cms_wrap;
            this.iswarp.DataPropertyName = "WORD_WRAP";
            this.iswarp.HeaderText = "是否换行";
            this.iswarp.Name = "iswarp";
            this.iswarp.ReadOnly = true;
            this.iswarp.Width = 120;
            // 
            // controltype
            // 
            this.controltype.ContextMenuStrip = this.Cms_controltype;
            this.controltype.DataPropertyName = "ITEM_TYPE";
            this.controltype.HeaderText = "控件类型";
            this.controltype.Name = "controltype";
            this.controltype.ReadOnly = true;
            this.controltype.Width = 130;
            // 
            // pointy
            // 
            this.pointy.DataPropertyName = "POS_Y";
            this.pointy.HeaderText = "坐标Y";
            this.pointy.Name = "pointy";
            // 
            // pointx
            // 
            this.pointx.DataPropertyName = "POS_X";
            this.pointx.HeaderText = "坐标X";
            this.pointx.Name = "pointx";
            // 
            // FrmEditControlList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.DGV_CustomControlList);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "FrmEditControlList";
            this.Size = new System.Drawing.Size(688, 254);
            this.Cms_wrap.ResumeLayout(false);
            this.Cms_multline.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CustomControlList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Cms_wrap;
        private System.Windows.Forms.ToolStripMenuItem Tool_wrapis;
        private System.Windows.Forms.ToolStripMenuItem Tool_warpno;
        private System.Windows.Forms.ToolStripMenuItem Tool_multno;
        private System.Windows.Forms.ToolStripMenuItem Tool_multis;
        private System.Windows.Forms.ContextMenuStrip Cms_multline;
        private System.Windows.Forms.ContextMenuStrip Cms_controltype;
        private System.Windows.Forms.Button Bt_enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lb_cname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lb_controlcount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGV_CustomControlList;
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
