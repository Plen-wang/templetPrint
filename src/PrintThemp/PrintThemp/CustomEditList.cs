using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace PrintThemp
{
    /// <summary>
    /// 模板左列表中的子对象
    /// </summary>
    public partial class CustomEditList : UserControl
    {
        public CustomEditList(System.Drawing.Image bgimg)
        {
            InitializeComponent();
            Pb_editbg.Image = bgimg;
        }

        private void Pb_editbg_MouseLeave(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Pb_editbg_MouseEnter(object sender, EventArgs e)
        {
            this.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Pb_editbg_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                FrmEditInfoBox infobox = new FrmEditInfoBox(this.Tag.ToString());
                infobox.SetDesktopLocation(Control.MousePosition.X, Control.MousePosition.Y);
                infobox.Show();
            }
        }

        private void Pb_editbg_Click(object sender, EventArgs e)
        {
            EditEventReferences.ActiveFacilityEditEvent(this.Tag.ToString());
        }

    }
}
