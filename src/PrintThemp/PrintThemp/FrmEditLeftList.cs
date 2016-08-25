using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace PrintThemp
{
    /// <summary>
    /// 模板左列表显示每份模板的样式
    /// </summary>
    public partial class FrmEditLeftList : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public FrmEditLeftList()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 初始化模板列表
        /// </summary>
        private void FrmEditLeftList_Load(object sender, EventArgs e)
        {
            //获取模板名称集合
            foreach (object i in EditTemplateInfo.ReturnEditItemName())
            {
                //实例化模板集合中的子列表对象
                CustomEditList editlistchild = new CustomEditList(EditTemplateInfo.GetEditImg((i as string)));
                editlistchild.Tag = (i as string);//存储当前子对象所对应的模板名称
                editlistchild.Dock = DockStyle.Top;
                P_editlist.Controls.Add(editlistchild);
            }
        }
    }
}
