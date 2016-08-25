using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace PrintThempActiveX
{
    public partial class FrmEditControlList : UserControl
    {
        #region 窗体变量及默认构造函数
        /// <summary>
        /// 模板名称|已模板的文件名为名称
        /// </summary>
        private string EditName = string.Empty;
        /// <summary>
        /// 模板中的控件列表数据集
        /// </summary>
        private DataTable EditControlTB = null;
        /// <summary>
        /// 应用模板属性时发生
        /// </summary>
        public event EventHandler ProcessParChange;
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public FrmEditControlList()
        {
            InitializeComponent();
            //启用应用程序样式
            Application.EnableVisualStyles();
        }
        #endregion
        /// <summary>
        /// 重载构造函数|构造模板控件列表
        /// </summary>
        /// <param name="editname">模板名称(如:001.bmp)</param>
        public FrmEditControlList(string editname)
        {
            InitializeComponent();
            EditName = editname;
            InitFontStyle();
            #region 订阅相关事件|激活编辑模板实例|移动控件|添加控件|移除控件|拷贝控件....
            EditEventReferences.ActiveFrom += new EditEventReferences.ActiveEditControlList(EditEventReferences_ActiveFrom);
            EditEventReferences.MouseControlEvent += new EditEventReferences.MouseControlPoint(EditEventReferences_MouseControlEvent);
            EditEventReferences.EditAddControlEvent += new EditEventReferences.EditAddControl(EditEventReferences_EditAddControlEvent);
            EditEventReferences.EditRemoveControlEvent += new EditEventReferences.EditRemoveControl(EditEventReferences_EditRemoveControlEvent);
            EditMainToolEventReferences.MainParsetControlRFrmEditControlListEvent += new EditMainToolEventReferences.MainParsetControlRFrmEditControlListDelegate(EditMainToolEventReferences_MainParsetControlRFrmEditControlListEvent);
            #endregion
        }
        /// <summary>
        /// 复制控件时发生
        /// </summary>
        /// <param name="copycontrol">待添加的控件</param>
        void EditMainToolEventReferences_MainParsetControlRFrmEditControlListEvent(Control copycontrol, string controltype)
        {
            #region 控件信息类
            EditTemplateAddControlArgs addcontrol = new EditTemplateAddControlArgs();
            addcontrol.TAB_INDEX = copycontrol.TabIndex.ToString();
            addcontrol.ITEM_CNAME = copycontrol.Tag.ToString();
            addcontrol.ITEM_ENAME = copycontrol.Name;
            addcontrol.ITEM_WIDTH = copycontrol.Width;
            addcontrol.ITEM_HEIGHT = copycontrol.Height;
            addcontrol.POS_X = copycontrol.Location.X;
            addcontrol.POS_Y = copycontrol.Location.Y;
            if (copycontrol.GetType().ToString() == "System.Windows.Forms.RichTextBox")
            {
                addcontrol.MULTILINE = (copycontrol as RichTextBox).Multiline == true ? "是" : "否";
                addcontrol.WORD_WRAP = (copycontrol as RichTextBox).WordWrap == true ? "是" : "否";
                addcontrol.ITEM_TYPE = "RichTextBox";
            }
            else if (copycontrol.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                addcontrol.MULTILINE = (copycontrol as TextBox).Multiline == true ? "是" : "否";
                addcontrol.WORD_WRAP = (copycontrol as TextBox).WordWrap == true ? "是" : "否";
                addcontrol.ITEM_TYPE = "TextBoxText";
            }
            else if (copycontrol.GetType().ToString() == "System.Windows.Forms.PictureBox")
            {
                addcontrol.MULTILINE = (copycontrol as TextBox).Multiline == true ? "是" : "否";
                addcontrol.WORD_WRAP = (copycontrol as TextBox).WordWrap == true ? "是" : "否";
                addcontrol.ITEM_TYPE = "PictureBox";
            }
            #endregion
            EditEventReferences_EditAddControlEvent(addcontrol);

        }
        /// <summary>
        /// 移除控件时
        /// </summary>
        /// <param name="cname">待移除控件的英文名</param>
        void EditEventReferences_EditRemoveControlEvent(string ename)
        {
            foreach (DataGridViewRow row in DGV_CustomControlList.Rows)
            {
                if (row.Cells["ename"].Value.ToString() == ename)
                {
                    DGV_CustomControlList.Rows.RemoveAt(row.Index);
                }
            }
            Bt_enter_Click(null, null);
        }
        /// <summary>
        /// 添加控件时
        /// </summary>
        /// <param name="args">添加控件的信息</param>
        void EditEventReferences_EditAddControlEvent(EditTemplateAddControlArgs args)
        {
            //DataGridView在数据绑定下无法添加行|从数据源添加
            DataTable addtb = LoadCustomControlList(EditName);
            DataRow row = addtb.NewRow();
            row["TAB_INDEX"] = args.TAB_INDEX;
            row["ITEM_CNAME"] = args.ITEM_CNAME;
            row["ITEM_ENAME"] = args.ITEM_ENAME;
            row["ITEM_WIDTH"] = args.ITEM_WIDTH;
            row["ITEM_HEIGHT"] = args.ITEM_HEIGHT;
            row["POS_X"] = args.POS_X;
            row["POS_Y"] = args.POS_Y;
            row["MULTILINE"] = args.MULTILINE;
            row["WORD_WRAP"] = args.WORD_WRAP;
            row["ITEM_TYPE"] = args.ITEM_TYPE;
            addtb.Rows.Add(row);
            Bt_enter_Click(null, null);
            DGV_CustomControlList.DataSource = LoadCustomControlList(EditName);

        }
        /// <summary>
        /// 模板控件移动时
        /// </summary>
        /// <param name="controlename">移动的控件英文名称</param>
        /// <param name="pointx">X</param>
        /// <param name="pointy">Y</param>
        void EditEventReferences_MouseControlEvent(string controlename, int pointx, int pointy)
        {
            foreach (DataGridViewRow row in DGV_CustomControlList.Rows)
            {
                if (row.Cells["ename"].Value.ToString() == controlename)
                {
                    row.Cells["pointx"].Value = pointx;
                    row.Cells["pointy"].Value = pointy;
                }
            }
        }
        /// <summary>
        /// 模板对象激活或新建|属性列表对象更换控件源
        /// </summary>
        /// <param name="editfrom">编辑模板实例</param>
        /// <param name="activetype"></param>
        void EditEventReferences_ActiveFrom(FrmEditFrm editfrom, EditActiveTypeInfo activetype)
        {
            EditName = editfrom.Text;//更换列表数据源
            this.Text = EditName;
            FrmEditControlList_Load(null, null);
        }
        /// <summary>
        /// 窗体加载时|初始化当前编辑模板的控件列表
        /// </summary>
        private void FrmEditControlList_Load(object sender, EventArgs e)
        {
            //加载控件列表选项菜单
            foreach (EditControlTypeInfo i in EditControlTypeInfoClass.GetEditControlTypeInfo())
            {
                Cms_controltype.Items.Add(i.ToString());
            }
            //加载控件列表
            LoadCustomControlList(EditName);
        }
        /// <summary>
        /// 根据模板名称加载模板控件列表
        /// </summary>
        /// <param name="editname">模板名称</param>
        private DataTable LoadCustomControlList(string editname)
        {
            if (editname != string.Empty)
            {
                XmlDocument document = EditTemplateInfo.GetEditXmlDocument(EditName.Substring(0, EditName.IndexOf(".")) + ".xml");//获取编辑模板XML
                XmlElement parent = document.DocumentElement;
                //模板中文说明|也就是模板所代表的纸面意思
                Lb_cname.Text = parent.ChildNodes[2].InnerText;
                //遍历所有的控件项节点|并添加到数据集中
                DataTable controltb = GetControlDB(EditName);
                foreach (XmlElement item in parent.ChildNodes[4])
                {
                    DataRow controlrow = controltb.NewRow();
                    controlrow["TAB_INDEX"] = EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("TAB_INDEX"));
                    controlrow["ITEM_CNAME"] = EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("ITEM_CNAME"));
                    controlrow["ITEM_ENAME"] = EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("ITEM_ENAME"));
                    controlrow["ITEM_WIDTH"] = EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("ITEM_WIDTH"));
                    controlrow["ITEM_HEIGHT"] = EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("ITEM_HEIGHT"));
                    controlrow["POS_X"] = EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("POS_X"));
                    controlrow["POS_Y"] = EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("POS_Y"));
                    controlrow["MULTILINE"] = EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("MULTILINE")) == "1" ? "是" : "否";
                    controlrow["WORD_WRAP"] = EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("WORD_WRAP")) == "1" ? "是" : "否";
                    controlrow["ITEM_TYPE"] = EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("ITEM_TYPE"));
                    controltb.Rows.Add(controlrow);
                }
                Lb_controlcount.Text = controltb.Rows.Count.ToString();//控件总数
                DGV_CustomControlList.DataSource = controltb;
                return controltb;
            }
            return null;
        }
        /// <summary>
        /// 生成控件类表数据集
        /// </summary>
        /// <param name="editname">模板名称</param>
        private DataTable GetControlDB(string editname)
        {
            EditControlTB = new DataTable(editname);
            EditControlTB.Columns.Add("TAB_INDEX", typeof(int));
            EditControlTB.Columns.Add("ITEM_CNAME", typeof(string));
            EditControlTB.Columns.Add("ITEM_ENAME", typeof(string));
            EditControlTB.Columns.Add("ITEM_WIDTH", typeof(int));
            EditControlTB.Columns.Add("ITEM_HEIGHT", typeof(int));
            EditControlTB.Columns.Add("POS_X", typeof(int));
            EditControlTB.Columns.Add("POS_Y", typeof(int));
            EditControlTB.Columns.Add("MULTILINE", typeof(string));
            EditControlTB.Columns.Add("WORD_WRAP", typeof(string));
            EditControlTB.Columns.Add("ITEM_TYPE", typeof(string));
            return EditControlTB;
        }
        /// <summary>
        /// 应用模板属性时
        /// </summary>
        private void Bt_enter_Click(object sender, EventArgs e)
        {
            //保存模板属性
            SaveEditProperty();
            //刷新编辑面板
            EditEventReferences.ApplyEditPropertyFromEvent(EditName);
            //模板属性变化事件
            ProcessParChange(null, null);
        }
        /// <summary>
        /// 保存模板属性
        /// </summary>
        private void SaveEditProperty()
        {
            try
            {
                XmlDocument document = new XmlDocument();
                XmlDeclaration decl = document.CreateXmlDeclaration("1.0", "UTF-8", null);//XML申明
                document.AppendChild(decl);
                XmlElement Custom_Root = document.CreateElement("Custom_Root");//根节点
                //保存全局节点信息
                SaveGlobalXmlNode(document, Custom_Root);
                //保存项节点信息
                SaveItemXmlNode(document, Custom_Root);
                document.AppendChild(Custom_Root);
                document.Save(EditTemplateInfo.GetEditXmlPathName(EditName.Substring(0, EditName.IndexOf(".")) + ".xml"));
            }
            catch (Exception err) { }
        }
        /// <summary>
        /// 保存模板中的全局节点
        /// </summary>
        /// <param name="document">XmlDocument</param>
        /// <param name="root">根节点</param>
        private void SaveGlobalXmlNode(XmlDocument document, XmlElement root)
        {
            //模板代码
            EditTemplateMethod.AppendChildElement(document, root, "CODE", EditTemplateInfo.GetEditXmlDocument((EditName.Substring(0, EditName.IndexOf(".")) + ".xml")).DocumentElement.ChildNodes[0].InnerText);
            //模板底图
            EditTemplateMethod.AppendChildElement(document, root, "BACK_IMG", EditTemplateInfo.GetEditXmlDocument((EditName.Substring(0, EditName.IndexOf(".")) + ".xml")).DocumentElement.ChildNodes[1].InnerText);
            //模板中文名称
            EditTemplateMethod.AppendChildElement(document, root, "CNAME", EditTemplateInfo.GetEditXmlDocument((EditName.Substring(0, EditName.IndexOf(".")) + ".xml")).DocumentElement.ChildNodes[2].InnerText);
            //模板英文名称
            EditTemplateMethod.AppendChildElement(document, root, "ENAME", EditTemplateInfo.GetEditXmlDocument((EditName.Substring(0, EditName.IndexOf(".")) + ".xml")).DocumentElement.ChildNodes[3].InnerText);
        }
        /// <summary>
        /// 保存模板中的项节点
        /// </summary>
        /// <param name="document">XmlDocument</param>
        /// <param name="root">根节点</param>
        private void SaveItemXmlNode(XmlDocument document, XmlElement root)
        {
            try
            {

                XmlElement items = EditTemplateMethod.AppendChildElement(document, root, "ITEMS", null);
                foreach (DataGridViewRow row in DGV_CustomControlList.Rows)
                {
                    XmlElement item = EditTemplateMethod.AppendChildElement(document, items, "ITEM", null);
                    //TAB索引,如果索引在转换成数值时没有错误说明是正确的|否则错误
                    Convert.ToInt32(row.Cells["tbindex"].Value.ToString());
                    EditTemplateMethod.AppendChildElement(document, item, "TAB_INDEX", row.Cells["tbindex"].Value.ToString());
                    //节点中文名称
                    EditTemplateMethod.AppendChildElement(document, item, "ITEM_CNAME", row.Cells["cname"].Value.ToString());
                    //节点英文名称
                    EditTemplateMethod.AppendChildElement(document, item, "ITEM_ENAME", row.Cells["ename"].Value.ToString());
                    //控件的宽度
                    Convert.ToInt32(row.Cells["width"].Value.ToString());
                    EditTemplateMethod.AppendChildElement(document, item, "ITEM_WIDTH", row.Cells["width"].Value.ToString());
                    //控件的高度
                    Convert.ToInt32(row.Cells["height"].Value.ToString());
                    EditTemplateMethod.AppendChildElement(document, item, "ITEM_HEIGHT", row.Cells["height"].Value.ToString());
                    //X坐标
                    Convert.ToInt32(row.Cells["pointx"].Value.ToString());
                    EditTemplateMethod.AppendChildElement(document, item, "POS_X", row.Cells["pointx"].Value.ToString());
                    //Y坐标
                    Convert.ToInt32(row.Cells["pointy"].Value.ToString());
                    EditTemplateMethod.AppendChildElement(document, item, "POS_Y", row.Cells["pointy"].Value.ToString());
                    //是否多行文本
                    int muiline = row.Cells["ismuiline"].Value.ToString() == "是" ? 1 : 0;
                    EditTemplateMethod.AppendChildElement(document, item, "MULTILINE", muiline.ToString());
                    //是否换行
                    int warp = row.Cells["iswarp"].Value.ToString() == "是" ? 1 : 0;
                    EditTemplateMethod.AppendChildElement(document, item, "WORD_WRAP", warp.ToString());
                    //控件类型
                    EditTemplateMethod.AppendChildElement(document, item, "ITEM_TYPE", row.Cells["controltype"].Value.ToString());
                }
            }
            catch { MessageBox.Show("属性列表中有错误的数值", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        /// <summary>
        /// 处理DataGridView的错误事件
        /// </summary>
        private void DGV_CustomControlList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        /// <summary>
        /// 控件的类型选择
        /// </summary>
        private void Cms_controltype_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DGV_CustomControlList.SelectedRows[0].Cells["controltype"].Value = e.ClickedItem.Text;
        }
        /// <summary>
        /// 是否换行
        /// </summary>
        private void Cms_wrap_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DGV_CustomControlList.SelectedRows[0].Cells["iswarp"].Value = e.ClickedItem.Text;
        }
        /// <summary>
        /// 是否多行
        /// </summary>
        private void Cms_multline_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DGV_CustomControlList.SelectedRows[0].Cells["ismuiline"].Value = e.ClickedItem.Text;
        }
        /// <summary>
        /// F5执行应用
        /// </summary>
        private void FrmEditControlList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F5)
            {
                Bt_enter_Click(null, null);
            }
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
