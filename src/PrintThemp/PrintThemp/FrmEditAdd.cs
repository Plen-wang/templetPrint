using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace PrintThemp
{
    /// <summary>
    /// 添加模板
    /// </summary>
    public partial class FrmEditAdd : Form
    {
        public FrmEditAdd()
        {
            InitializeComponent();
        }

        private void Bt_browser_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Tb_bmppath.Text = openFileDialog1.FileName;
            }
        }

        private void Bt_enter_Click(object sender, EventArgs e)
        {
            try
            {

                if (Tb_ename.Text.Length > 0 && Tb_cname.Text.Length > 0 && Tb_bmppath.Text.Length > 0)
                {
                    //拷贝底图
                    File.Copy(Tb_bmppath.Text, Application.StartupPath + "\\Themplate\\" + Tb_cname.Text + ".bmp");
                    //建立DOM文档
                    XmlDocument document = new XmlDocument();
                    XmlDeclaration decl = document.CreateXmlDeclaration("1.0", "UTF-8", null);//XML申明
                    document.AppendChild(decl);
                    XmlElement Custom_Root = document.CreateElement("Custom_Root");//根节点
                    EditTemplateMethod.AppendChildElement(document, Custom_Root, "CODE", Tb_code.Text);//模板代码
                    EditTemplateMethod.AppendChildElement(document, Custom_Root, "BACK_IMG", Tb_ename.Text);//模板底图
                    EditTemplateMethod.AppendChildElement(document, Custom_Root, "CNAME", Tb_code.Text);//模板中文名称
                    EditTemplateMethod.AppendChildElement(document, Custom_Root, "ENAME", Tb_ename.Text);//模板英文名称
                    EditTemplateMethod.AppendChildElement(document, Custom_Root, "ITEMS", "");//模板控件列表|默认为空
                    document.AppendChild(Custom_Root);
                    document.Save(Application.StartupPath + "\\Themplate\\" + Tb_cname.Text + ".xml");//保存模板
                    MessageBox.Show("添加成功!", "信息提示");
                }
            }
            catch(Exception err) { MessageBox.Show("不能指定同名模板", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
