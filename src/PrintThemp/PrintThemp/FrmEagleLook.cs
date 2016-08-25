using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrintThemp
{
    /// <summary>
    /// 激活编辑模板的鹰眼面板
    /// </summary>
    public partial class FrmEagleLook :Form
    {
        public FrmEagleLook()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 重载构造函数|实现鹰眼的地图效果
        /// </summary>
        /// <param name="name">当前面板的底图名称</param>
        public FrmEagleLook(string name)
        {
            InitializeComponent();
            Image imgzoom = EditTemplateInfo.GetEditImg(name);
            int imgwidth = imgzoom.Width / 4;
            int imgheight = imgzoom.Height / 4;
            Bitmap bmp = new Bitmap(imgzoom, imgwidth, imgheight);
            PB_img.Width = imgwidth;
            PB_img.Height = imgheight;
            PB_img.Image = bmp;

        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
        }
    }
}
