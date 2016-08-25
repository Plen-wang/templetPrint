namespace PrintThemp
{
    partial class FrmEagleLook
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
            this.PB_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_img)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_img
            // 
            this.PB_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_img.Location = new System.Drawing.Point(0, 0);
            this.PB_img.Name = "PB_img";
            this.PB_img.Size = new System.Drawing.Size(122, 124);
            this.PB_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_img.TabIndex = 0;
            this.PB_img.TabStop = false;
            // 
            // FrmEagleLook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(122, 124);
            this.Controls.Add(this.PB_img);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEagleLook";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小地图";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.PB_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_img;

    }
}