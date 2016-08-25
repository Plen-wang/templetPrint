using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PrintThempActiveX
{
    [ComVisible(true)]
    [Guid("3CF4EB62-5318-4a27-8FB8-89FA7D2B76D5")]
    public partial class FrmEditMainPanel : UserControl
    {
        #region 窗体变量及构造函数
        /// <summary>
        /// 每个可编辑模板都对应一个编辑模板实例对象
        /// </summary>
        FrmEditFrm editfrom;
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public FrmEditMainPanel()
        {
            //启用应用程序样式
            InitializeComponent();
            Application.EnableVisualStyles();
            //InitFontStyle();
            EditEventReferences.FacilityEditEvent += new EditEventReferences.FacilityEdit(EditEventReferences_FacilityEditEvent);
        }
        #endregion
        /// <summary>
        /// 其他菜单中编辑模板命令
        /// </summary>
        void EditEventReferences_FacilityEditEvent(string editname)
        {
            EditItem.SelectedIndex = EditItem.FindString(editname);
        }
        //窗体加载时|加载一些模板信息列表
        private void FrmEditMainPanel_Load(object sender, EventArgs e)
        {
            //设置选择模板下拉列表项
            for (int i = 0; i < EditTemplateInfo.ReturnEditItemName().Count; i++)
            {
                EditItem.Items.Add(EditTemplateInfo.ReturnEditItemName()[i].ToString());
            }
            EditItem.SelectedIndex = 0;
            //设置控件列表面板
            Controllist_Click(null, null);
            DockLeft();
        }
        /// <summary>
        /// 编辑模板
        /// </summary>
        private void EditItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            editfrom = new FrmEditFrm(EditItem.SelectedItem.ToString());
            editfrom.Dock = DockStyle.Fill;
            editfrom.Text = EditItem.SelectedItem.ToString();
            editfrom.ControlMouse += new FrmEditFrm.ActiveMouse(editfrom_ControlMouse);
            editfrom.ActiveEditMouse += new FrmEditFrm.EditMouse(editfrom_ActiveEditMouse);

            TabPage edittabpage = new TabPage();
            edittabpage.AutoScroll = false;
            edittabpage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            edittabpage.Location = new System.Drawing.Point(4, 24);
            edittabpage.Name = editfrom.Text;
            edittabpage.Text = editfrom.Text;
            edittabpage.Padding = new System.Windows.Forms.Padding(3);
            edittabpage.Size = new Size(editfrom.P_bgimg.Width, editfrom.P_bgimg.Height);
            edittabpage.TabIndex = 0;
            edittabpage.UseVisualStyleBackColor = true;

            edittabpage.Controls.Add(editfrom);
            Tab_editlist.Controls.Add(edittabpage);
            Tab_editlist.SelectedIndex = Tab_editlist.TabPages.Count - 1;
        }
        /// <summary>
        /// 鼠标的位置
        /// </summary>
        void editfrom_ActiveEditMouse(MouseEventArgs e)
        {
            Tool_pointx.Text = e.X.ToString();
            Tool_pointy.Text = e.Y.ToString();
        }
        /// <summary>
        /// 移动控件时在主窗体中体现
        /// </summary>
        void editfrom_ControlMouse(string editname, object sender, Point po)
        {
            Tool_editname.Text = editname;
            Tool_objectname.Text = ((sender) as Control).Tag.ToString();
            Tool_x.Text = ((sender) as Control).Location.X.ToString();
            Tool_y.Text = ((sender) as Control).Location.Y.ToString();
        }
        /// <summary>
        /// 编辑模板控件列表
        /// </summary>
        private void Controllist_Click(object sender, EventArgs e)
        {
            FrmEditControlList control = new FrmEditControlList(EditItem.SelectedItem.ToString());
            control.Dock = DockStyle.Fill;
            control.ProcessParChange += new EventHandler(control_ProcessParChange);
            control.Text = EditItem.SelectedItem.ToString() + "当前控件模板列表";
            P_controllist.Controls.Clear();
            P_controllist.Controls.Add(control);
        }
        //控件列表窗体应用模板属性时发生的事件
        void control_ProcessParChange(object sender, EventArgs e)
        {
            Tool_par.Visible = true;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100000; j++)
                {

                }
                Tool_par.Value = i;
            }
            Tool_par.Value = 0;
            Tool_par.Visible = false;

        }
        /// <summary>
        /// 左面板
        /// </summary>
        private void DockLeft()
        {
            //获取模板名称集合
            foreach (object i in EditTemplateInfo.ReturnEditItemName())
            {
                //实例化模板集合中的子列表对象
                FrmEditThempZoom editlistchild = new FrmEditThempZoom(EditTemplateInfo.GetEditImg((i as string)));
                editlistchild.Tag = (i as string);//存储当前子对象所对应的模板名称
                editlistchild.Dock = DockStyle.Top;
                P_themplist.Controls.Add(editlistchild);
            }            
        }
        /// <summary>
        /// 打印预览模板
        /// </summary>
        private void Tool_printview_Click(object sender, EventArgs e)
        {
            EditEventReferences.ActivePrintEditEvent();
        }
        //直接打印
        private void Tool_print_Click(object sender, EventArgs e)
        {
            EditEventReferences.ActivePrintDialogEvent();
        }
        //获取远程服务器中最新模板文件
        private void Tool_addedit_Click(object sender, EventArgs e)
        {

        }
        #region 工具栏事件
        /// <summary>
        /// 复制控件
        /// </summary>
        private void Tool_copycontrol_Click(object sender, EventArgs e)
        {
            EditMainToolEventReferences.ActionMainCopyControlEvent();//触发复制控件事件,让编辑模板拷贝控件
        }
        /// <summary>
        /// 粘贴控件
        /// </summary>
        private void Tool_zt_Click(object sender, EventArgs e)
        {
            EditMainToolEventReferences.ActionMainParsteControlEvent();//触发粘贴控件事件,让编辑模板粘贴控件
        }
        /// <summary>
        /// 剪切控件
        /// </summary>
        private void Tool_jq_Click(object sender, EventArgs e)
        {
            EditMainToolEventReferences.ActionMainCutControlEvent();//触发剪切控件事件,让编辑模板剪切控件
        }
        //放大
        private void Tool_fd_Click(object sender, EventArgs e)
        {
            EditMainToolEventReferences.ActionMainZoomMaxControlEvent();
        }
        //缩小
        private void Tool_sx_Click(object sender, EventArgs e)
        {
            EditMainToolEventReferences.ActionMainZoomMinControlEvent();

        }
        //还原
        private void Tool_clearzoom_Click(object sender, EventArgs e)
        {

        }
        #endregion
        //移除选项卡
        private void Tab_editlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Tab_editlist.SelectedIndex > 0)
            {
                Tab_editlist.TabPages.RemoveAt(Tab_editlist.SelectedIndex);
            }
        }

        private void Tab_editlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditEventReferences.ActiveFromEvent((Tab_editlist.Controls[Tab_editlist.SelectedIndex].Controls[0] as FrmEditFrm));
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
