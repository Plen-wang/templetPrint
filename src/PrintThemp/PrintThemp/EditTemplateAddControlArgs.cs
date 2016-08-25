using System;
using System.Collections.Generic;
using System.Text;

namespace PrintThemp
{
    /// <summary>
    /// 模板添加控件委托信息
    /// </summary>
    public class EditTemplateAddControlArgs
    {
        #region 变量
        /// <summary>
        /// TAB索引
        /// </summary>
        private string _TAB_INDEX;
        /// <summary>
        /// 中文名称
        /// </summary>
        private string _ITEM_CNAME;
        /// <summary>
        /// 英文名称
        /// </summary>
        private string _ITEM_ENAME;
        /// <summary>
        /// 宽度
        /// </summary>
        private int _ITEM_WIDTH;
        /// <summary>
        /// 高度
        /// </summary>
        private int _ITEM_HEIGHT;
        /// <summary>
        /// X坐标
        /// </summary>
        private int _POS_X;
        /// <summary>
        /// Y坐标
        /// </summary>
        private int _POS_Y;
        /// <summary>
        /// 是否多行
        /// </summary>
        private string _MULTILINE;
        /// <summary>
        /// 是否换行
        /// </summary>
        private string _WORD_WRAP;
        /// <summary>
        /// 控件类型
        /// </summary>
        private string _ITEM_TYPE;
        #endregion

        #region 属性
        /// <summary>
        /// 控件TAB索引
        /// </summary>
        public string TAB_INDEX
        {
            get { return _TAB_INDEX; }
            set { _TAB_INDEX = value; }
        }
        /// <summary>
        /// 控件中文名称
        /// </summary>
        public string ITEM_CNAME
        {
            get { return _ITEM_CNAME; }
            set { _ITEM_CNAME = value; }
        }
        /// <summary>
        /// 控件的英文名称
        /// </summary>
        public string ITEM_ENAME
        {
            get { return _ITEM_ENAME; }
            set { _ITEM_ENAME = value; }
        }
        /// <summary>
        /// 控件的宽度
        /// </summary>
        public int ITEM_WIDTH
        {
            get { return _ITEM_WIDTH; }
            set { _ITEM_WIDTH = value; }
        }
        /// <summary>
        /// 控件高度
        /// </summary>
        public int ITEM_HEIGHT
        {
            get { return _ITEM_HEIGHT; }
            set { _ITEM_HEIGHT = value; }
        }
        /// <summary>
        /// X坐标
        /// </summary>
        public int POS_X
        {
            get { return _POS_X; }
            set { _POS_X = value; }
        }
        /// <summary>
        /// Y坐标
        /// </summary>
        public int POS_Y
        {
            get { return _POS_Y; }
            set { _POS_Y = value; }
        }
        /// <summary>
        /// 是否多行
        /// </summary>
        public string MULTILINE
        {
            get { return _MULTILINE; }
            set { _MULTILINE = value; }
        }
        /// <summary>
        /// 是否换行
        /// </summary>
        public string WORD_WRAP
        {
            get { return _WORD_WRAP; }
            set { _WORD_WRAP = value; }
        }
        /// <summary>
        /// 控件类型
        /// </summary>
        public string ITEM_TYPE
        {
            get { return _ITEM_TYPE; }
            set { _ITEM_TYPE = value; }
        }
        #endregion
    }
}
