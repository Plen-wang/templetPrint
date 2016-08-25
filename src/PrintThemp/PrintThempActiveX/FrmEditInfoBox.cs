using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace PrintThempActiveX
{
    /// <summary>
    /// 显示模板的详细信息
    /// </summary>
    public partial class FrmEditInfoBox : Form
    {
        #region 窗体变量及构造函数
        /// <summary>
        /// 确定是否移动控件
        /// </summary>
        bool ismove = false;
        /// <summary>
        /// 记录按下的鼠标位置
        /// </summary>
        Point p;
        /// <summary>
        /// 模板名称
        /// </summary>
        string EditPath;

        public FrmEditInfoBox(string editpaht)
        {
            InitializeComponent();
            EditPath = editpaht;
            InitFontStyle();
        }
        #endregion

        #region 移动窗体
        private void P_menu_MouseDown(object sender, MouseEventArgs e)
        {
            ismove = true;
            p = new Point(-e.X, -e.Y);
            this.Opacity = (float)80 / 100;
        }

        private void P_menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismove)
            {
                Point move = Control.MousePosition;
                move.Offset(p.X, p.Y);
                this.Location = move;

            }
        }

        private void P_menu_MouseUp(object sender, MouseEventArgs e)
        {
            ismove = false;
            this.Opacity = (float)100 / 100;
        }
        #endregion
        private void FrmEditInfoBox_Deactivate(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void FrmEditInfoBox_Load(object sender, EventArgs e)
        {
            try
            {

                string filepath = EditTemplateInfo.GetEditXmlPathName((EditPath.Substring(0, EditPath.IndexOf(".")) + ".xml"));
                Lb_editname.Text = EditTemplateInfo.GetEditXmlDocument((EditPath.Substring(0, EditPath.IndexOf(".")) + ".xml")).DocumentElement.ChildNodes[2].InnerText;
                Lb_createtime.Text = File.GetCreationTime(filepath).ToString();
                Lb_lastwritetime.Text = File.GetLastAccessTime(filepath).ToString();
                Lb_lastaccesstime.Text = File.GetLastWriteTime(filepath).ToString();
            }
            catch { }
        }

        private void Bt_edit_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// ActiveX插件会丢失样式，必须自己手动创建样式对象
        /// </summary>
        private void InitFontStyle()
        {
            foreach (Control child in Controls)
            {
                child.Font = new Font("宋体", 10);
            }
        }
    }
}
