/*----------------------------------------------------------------
 * 作者：王清培
 * 时间：2010-10-24
 * 
 * ----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Text;

namespace PrintThempActiveX
{
    /// <summary>
    /// 该枚举表示所有能在模板中体现的控件类型|对应于托管C#类型
    /// </summary>
    public enum EditControlTypeInfo
    {
        /// <summary>
        /// TextBox(文本框)|只能输入常用文本
        /// </summary>
        TextBoxText,
        /// <summary>
        /// TextBox(文本框)|只能数据数值
        /// </summary>
        TextBoxNumber,
        /// <summary>
        /// DateTimePicker(时间类型)|只能输入时间格式包括格式化后的类型
        /// </summary>
        DateTimePicker,
        /// <summary>
        /// RichTextBox(富文本)|允许输入任何格式的文本包括特殊字符&*……&#
        /// </summary>
        RichTextBox,
        /// <summary>
        /// PictureBox(图片)|只能保存Image类型
        /// </summary>
        PictureBox,
        /// <summary>
        /// CheckBox(复选框)|提供状态的保存，如：一些多选项目
        /// </summary>
        CheckBox,
        /// <summary>
        ///TextBox(文本框)|长文本类型格式不限制长度
        /// </summary>
        TextBoxLong
    }
    /// <summary>
    /// 该类跟EditControlTypeInfo配套出现用于检索所有控件类型枚举
    /// </summary>
    public static class EditControlTypeInfoClass
    {
        private static List<EditControlTypeInfo> list = new List<EditControlTypeInfo>();
        public static IList<EditControlTypeInfo> GetEditControlTypeInfo()
        {
            if (list.Count <= 0)
            {

                list.Add(EditControlTypeInfo.CheckBox);
                list.Add(EditControlTypeInfo.DateTimePicker);
                list.Add(EditControlTypeInfo.PictureBox);
                list.Add(EditControlTypeInfo.RichTextBox);
                list.Add(EditControlTypeInfo.TextBoxLong);
                list.Add(EditControlTypeInfo.TextBoxNumber);
                list.Add(EditControlTypeInfo.TextBoxText);
                return list;
            }
            return list;
        }
    }
    /// <summary>
    /// 该枚举表示模板的状态|当前只有激活、新建两种状态
    /// </summary>
    public enum EditActiveTypeInfo
    {
        /// <summary>
        /// 新建模板窗体
        /// </summary>
        NewEditFrom,
        /// <summary>
        /// 激活模板窗体
        /// </summary>
        ActiveEditFrom
    }
    /// <summary>
    /// 该枚举表示模板中的控件类型为文本型|是否支持多行数据
    /// </summary>
    public enum EditControlIsOrMultiline
    {
        /// <summary>
        /// 允许多行文本
        /// </summary>
        TrueMultiline,
        /// <summary>
        /// 不允许多行文本
        /// </summary>
        FalseMultiline
    }
    /// <summary>
    /// 该枚举表示模板中的控件类型为文本型|是否支持换行数据
    /// </summary>
    public enum EditControlIsOrWrap
    {
        /// <summary>
        /// 允许换行文本
        /// </summary>
        TrueWrap,
        /// <summary>
        /// 不允许换行文本
        /// </summary>
        FalseWrap
    }

}
