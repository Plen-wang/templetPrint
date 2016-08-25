using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using System.Xml;

namespace PrintThempActiveX
{
    /// <summary>
    /// 该类中包含所有可编辑模板的信息集合
    /// 主要步骤:使用该类之前必须启动模板属性LoadEdit=true;
    /// </summary>
    public static class EditTemplateInfo
    {
        #region 字段
        /// <summary>
        /// 当前是否处于编辑模式下
        /// </summary>
        private static bool _EditBool = true;//启用模板ActiveX
        /// <summary>
        /// 是否是多套打印
        /// </summary>
        private static bool _IsMuch;
        /// <summary>
        /// 单套打印或多套打印的数据源
        /// </summary>
        private static object _EditDataSource;
        /// <summary>
        /// 待编辑项的模板底图集合
        /// </summary>
        private static Dictionary<string, string> bitmap = new Dictionary<string, string>();
        /// <summary>
        /// 模板编辑项的XML集合
        /// </summary>
        private static Dictionary<string, string> editxml = new Dictionary<string, string>();
        /// <summary>
        /// 待编辑项的名称集合
        /// </summary>
        private static System.Collections.ArrayList list = new ArrayList();
        #endregion

        #region 属性
        /// <summary>
        /// 启动编辑模板|静态类初始化用
        /// </summary>
        public static bool LoadEdit
        {
            set { _EditBool = value; }
            get { return _EditBool; }
        }
        /// <summary>
        /// 是否是多套打印
        /// </summary>
        public static bool IsMuch
        {
            set { _IsMuch = value; }
            get { return _IsMuch; }
        }
        /// <summary>
        /// 单套打印或多套打印的数据源
        /// </summary>
        public static object EditDataSource
        {
            get { return _EditDataSource; }
            set { _EditDataSource = value; }
        }
        #endregion
        /// <summary>
        /// 默认静态构造函数|加载应用程序路径下的可编辑模板；
        /// 注意:当前只支持BMP图片格式
        /// </summary>
        static EditTemplateInfo()
        {
            string appstarpath = @"C:\Program Files\Themplate";//模板路径
            string[] filepaths = Directory.GetFiles(appstarpath, "*.BMP");
            foreach (string file in filepaths)
            {
                bitmap.Add(file.Substring(file.LastIndexOf("\\") + 1), file);//添加模板名称及路径
                list.Add(file.Substring(file.LastIndexOf("\\") + 1));//添加模板名称集合
            } 
            filepaths = Directory.GetFiles(appstarpath, "*.XML");
            foreach (string xmlfile in filepaths)
            {
                editxml.Add(xmlfile.Substring(xmlfile.LastIndexOf("\\") + 1), xmlfile);//添加模板XML
            }
        }
        /// <summary>
        /// 获取编辑模板的底图
        /// </summary>
        /// <param name="deitname">待编辑项的名称</param>
        /// <returns>Bitmap</returns>
        public static Image GetEditImg(string editname)
        {
            if (editname.Length > 2)
            {
                return Image.FromFile(bitmap[editname]);
            }
            return null;
        }
        /// <summary>
        /// 获取编辑模板的XML
        /// </summary>
        /// <param name="editname">待编辑项的名称</param>
        /// <returns>XmlDocument</returns>
        public static XmlDocument GetEditXmlDocument(string editname)
        {
            if (editname.Length > 2)
            {
                XmlDocument document = new XmlDocument();
                document.Load(editxml[editname]);
                return document;
            }
            return null;
        }
        /// <summary>
        /// 返回可编辑模板名称的集合
        /// </summary>
        /// <returns>ArrayList</returns>
        public static ArrayList ReturnEditItemName()
        {
            return list;
        }
        /// <summary>
        /// 获取指定模板的完全路径名
        /// </summary>
        /// <param name="editname">模板名称</param>
        /// <returns>string(DirectoryPath)</returns>
        public static string GetEditXmlPathName(string editname)
        {
            return editxml[editname];
        }

    }
}
