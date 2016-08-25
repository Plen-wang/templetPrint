/*----------------------------------------------------------------
 * 作者：王清培
 * 时间：2010-6-27
 * 
 * 更新：
 * 时间：2010-7-3
 * 内容： 添加了左面板和编辑模板的事件
 * 
 * 更新：
 * 时间：2010-7-4
 * 内容：添加了模板打印委托和事件
 * 
 * 更新：
 * 时间：2010-7-10
 * 内容：添加了删除模板中的控件委托事件
 * ----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintThemp
{
    /// <summary>
    /// 静态类|用来关联"编辑模板"实例、"模板控件列表"实例、"鹰眼"实例三者之间的同步
    /// 也就是当编辑模板对象时对应的实例对象要及时更新DOM对象列表；
    /// </summary>
    public static class EditEventReferences
    {
        /// <summary>
        /// 默认静态构造函数|没有初始化任何对象
        /// </summary>
        static EditEventReferences()
        {
            //添加构造过程代码
        }
        #region 委托
        /// <summary>
        /// 该委托用来封装编辑模板实例的状态信息
        /// </summary>
        /// <param name="editfrom">FrmEditfrom(注:编辑模板实例)</param>
        /// <param name="activetype">EditActiveTypeInfo(注:编辑模板是新建还是激活)</param>
        public delegate void ActiveEditControlList(FrmEditfrom editfrom, EditActiveTypeInfo activetype);
        /// <summary>
        /// 该委托用来封装编辑模板所对应的鹰眼切换
        /// </summary>
        /// <param name="editfrom">FrmEditfrom(注:编辑模板实例)</param>
        public delegate void ActiveEditEagleLook(FrmEditfrom editfrom);
        /// <summary>
        /// 该委托用来封装模板控件列表应用了新的控件属性后的模板名称
        /// </summary>
        /// <param name="editname">(如:001.bmp)</param>
        public delegate void ApplyEditProperty(string editname);
        /// <summary>
        /// 该委托用来封装移动模板中的控件时的坐标信息
        /// </summary>
        /// <param name="controlename">移动的控件名称|英文名称</param>
        /// <param name="pointx">X</param>
        /// <param name="pointy">Y</param>
        public delegate void MouseControlPoint(string controlename, int pointx, int pointy);
        /// <summary>
        /// 该委托封装了其他菜单中的编辑
        /// </summary>
        /// <param name="editname"></param>
        public delegate void FacilityEdit(string editname);
        /// <summary>
        /// 该委托封装了打印过程控制
        /// </summary>
        /// <param name="args"></param>
        public delegate void PrintEdit(EditPrintEventArgs args);
        /// <summary>
        /// 直接打印|设置打印属性
        /// </summary>
        public delegate void PrintDialog(EditPrintEventArgs args);
        /// <summary>
        /// 该委托封装了模板中添加控件的信息
        /// </summary>
        /// <param name="args"></param>
        public delegate void EditAddControl(EditTemplateAddControlArgs args);
        /// <summary>
        /// 该委托封装了模板中移除控件的信息
        /// </summary>
        /// <param name="cname">待移除控件的英文名称</param>
        public delegate void EditRemoveControl(string ename);
        #endregion

        #region 事件
        /// <summary>
        /// 模板实例激活或新建事件
        /// </summary>
        public static event ActiveEditControlList ActiveFrom;
        /// <summary>
        /// 鹰眼实例所对应的模板实例类型
        /// </summary>
        public static event ActiveEditEagleLook ActiveEagLookFrom;
        /// <summary>
        /// 属性列表应用了新的属性后的发生
        /// </summary>
        public static event ApplyEditProperty ApplyEditPropertyFrom;
        /// <summary>
        /// 移动模板中的控件时发生
        /// </summary>
        public static event MouseControlPoint MouseControlEvent;
        /// <summary>
        /// 菜单中的编辑模板命令
        /// </summary>
        public static event FacilityEdit FacilityEditEvent;
        /// <summary>
        /// 开始打印传递
        /// </summary>
        public static event PrintEdit PrintEditEvent;
        /// <summary>
        /// 直接打印
        /// </summary>
        public static event PrintDialog PrintDialogEvent;
        /// <summary>
        /// 添加控件
        /// </summary>
        public static event EditAddControl EditAddControlEvent;
        /// <summary>
        /// 移除控件
        /// </summary>
        public static event EditRemoveControl EditRemoveControlEvent;
        #endregion

        #region 触发方法
        /// <summary>
        /// 启动模板窗体激活、新建事件
        /// </summary>
        /// <param name="editfrom">FrmEditfrom(注:待激活、新建的模板窗体实例)</param>
        public static void ActiveFromEvent(FrmEditfrom editfrom)
        {
            try
            {
                //触发模板激活、新建事件
                ActiveFrom(editfrom, EditActiveTypeInfo.ActiveEditFrom);
            }
            catch { }
        }
        /// <summary>
        /// 启动鹰眼窗体切换事件
        /// </summary>
        /// <param name="editfrom">FrmEditfrom(注:鹰眼窗体切换的模板窗体实例)</param>
        public static void ActiveEalLookFromEvent(FrmEditfrom editfrom)
        {
            //触发鹰眼窗体切换事件(注:切换鹰眼的底图或鹰眼的角度)
            ActiveEagLookFrom(editfrom);
        }
        /// <summary>
        /// 启动控件应用新的属性事件
        /// </summary>
        /// <param name="editname">应用的控件列表所对应的模板名称(如:001.bmp)</param>
        public static void ApplyEditPropertyFromEvent(string editname)
        {
            ApplyEditPropertyFrom(editname);
        }
        /// <summary>
        /// 启动移动模板中的控件事件
        /// </summary>
        /// <param name="controlename">移动的控件英文名称</param>
        /// <param name="pointx">控件的X坐标</param>
        /// <param name="pointy">控件的Y坐标</param>
        public static void ActiveMouseControlEvent(string controlename,int pointx,int pointy)
        {
            MouseControlEvent(controlename, pointx, pointy);
        }
        /// <summary>
        /// 触发菜单中的编辑模板命令
        /// </summary>
        /// <param name="editname">模板名称</param>
        public static void ActiveFacilityEditEvent(string editname)
        {
            FacilityEditEvent(editname);
        }
        /// <summary>
        /// 触发打印过程
        /// </summary>
        public static void ActivePrintEditEvent()
        {
            EditPrintEventArgs printage = new EditPrintEventArgs();//传递实体
            PrintEditEvent(printage);//触发模板打印过程,收集所有模板的打印数据
            //收集完毕开始打印
            EditTemplatePrint.PrintView(printage.editbitmap, printage.editcontrol);//开始打印

        }
        /// <summary>
        ///直接打印
        /// </summary>
        public static void ActivePrintDialogEvent()
        {
            EditPrintEventArgs printage = new EditPrintEventArgs();
            PrintDialogEvent(printage);
            EditTemplatePrint.PrintDialogSetting(printage.editbitmap, printage.editcontrol);//直接打印
        }
        /// <summary>
        /// 触发添加控件事件
        /// </summary>
        /// <param name="args">控件信息</param>
        public static void ActiveEditAddControlEvent(EditTemplateAddControlArgs args)
        {
            EditAddControlEvent(args);
        }
        /// <summary>
        /// 触发移除控件事件
        /// </summary>
        /// <param name="cname">控件的英文名</param>
        public static void ActiveEditRemoveControlEvent(string cname)
        {
            EditRemoveControlEvent(cname);
        }
        #endregion

    }
}
