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
    public partial class FrmEditFrm : UserControl
    {

        #region 窗体变量及默认构造函数
        /// <summary>
        /// 编辑模板的名称|同时也是模板对应的XML名称,用来生成DOM模型
        /// </summary>
        public string Editname;
        /// <summary>
        /// 模板的英文名称
        /// </summary>
        private string EditEname;
        /// <summary>
        /// 用来控制移动控件|状态
        /// </summary>
        private bool IsMouse = false;
        /// <summary>
        /// 记录控件的坐标
        /// </summary>
        private Point MovePoint;
        /// <summary>
        /// 包装移动控件时的坐标
        /// </summary>
        /// <param name="editname">编辑模板名称</param>
        /// <param name="sender">移动的控件</param>
        /// <param name="po">坐标</param>
        public delegate void ActiveMouse(string editname, object sender, Point po);
        /// <summary>
        /// 移动控件时发生
        /// </summary>
        public event ActiveMouse ControlMouse;
        /// <summary>
        ///包装鼠标在模板中移动时的坐标
        /// </summary>
        /// <param name="e">坐标信息</param>
        public delegate void EditMouse(MouseEventArgs e);
        /// <summary>
        /// 鼠标在模板中的容器中移动时发生
        /// </summary>
        public event EditMouse ActiveEditMouse;
        /// <summary>
        /// 控制是否拖动主面板
        /// </summary>
        private bool IsMoveParent = false;
        /// <summary>
        /// 移动位置
        /// </summary>
        private Point ParentMovePoint;
        /// <summary>
        /// 保存粘贴控件
        /// </summary>
        public static Control ParsetControl;
        /// <summary>
        /// 默认构造函数
        /// </summary>
        public FrmEditFrm()
        {
            InitializeComponent();
        }
        #endregion
        /// <summary>
        /// 重载构造函数|当前实例适用于编辑那个模板
        /// </summary>
        /// <param name="editname">待编辑模板的名称</param>
        public FrmEditFrm(string editname)
        {
            InitializeComponent();
            this.Editname = editname;
            InitFontStyle();
            #region 订阅相关事件|属性面板|鹰眼|主窗体FrmEditMainPanel中的工具栏事件
            EditEventReferences.ApplyEditPropertyFrom += new EditEventReferences.ApplyEditProperty(EditEventReferences_ApplyEditPropertyFrom);
            EditEventReferences.PrintEditEvent += new EditEventReferences.PrintEdit(EditEventReferences_PrintEditEvent);
            EditEventReferences.PrintDialogEvent += new EditEventReferences.PrintDialog(EditEventReferences_PrintDialogEvent);
            EditMainToolEventReferences.MainCopyControlEvent += new EditMainToolEventReferences.MainCopyControlDelegate(EditMainToolEventReferences_MainCopyControlEvent);
            EditMainToolEventReferences.MainParsetControlEvent += new EditMainToolEventReferences.MainParsetControlDelegate(EditMainToolEventReferences_MainPasteControlEvent);
            EditMainToolEventReferences.MainCutControlEvent += new EditMainToolEventReferences.MainCutControlDelegate(EditMainToolEventReferences_MainCutControlEvent);
            EditMainToolEventReferences.MainCutControlCallBackEvent += new EditMainToolEventReferences.MainCutControlCallBackDelegate(EditMainToolEventReferences_MainCutControlCallBackEvent);
            EditMainToolEventReferences.MainZoomMaxControlEvent += new EditMainToolEventReferences.MainZoomMaxControl(EditMainToolEventReferences_MainZoomMaxControlEvent);
            EditMainToolEventReferences.MainZoomMinControlEvent += new EditMainToolEventReferences.MainZoomMinControl(EditMainToolEventReferences_MainZoomMinControlEvent);
            #endregion
        }
        void EditMainToolEventReferences_MainZoomMinControlEvent()
        {
            this.Scale(new SizeF(0.9f, 0.9f));
            Bitmap bgimg = new Bitmap((Bitmap)this.P_bgimg.BackgroundImage, new Size(this.P_bgimg.Width, this.P_bgimg.Height));
            //this.P_bgimg.BackgroundImage = EditTemplateMethod.ResizeImage((Bitmap)this.P_bgimg.BackgroundImage, this.P_bgimg.BackgroundImage.Width, this.P_bgimg.BackgroundImage.Height);
            this.P_bgimg.BackgroundImage = bgimg;
        }
        /// <summary>
        /// 放大编辑模板
        /// </summary>
        void EditMainToolEventReferences_MainZoomMaxControlEvent()
        {
            this.Scale(new SizeF(1.11f, 1.11f));
            Bitmap bgimg = new Bitmap((Bitmap)this.P_bgimg.BackgroundImage, new Size(this.P_bgimg.Width, this.P_bgimg.Height));
            //this.P_bgimg.BackgroundImage = EditTemplateMethod.ResizeImage((Bitmap)this.P_bgimg.BackgroundImage, this.P_bgimg.BackgroundImage.Width, this.P_bgimg.BackgroundImage.Height);
            this.P_bgimg.BackgroundImage = bgimg;
        }
        /// <summary>
        /// 编辑模板成功将剪切的控件粘贴时发生|回调事件
        /// </summary>
        void EditMainToolEventReferences_MainCutControlCallBackEvent()
        {
            //
        }
        /// <summary>
        /// 剪切控件
        /// </summary>
        void EditMainToolEventReferences_MainCutControlEvent()
        {
            //
        }
        #region 主面板工具栏中的按钮事件
        /// <summary>
        /// 粘贴控件时发生
        /// </summary>
        void EditMainToolEventReferences_MainPasteControlEvent()
        {
            foreach (Control child in this.P_bgimg.Controls)
            {
                if (child.Focused)
                {
                    if (ParsetControl != null)
                    {
                        //控件公有属性
                        Control newcontrol = System.Activator.CreateInstance((ParsetControl.GetType()), true) as Control;
                        newcontrol.Text = ParsetControl.Text;
                        newcontrol.Name = ParsetControl.Name;
                        newcontrol.Tag = ParsetControl.Tag;
                        newcontrol.Size = ParsetControl.Size;
                        //私有属性
                        if (ParsetControl.GetType().ToString() == "System.Windows.Forms.RichTextBox")
                        {
                            ((newcontrol) as RichTextBox).Multiline = ((ParsetControl) as RichTextBox).Multiline;
                            ((newcontrol) as RichTextBox).BorderStyle = ((ParsetControl) as RichTextBox).BorderStyle;
                            ((newcontrol) as RichTextBox).BackColor = Color.White;
                            ((newcontrol) as RichTextBox).WordWrap = true;
                            ((newcontrol) as RichTextBox).DetectUrls = ((ParsetControl) as RichTextBox).DetectUrls;
                            ((newcontrol) as RichTextBox).ScrollBars = ((ParsetControl) as RichTextBox).ScrollBars;
                            ((newcontrol) as RichTextBox).MaxLength = 200;
                            ((newcontrol) as RichTextBox).TabIndex = ((child) as RichTextBox).TabIndex;
                        }
                        else if (ParsetControl.GetType().ToString() == "System.Windows.Forms.TextBox")
                        {
                            ((newcontrol) as TextBox).Multiline = ((ParsetControl) as TextBox).Multiline;
                            ((newcontrol) as TextBox).BackColor = Color.White;
                            ((newcontrol) as TextBox).BorderStyle = ((ParsetControl) as TextBox).BorderStyle;
                            ((newcontrol) as TextBox).WordWrap = true;
                            ((newcontrol) as TextBox).ScrollBars = ((ParsetControl) as TextBox).ScrollBars;
                            ((newcontrol) as TextBox).MaxLength = 200;
                            ((newcontrol) as TextBox).TabIndex = ((ParsetControl) as TextBox).TabIndex;
                        }
                        else if (ParsetControl.GetType().ToString() == "System.Windows.Forms.PictureBox")
                        {
                            ((newcontrol) as PictureBox).BackColor = Color.White;
                            ((newcontrol) as PictureBox).BackgroundImageLayout = ImageLayout.Stretch;
                            ((newcontrol) as PictureBox).BorderStyle = ((ParsetControl) as PictureBox).BorderStyle;
                            ((newcontrol) as PictureBox).SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        newcontrol.ContextMenuStrip = CMS_CustomMenu;//设置控件的快捷菜单
                        newcontrol.MouseDown += new MouseEventHandler(CustomControl_MouseDown);
                        newcontrol.MouseMove += new MouseEventHandler(CustomControl_MouseMove);
                        newcontrol.MouseUp += new MouseEventHandler(CustomControl_MouseUp);
                        newcontrol.Move += new EventHandler(CustomControl_Move);
                        newcontrol.MouseEnter += new EventHandler(CustomControl_MouseEnter);
                        newcontrol.MouseLeave += new EventHandler(CustomControl_MouseLeave);
                        P_bgimg.Controls.Add(newcontrol);
                        //触发控件列表窗体
                        EditMainToolEventReferences.ActionMainParsetControlRFrmEditControlListEvent(newcontrol, newcontrol.GetType().ToString());
                        break;
                    }
                }
            }
        }
        /// <summary>
        /// 复制控件时发生
        /// </summary>
        void EditMainToolEventReferences_MainCopyControlEvent()
        {
            foreach (Control child in this.P_bgimg.Controls)
            {
                if (child.Focused == true)
                {
                    try
                    {
                        //控件公有属性
                        Control newcontrol = System.Activator.CreateInstance((child.GetType()), true) as Control;
                        newcontrol.Text = child.Text;
                        newcontrol.Name = child.Name;
                        newcontrol.Tag = child.Tag;
                        newcontrol.Size = child.Size;
                        //私有属性
                        if (child.GetType().ToString() == "System.Windows.Forms.RichTextBox")
                        {
                            ((newcontrol) as RichTextBox).Multiline = ((child) as RichTextBox).Multiline;
                            ((newcontrol) as RichTextBox).BorderStyle = ((child) as RichTextBox).BorderStyle;
                            ((newcontrol) as RichTextBox).BackColor = Color.White;
                            ((newcontrol) as RichTextBox).WordWrap = true;
                            ((newcontrol) as RichTextBox).DetectUrls = ((child) as RichTextBox).DetectUrls;
                            ((newcontrol) as RichTextBox).ScrollBars = ((child) as RichTextBox).ScrollBars;
                            ((newcontrol) as RichTextBox).MaxLength = 200;
                            ((newcontrol) as RichTextBox).TabIndex = ((child) as RichTextBox).TabIndex;
                        }
                        else if (child.GetType().ToString() == "System.Windows.Forms.TextBox")
                        {
                            ((newcontrol) as TextBox).Multiline = ((child) as TextBox).Multiline;
                            ((newcontrol) as TextBox).BackColor = Color.White;
                            ((newcontrol) as TextBox).BorderStyle = ((child) as TextBox).BorderStyle;
                            ((newcontrol) as TextBox).WordWrap = true;
                            ((newcontrol) as TextBox).ScrollBars = ((child) as TextBox).ScrollBars;
                            ((newcontrol) as TextBox).MaxLength = 200;
                            ((newcontrol) as TextBox).TabIndex = ((child) as TextBox).TabIndex;
                        }
                        else if (child.GetType().ToString() == "System.Windows.Forms.PictureBox")
                        {
                            ((newcontrol) as PictureBox).BackColor = Color.White;
                            ((newcontrol) as PictureBox).BackgroundImageLayout = ImageLayout.Stretch;
                            ((newcontrol) as PictureBox).BorderStyle = ((child) as PictureBox).BorderStyle;
                            ((newcontrol) as PictureBox).SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        ParsetControl = newcontrol;
                        break;
                    }
                    catch (Exception err) { }
                }
            }
        }
        #endregion
        /// <summary>
        /// 打印预览模板主窗体传过来的命令
        /// </summary>
        /// <param name="args"></param>
        void EditEventReferences_PrintEditEvent(EditPrintEventArgs args)
        {
            args.editbitmap.Add((P_bgimg.BackgroundImage as Bitmap));//添加图片到集合
            List<Control> list = new List<Control>();//控件集合
            foreach (Control child in P_bgimg.Controls)
            {
                if (child is ComboBox)
                {
                    //ComboBox不参加打印
                }
                else
                {
                    list.Add(child);
                }
            }
            args.editcontrol.Add(list);//添加控件集合
        }
        /// <summary>
        /// 直接打印
        /// </summary>
        /// <param name="args"></param>
        void EditEventReferences_PrintDialogEvent(EditPrintEventArgs args)
        {
            args.editbitmap.Add((P_bgimg.BackgroundImage as Bitmap));//添加图片到集合
            List<Control> list = new List<Control>();//控件集合
            foreach (Control child in P_bgimg.Controls)
            {
                if (child is ComboBox)
                {
                    //ComboBox不参加打印
                }
                else
                {
                    list.Add(child);
                }
            }
            args.editcontrol.Add(list);//添加控件集合
        }

        /// <summary>
        /// 属性面板已发生变化刷新面板
        /// </summary>
        /// <param name="editname">面板名称</param>
        void EditEventReferences_ApplyEditPropertyFrom(string editname)
        {
            //判断属性面板是否是设置的当前模板的对象|可能有很多个模板对象
            if (Editname == editname)
            {
                FrmEditFrm_Load(null, null);
            }
        }
        /// <summary>
        /// 窗体加载时
        /// </summary>
        private void FrmEditFrm_Load(object sender, EventArgs e)
        {
            try
            {
                //模板的英文名称
                EditEname = EditTemplateInfo.GetEditXmlDocument(Editname.Substring(0, Editname.IndexOf(".")) + ".xml").DocumentElement.ChildNodes[3].InnerText;
                //生成模板
                InitCustomConfig(EditTemplateInfo.GetEditXmlDocument(Editname.Substring(0, Editname.IndexOf(".")) + ".xml"));
                //填充模板
                FillCustomControl();
            }
            catch { }
        }

        #region 根据相关参数生成控件
        /// <summary>
        /// 根据相关参数生成控件
        /// </summary>
        /// <param name="tabindex">控件的Tab索引</param>
        /// <param name="cname">控件的中文名称</param>
        /// <param name="ename">控件的英文名称</param>
        /// <param name="size">控件的尺寸</param>
        /// <param name="location">控件的坐标</param>
        /// <param name="ismultiline">是否是多行文本</param>
        /// <param name="iswrap">多行文本时是否自动换行</param>
        /// <param name="controltype">控件的类型</param>
        /// <param name="borderstyle">控件的边框样式</param>
        /// <param name="autosize">是否自动调整控件高度</param>
        /// <param name="scroll">TextBox控件的滚动条类型(注:只对多行文本有效)</param>
        /// <param name="richscrollbar">RichTextBox控件的滚动条类型</param>
        private Control CreateCustomControl(int tabindex, string cname, string ename, Size size, Point location, EditControlIsOrMultiline ismultiline, EditControlIsOrWrap iswrap, EditControlTypeInfo controltype, BorderStyle borderstyle, bool autosizeheight, ScrollBars scroll, RichTextBoxScrollBars richscrollbar)
        {
            try
            {

                Control CustomControl = null;//用来套用所有形参属性的控件模板
                if (controltype == EditControlTypeInfo.RichTextBox)//判断是否是RichTextBox控件类型
                {
                    CustomControl = System.Activator.CreateInstance(typeof(RichTextBox), true) as RichTextBox;
                    CustomControl.Name = ename;
                    ((CustomControl) as RichTextBox).Multiline = ismultiline == EditControlIsOrMultiline.TrueMultiline ? true : false;
                    ((CustomControl) as RichTextBox).BorderStyle = borderstyle;
                    ((CustomControl) as RichTextBox).BackColor = Color.White;
                    ((CustomControl) as RichTextBox).WordWrap = iswrap == EditControlIsOrWrap.TrueWrap ? true : false;
                    ((CustomControl) as RichTextBox).DetectUrls = true;
                    ((CustomControl) as RichTextBox).ScrollBars = richscrollbar;
                    ((CustomControl) as RichTextBox).MaxLength = 200;
                    ((CustomControl) as RichTextBox).TabIndex = tabindex;
                    ((CustomControl) as RichTextBox).Tag = cname;
                }
                else if (controltype == EditControlTypeInfo.TextBoxLong)//判断是否是TextBoxLong类型,对应于长文本类型
                {
                    CustomControl = System.Activator.CreateInstance(typeof(TextBox), true) as TextBox;
                    CustomControl.Name = ename;
                    ((CustomControl) as TextBox).Multiline = ismultiline == EditControlIsOrMultiline.TrueMultiline ? true : false;
                    ((CustomControl) as TextBox).BackColor = Color.White;
                    ((CustomControl) as TextBox).BorderStyle = borderstyle;
                    ((CustomControl) as TextBox).WordWrap = iswrap == EditControlIsOrWrap.TrueWrap ? true : false;
                    ((CustomControl) as TextBox).ScrollBars = scroll;
                    ((CustomControl) as TextBox).MaxLength = 200;
                    ((CustomControl) as TextBox).TabIndex = tabindex;
                    ((CustomControl) as TextBox).Tag = cname;
                }
                else if (controltype == EditControlTypeInfo.PictureBox)//是否是PictureBox类型
                {
                    CustomControl = System.Activator.CreateInstance(typeof(PictureBox), true) as PictureBox;
                    CustomControl.Name = ename;
                    ((CustomControl) as PictureBox).BackColor = Color.White;
                    ((CustomControl) as PictureBox).BackgroundImageLayout = ImageLayout.Stretch;
                    ((CustomControl) as PictureBox).BorderStyle = borderstyle;
                    ((CustomControl) as PictureBox).SizeMode = PictureBoxSizeMode.Zoom;
                    ((CustomControl) as PictureBox).Tag = cname;
                    CustomControl.Click += new EventHandler(CustomControl_Click);//单击图片事件提示选择图片

                }
                else if (controltype == EditControlTypeInfo.CheckBox)//是否是CheckBox类型
                {
                    CustomControl = System.Activator.CreateInstance(typeof(CheckBox), true) as CheckBox;
                    CustomControl.Name = ename;
                    CustomControl.Text = cname;
                    CustomControl.Tag = cname;
                }
                else if (controltype == EditControlTypeInfo.TextBoxText)//是否是TextBox类型
                {
                    CustomControl = System.Activator.CreateInstance(typeof(TextBox), true) as TextBox;
                    CustomControl.Name = ename;
                    CustomControl.Tag = cname;
                    ((CustomControl) as TextBox).BackColor = Color.White;
                    ((CustomControl) as TextBox).Multiline = ismultiline == EditControlIsOrMultiline.TrueMultiline ? true : false;
                    ((CustomControl) as TextBox).WordWrap = iswrap == EditControlIsOrWrap.TrueWrap ? true : false;
                    ((CustomControl) as TextBox).BorderStyle = borderstyle;
                    ((CustomControl) as TextBox).MaxLength = 200;
                    CustomControl.KeyPress += new KeyPressEventHandler(CustomControl_KeyPress);//TextBox类型验证输入
                }
                else if (controltype == EditControlTypeInfo.DateTimePicker)//是否是DateTimePicker时间类型
                {
                    CustomControl = System.Activator.CreateInstance(typeof(DateTimePicker), true) as DateTimePicker;
                    CustomControl.Name = ename;
                    CustomControl.Tag = cname;
                    ((CustomControl) as DateTimePicker).Value = DateTime.Now;//当前系统时间为准
                }
                else if (controltype == EditControlTypeInfo.TextBoxNumber)//是否是TextBox只能输入数字的文本框
                {
                    CustomControl = System.Activator.CreateInstance(typeof(TextBox), true) as TextBox;
                    CustomControl.Name = ename;
                    CustomControl.Tag = cname;
                    ((CustomControl) as TextBox).BorderStyle = borderstyle;
                    ((CustomControl) as TextBox).BackColor = Color.White;
                    ((CustomControl) as TextBox).WordWrap = iswrap == EditControlIsOrWrap.TrueWrap ? true : false;
                    ((CustomControl) as TextBox).MaxLength = 200;
                    ((CustomControl) as TextBox).Multiline = ismultiline == EditControlIsOrMultiline.TrueMultiline ? true : false;
                    CustomControl.KeyPress += new KeyPressEventHandler(CustomControlNumber_KeyPress);
                }
                CustomControl.TabIndex = tabindex;//Tab索引
                CustomControl.Size = size;//大小
                CustomControl.Location = location;//呈现位置
                CustomControl.ContextMenuStrip = CMS_CustomMenu;//设置控件的快捷菜单
                CustomControl.MouseDown += new MouseEventHandler(CustomControl_MouseDown);
                CustomControl.MouseMove += new MouseEventHandler(CustomControl_MouseMove);
                CustomControl.MouseUp += new MouseEventHandler(CustomControl_MouseUp);
                CustomControl.Move += new EventHandler(CustomControl_Move);
                CustomControl.MouseEnter += new EventHandler(CustomControl_MouseEnter);
                CustomControl.MouseLeave += new EventHandler(CustomControl_MouseLeave);
                P_bgimg.Controls.Add(CustomControl);
                return CustomControl;
            }
            catch (Exception err) { MessageBox.Show(err.ToString()); return new Control(); }
        }
        #endregion

        #region 设置控件的背景色
        void CustomControl_MouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White;
        }
        void CustomControl_MouseEnter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.Yellow;
        }
        #endregion

        #region 移动控件
        /// <summary>
        /// 在控件上移动鼠标时
        /// </summary>
        void CustomControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouse)
            {
                Point move = P_bgimg.PointToClient(Control.MousePosition);
                move.Offset(MovePoint);//偏移控件的相对位置
                ((sender) as Control).Location = move;
                ((sender) as Control).Cursor = System.Windows.Forms.Cursors.SizeAll;//设置鼠标手形为移动
            }
        }
        /// <summary>
        /// 移动控件时|当移动控件并停下时发生
        /// </summary>
        void CustomControl_Move(object sender, EventArgs e)
        {
            //让主窗体显示移动对象的坐标信息
            ControlMouse(Editname, sender, ((sender) as Control).Location);
            EditEventReferences.ActiveMouseControlEvent(((sender) as Control).Name, ((sender) as Control).Location.X, ((sender) as Control).Location.Y);
        }
        /// <summary>
        /// 在控件上释放鼠标时
        /// </summary>
        void CustomControl_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouse = false;
            ((sender) as Control).Cursor = System.Windows.Forms.Cursors.IBeam;
        }
        /// <summary>
        /// 用户在控件上按下鼠标时
        /// </summary>
        void CustomControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MovePoint = new Point(-e.X, -e.Y);//获取鼠标相对于当前移动控件的坐标位置
                IsMouse = true;
            }
        }
        #endregion
        /// <summary>
        /// 填充模板中的控件内容
        /// </summary>
        private void FillCustomControl()
        {
            try
            {
                //判断用户是单套打印还是多套
                if (EditTemplateInfo.IsMuch)
                {
                    //多套打印
                    List<EditTemplateDataSource> Muchlist = (List<EditTemplateDataSource>)EditTemplateInfo.EditDataSource;
                    //暂时用不到
                }
                else
                {
                    //单套打印
                    EditTemplateDataSource Oddlist = (EditTemplateDataSource)EditTemplateInfo.EditDataSource;
                    DataSet editds = Oddlist.EditGlobalDataSource;//模板数据源
                    for (int i = 0; i < editds.Tables.Count; i++)
                    {
                        //查找数据源中是否有本模板的DataTable
                        if (editds.Tables[i].TableName == EditEname)
                        {
                            //填充数据
                            foreach (Control child in P_bgimg.Controls)
                            {
                                if (child is DateTimePicker)
                                {
                                    //转换时间|特殊类型
                                    (child as DateTimePicker).Value = DateTime.Parse(editds.Tables[i].Rows[0][child.Name].ToString());
                                }
                                else if (child is CheckBox)
                                {
                                    //状态装换|特殊类型
                                    (child as CheckBox).Checked = editds.Tables[i].Rows[0][child.Name].ToString() == "true" ? true : false;
                                }
                                else
                                {
                                    child.Text = editds.Tables[i].Rows[0][child.Name].ToString();
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception err)
            {
                //MessageBox.Show("填充模板内容错误,数据源缺少字段!", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 生成模板
        /// </summary>
        /// <param name="editdoc">XML模板</param>
        private void InitCustomConfig(XmlDocument editdoc)
        {
            //模板底图
            Image img = EditTemplateInfo.GetEditImg(Editname);
            P_bgimg.Size = new Size(img.Width, img.Height);
            P_bgimg.BackgroundImage = img;
            //模板中的控件
            P_bgimg.Controls.Clear();//清空模板控件
            //项模板
            foreach (XmlNode item in editdoc.DocumentElement.ChildNodes[4])
            {
                //属性项目|TabIndex索引
                int tabindex = Convert.ToInt32(EditTemplateMethod.GetXmlNodeTextInt(item.SelectSingleNode("TAB_INDEX"), "0"));
                //中文名
                string cname = EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("ITEM_CNAME"));
                //英文名
                string ename = EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("ITEM_ENAME"));
                //控件大小
                Size size = new Size(Convert.ToInt32(EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("ITEM_WIDTH"))), Convert.ToInt32(EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("ITEM_HEIGHT"))));
                //停靠在模板中的位置
                Point location = new Point(Convert.ToInt32(EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("POS_X"))), Convert.ToInt32(EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("POS_Y"))));
                //是否多行文本
                EditControlIsOrMultiline multiline = EditControlIsOrMultiline.FalseMultiline;
                if ((Convert.ToInt32(EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("MULTILINE"))) == 1))
                {
                    multiline = EditControlIsOrMultiline.TrueMultiline;
                }
                //是否自动换行
                EditControlIsOrWrap wrap = EditControlIsOrWrap.FalseWrap;
                if ((Convert.ToInt32(EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("WORD_WRAP"))) == 1))
                {
                    wrap = EditControlIsOrWrap.TrueWrap;
                }
                //默认控件类型为TextBoxText
                EditControlTypeInfo edittype = EditControlTypeInfo.TextBoxText;
                switch (EditTemplateMethod.GetXmlNodeText(item.SelectSingleNode("ITEM_TYPE")))
                {
                    case "RichTextBox": edittype = EditControlTypeInfo.RichTextBox;
                        break;
                    case "TextBoxText": edittype = EditControlTypeInfo.TextBoxText;
                        break;
                    case "TextBoxNumber": edittype = EditControlTypeInfo.TextBoxNumber;
                        break;
                    case "DateTimePicker": edittype = EditControlTypeInfo.DateTimePicker;
                        break;
                    case "PictureBox": edittype = EditControlTypeInfo.PictureBox;
                        break;
                    case "CheckBox": edittype = EditControlTypeInfo.CheckBox;
                        break;
                    case "TextBoxLong": edittype = EditControlTypeInfo.TextBoxLong;
                        break;
                }
                CreateCustomControl(tabindex, cname, ename, size, location, multiline, wrap, edittype, BorderStyle.FixedSingle, true, ScrollBars.Both, RichTextBoxScrollBars.Both);
            }
        }
        /// <summary>
        /// TextBox输入验证|只能输入普通字符
        /// </summary>
        void CustomControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            EditTemplateMethod.KeyPressStandardInput(sender, e);
        }
        /// <summary>
        /// TextBox输入验证|只能输入数字
        /// </summary>
        void CustomControlNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            EditTemplateMethod.KeyPressFloat(sender, e);
        }
        /// <summary>
        /// 加载图片，在模板中展示
        /// </summary>
        void CustomControl_Click(object sender, EventArgs e)
        {
            //暂时用不到
        }
        /// <summary>
        /// 触发当前对象激活事件|更换其他窗体中的数据源
        /// </summary>
        private void P_bgimg_Click(object sender, EventArgs e)
        {
            EditEventReferences.ActiveFromEvent(this);
        }
        /// <summary>
        /// 模板容器鼠标移动
        /// </summary>
        private void P_bgimg_MouseMove(object sender, MouseEventArgs e)
        {
            ActiveEditMouse(e);
            //移动面板
            if (IsMoveParent)
            {
                Point p = this.PointToClient(Control.MousePosition);
                p.Offset(ParentMovePoint);
                P_bgimg.Location = p;
            }
            P_bgimg.Refresh();
        }
        /// <summary>
        /// 主面板按下鼠标时
        /// </summary>
        private void P_bgimg_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsMoveParent = true;
                ParentMovePoint = new Point(-e.X, -e.Y);
                P_bgimg.Cursor = System.Windows.Forms.Cursors.Hand;
            }
        }
        /// <summary>
        /// 主面板释放鼠标时
        /// </summary>
        private void P_bgimg_MouseUp(object sender, MouseEventArgs e)
        {
            IsMoveParent = false;
            P_bgimg.Cursor = System.Windows.Forms.Cursors.Default;
        }
        /// <summary>
        /// 模板激活
        /// </summary>
        private void FrmEditfrom_Activated(object sender, EventArgs e)
        {
            EditEventReferences.ActiveFromEvent(this);
        }
        /// <summary>
        /// 关闭
        /// </summary>
        private void Tool_close_Click(object sender, EventArgs e)
        {
            //
        }
        /// <summary>
        /// 打印预览
        /// </summary>
        private void PrintPreview()
        {
            System.Drawing.Printing.PrintDocument pdocument = new System.Drawing.Printing.PrintDocument();
            pdocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(pdocument_BeginPrint);
            pdocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(pdocument_PrintPage);
            this.Print_Dialog.Document = pdocument;
            this.Print_Dialog.Refresh();
        }
        /// <summary>
        /// 打印每一页时
        /// </summary>
        void pdocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(this.P_bgimg.BackgroundImage, 0, 0, this.P_bgimg.Width, P_bgimg.Height);//底图
            PrintEditData(e);//数据

        }
        /// <summary>
        /// 绘制数据
        /// </summary>
        private void PrintEditData(System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {

                foreach (Control child in P_bgimg.Controls)
                {
                    e.Graphics.DrawString(child.Text, new Font("宋体", 12), Brushes.Black, child.Location.X, child.Location.Y);
                }
            }
            catch (Exception err) { }

        }
        /// <summary>
        /// 开始打印时
        /// </summary>
        void pdocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //
        }
        /// <summary>
        /// 预览模板
        /// </summary>
        private void Tool_preview_Click(object sender, EventArgs e)
        {
            PrintPreview();//预览设置
            Print_Dialog.ShowDialog();
        }
        /// <summary>
        /// 添加控件
        /// </summary>
        private void Tool_controladd_Click(object sender, EventArgs e)
        {
            AddControl(P_bgimg.PointToClient(Control.MousePosition));
        }
        /// <summary>
        /// 添加控件
        /// <param name="location">控件初始坐标</param>
        /// </summary>
        private void AddControl(Point location)
        {
            try
            {
                //添加控件
                TextBox AddTextBox = new TextBox();
                AddTextBox.BorderStyle = BorderStyle.FixedSingle;
                AddTextBox.TabIndex = 1;
                AddTextBox.Width = 200;
                AddTextBox.Location = location;
                AddTextBox.Name = "重命名" + DateTime.Now.ToString();//防止名称重复;//英文名称
                AddTextBox.Tag = "重命名" + DateTime.Now.ToString();//防止名称重复;//中文名称
                AddTextBox.ContextMenuStrip = CMS_CustomMenu;//设置控件的快捷菜单
                AddTextBox.MouseDown += new MouseEventHandler(CustomControl_MouseDown);
                AddTextBox.MouseMove += new MouseEventHandler(CustomControl_MouseMove);
                AddTextBox.MouseUp += new MouseEventHandler(CustomControl_MouseUp);
                AddTextBox.Move += new EventHandler(CustomControl_Move);
                P_bgimg.Controls.Add(AddTextBox);
                //封装控件信息
                EditTemplateAddControlArgs addcontrolarge = new EditTemplateAddControlArgs();
                addcontrolarge.ITEM_CNAME = AddTextBox.Name;
                addcontrolarge.ITEM_ENAME = AddTextBox.Tag.ToString();
                addcontrolarge.ITEM_HEIGHT = AddTextBox.Height;
                addcontrolarge.ITEM_TYPE = "TextBoxText";//默认给个普通文本框
                addcontrolarge.ITEM_WIDTH = AddTextBox.Width;
                addcontrolarge.MULTILINE = "是";
                addcontrolarge.POS_X = AddTextBox.Location.X;
                addcontrolarge.POS_Y = AddTextBox.Location.Y;
                addcontrolarge.TAB_INDEX = AddTextBox.TabIndex.ToString();
                addcontrolarge.WORD_WRAP = "是";
                EditEventReferences.ActiveEditAddControlEvent(addcontrolarge);//触发添加控件事件
            }
            catch (Exception err) { MessageBox.Show(err.ToString()); }
        }
        /// <summary>
        /// 移除控件
        /// </summary>
        private void Tool_remove_Click(object sender, EventArgs e)
        {
            foreach (Control item in P_bgimg.Controls)
            {
                if (item.Focused == true)
                {
                    EditEventReferences.ActiveEditRemoveControlEvent(item.Name.ToString());
                }
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
