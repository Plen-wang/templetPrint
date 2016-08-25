using System;
using System.Collections.Generic;
using System.Text;

namespace PrintThemp
{
    /// <summary>
    ///该类关联主窗体FrmEditMainPanel与编辑模板之间的工具按钮关系
    /// </summary>
    public static class EditMainToolEventReferences
    {
        #region 委托
        /// <summary>
        /// 该委托用来关联复制控件的工具按钮
        /// </summary>
        public delegate void MainCopyControlDelegate();
        /// <summary>
        /// 该委托用来关联粘贴控件的工具按钮
        /// </summary>
        public delegate void MainParsetControlDelegate();
        /// <summary>
        /// 该委托用来关联属性面板粘贴控件后的添加操作
        /// </summary>
        /// <param name="copycontrol">粘贴的控件</param>
        /// <param name="controltype">控件的类型</param>
        public delegate void MainParsetControlRFrmEditControlListDelegate(System.Windows.Forms.Control copycontrol,string controltype);
        /// <summary>
        /// 该委托用来关联剪切控件的工具按钮
        /// </summary>
        public delegate void MainCutControlDelegate();
        /// <summary>
        /// 回调委托|用来响应主窗体中的剪切按钮事件
        /// </summary>
        public delegate void MainCutControlCallBackDelegate();
        /// <summary>
        ///该委托用来关联放大控件
        /// </summary>
        public delegate void MainZoomMaxControl();
        /// <summary>
        /// 该委托用来关联缩小控件
        /// </summary>
        public delegate void MainZoomMinControl();
        #endregion

        #region 事件
        /// <summary>
        ///点击主窗体上的复制控件工具按钮
        /// </summary>
        public static event MainCopyControlDelegate MainCopyControlEvent;
        /// <summary>
        /// 点击主窗体上的粘贴控件工具按钮
        /// </summary>
        public static event MainParsetControlDelegate MainParsetControlEvent;
        /// <summary>
        ///点击主窗体上的粘贴控件工具按钮触发(只有属性面板订阅该事件)
        /// </summary>
        public static event MainParsetControlRFrmEditControlListDelegate MainParsetControlRFrmEditControlListEvent;
        /// <summary>
        /// 点击主窗体上的剪切按钮工具按钮触发(只有主窗体)
        /// </summary>
        public static event MainCutControlDelegate MainCutControlEvent;
        /// <summary>
        /// 回调事件|当剪切控件成功复制时发生
        /// </summary>
        public static event MainCutControlCallBackDelegate MainCutControlCallBackEvent;
        /// <summary>
        /// 点击主窗体上的放大控件工具按钮
        /// </summary>
        public static event MainZoomMaxControl MainZoomMaxControlEvent;
        /// <summary>
        /// 点击主窗体上的缩小控件工具按钮
        /// </summary>
        public static event MainZoomMinControl MainZoomMinControlEvent;
        #endregion

        #region 触发事件方法
        /// <summary>
        /// 触发"点击窗体上的复制控件工具按钮"
        /// </summary>
        public static void ActionMainCopyControlEvent()
        {
            MainCopyControlEvent();
        }
        /// <summary>
        /// 触发"点击窗体上的粘贴按钮工具按钮"
        /// </summary>
        public static void ActionMainParsteControlEvent()
        {
            MainParsetControlEvent();
        }
        /// <summary>
        /// 触发"点击窗体上的粘贴按钮工具按钮"|该事件只被控件属性窗体订阅
        /// </summary>
        /// <param name="copycontrol">待复制的控件</param>
        /// <param name="controltype">控件的类型</param>
        public static void ActionMainParsetControlRFrmEditControlListEvent(System.Windows.Forms.Control copycontrol,string controltype)
        {
            MainParsetControlRFrmEditControlListEvent(copycontrol,controltype);
        }
        /// <summary>
        /// 触发"点击主窗体上的剪切按钮工具按钮"|该事件只被主窗体订阅
        /// </summary>
        public static void ActionMainCutControlEvent()
        {
            MainCutControlEvent();
        }
        /// <summary>
        /// 触发主窗体的剪切按钮的回调事件|移除待剪切控件
        /// </summary>
        public static void ActionMainCutControlCallBackEvent()
        {
            MainCutControlCallBackEvent();
        }
        /// <summary>
        /// 触发主窗体的放大按钮事件
        /// </summary>
        public static void ActionMainZoomMaxControlEvent()
        {
            MainZoomMaxControlEvent();
        }
        /// <summary>
        /// 触发主窗体的缩小按钮事件
        /// </summary>
        public static void ActionMainZoomMinControlEvent()
        {
            MainZoomMinControlEvent();
        }
        #endregion
    }
}
