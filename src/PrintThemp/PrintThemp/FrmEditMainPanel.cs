using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
namespace PrintThemp
{
    /// <summary>
    /// 模板面板的主面板
    /// </summary>
    public partial class FrmEditMainPanel : Form
    {
        #region 窗体变量
        /// <summary>
        /// 每个可编辑模板都对应一个编辑模板实例对象
        /// </summary>
        FrmEditfrom editfrom;
        /// <summary>
        /// 控制非模式窗体的引用计数|当前只记录两个窗体
        /// </summary>
        Form[] FrmRefer = new Form[3];
        #endregion
        /// <summary>
        /// 默认构造函数|没有初始化任何对象
        /// </summary>
        public FrmEditMainPanel()
        {
            InitializeComponent();
            #region 验证用户是否开启模板开关|实用模板时必须开启模板开关加载全局模板数据
            if (!EditTemplateInfo.LoadEdit)
            {
                this.Close();
            }
            #endregion
            EditEventReferences.FacilityEditEvent += new EditEventReferences.FacilityEdit(EditEventReferences_FacilityEditEvent);
        }
        /// <summary>
        /// 其他菜单中编辑模板命令
        /// </summary>
        void EditEventReferences_FacilityEditEvent(string editname)
        {
            EditItem.SelectedIndex = EditItem.FindString(editname);
        }
        /// <summary>
        /// 窗体加载时|加载一些模板信息列表
        /// </summary>
        private void FrmPanel_Load(object sender, EventArgs e)
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
        /// 鹰眼
        /// </summary>
        private void minmap_Click(object sender, EventArgs e)
        {
            if (FrmRefer[0] == null)
            {
                FrmEagleLook look = new FrmEagleLook(EditItem.SelectedItem.ToString());
                look.FormClosing += new FormClosingEventHandler(look_FormClosing);
                look.Show();
                FrmRefer[0] = look;//增加引用计数
            }
            else
            {
                FrmRefer[0].Activate();
            }
        }
        /// <summary>
        /// 关闭非模式窗体事件|减少引用计数
        /// </summary>
        void look_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmRefer[0] = null;
        }
        /// <summary>
        /// 编辑模板
        /// </summary>
        private void EditItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            editfrom = new FrmEditfrom(EditItem.SelectedItem.ToString());
            editfrom.Text = EditItem.SelectedItem.ToString();
            editfrom.ControlMouse += new FrmEditfrom.ActiveMouse(editfrom_ControlMouse);
            editfrom.ActiveEditMouse += new FrmEditfrom.EditMouse(editfrom_ActiveEditMouse);
            editfrom.Show(DP_dock);
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
            if (FrmRefer[1] == null)
            {
                FrmEditControlList control = new FrmEditControlList(EditItem.SelectedItem.ToString());
                control.ProcessParChange += new EventHandler(control_ProcessParChange);
                control.FormClosing += new FormClosingEventHandler(control_FormClosing);
                control.Text = EditItem.SelectedItem.ToString() + "当前控件模板列表";
                control.Show(editfrom.DockPanel, DockState.DockBottomAutoHide);
                control.DockTo(DP_dock, DockStyle.Bottom);
                FrmRefer[1] = control;
            }
            else
            {
                FrmRefer[1].Activate();
            }
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
        /// 关闭非模式窗体事件|减少引用计数
        /// </summary>
        void control_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmRefer[1] = null;
        }
        /// <summary>
        /// 退出应用程序
        /// </summary>
        private void FrmPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            DP_dock.SaveAsXml(Application.StartupPath + "\\DockPanel.config");
            //保存状态
            Application.ExitThread();//退出所有消息链，并关闭当前线程中的所有窗口
        }
        /// <summary>
        /// 设置当前窗体对象获取焦点方便用户滚动模板
        /// </summary>
        private void DP_dock_Click(object sender, EventArgs e)
        {
            this.Focus();
        }
        /// <summary>
        /// 左面板
        /// </summary>
        private void DockLeft()
        {
            if (FrmRefer[2] == null)
            {
                FrmEditLeftList left = new FrmEditLeftList();
                left.FormClosed += new FormClosedEventHandler(left_FormClosed);
                left.Show(DP_dock, DockState.DockLeft);
                FrmRefer[2] = left;
            }
            else
            {
                FrmRefer[2].Activate();
            }
        }

        void left_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmRefer[2] = null;
        }

        private void Tool_lefteditlist_Click(object sender, EventArgs e)
        {
            DockLeft();
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
        //添加模板
        private void Tool_addedit_Click(object sender, EventArgs e)
        {
            new FrmEditAdd().ShowDialog();
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

    }
}
