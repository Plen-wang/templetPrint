namespace PrintThemp
{
    partial class FrmEditLeftList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditLeftList));
            this.P_editlist = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // P_editlist
            // 
            this.P_editlist.AutoScroll = true;
            this.P_editlist.BackColor = System.Drawing.Color.White;
            this.P_editlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P_editlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_editlist.Location = new System.Drawing.Point(0, 0);
            this.P_editlist.Name = "P_editlist";
            this.P_editlist.Size = new System.Drawing.Size(170, 518);
            this.P_editlist.TabIndex = 0;
            // 
            // FrmEditLeftList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 518);
            this.Controls.Add(this.P_editlist);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((((WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.DockTop)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditLeftList";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "模板列表";
            this.Load += new System.EventHandler(this.FrmEditLeftList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel P_editlist;
    }
}