/*----------------------------------------------------
 * 作者:王清培
 * 时间:2010-9-3
 * 新建:该类用来实现编辑模板中的所有模板的集中打印
 * 
 * 
 * 
 --------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing;

namespace PrintThempActiveX
{
    /// <summary>
    /// 该类封装了模板的打印
    /// </summary>
    public static class EditTemplatePrint
    {
        /// <summary>
        /// 可重用的打印对象
        /// </summary>
        private static PrintDocument editprintdocumet = new PrintDocument();
        /// <summary>
        /// 打印预览窗口
        /// </summary>
        private static PrintPreviewDialog editprintdialog = new PrintPreviewDialog();
        /// <summary>
        /// 打印设置对话框
        /// </summary>
        private static PrintDialog editdialog = new PrintDialog();
        /// <summary>
        /// 打印页面设置
        /// </summary>
        private static PageSetupDialog pagesetting = new PageSetupDialog();
        /// <summary>
        /// 模板底图
        /// </summary>
        private static List<Bitmap> editbitmap = new List<Bitmap>();
        /// <summary>
        /// 模板控件
        /// </summary>
        private static List<List<Control>> editcontrol = new List<List<Control>>();
        /// <summary>
        /// 打印设置存放
        /// </summary>
        private static PageSettings pagesettingcol = new PageSettings();
        /// <summary>
        /// 记录当前打印到第几页
        /// </summary>
        private static int printcurrent = 0;
        /// <summary>
        /// 初始化打印对象
        /// </summary>
        static EditTemplatePrint()
        {
            //打印预览对话框相关选项
            editprintdocumet.PrintPage += new PrintPageEventHandler(editprintdocumet_PrintPage);
            editprintdialog.Document = editprintdocumet;//初始化打印预览空间的打印文档
            editprintdialog.ShowIcon = false;
            //打印机相关选项
            editdialog.Document = editprintdocumet;//初始化打印设置窗口
            editdialog.AllowCurrentPage = true;//显示当前页
            editdialog.AllowPrintToFile = true;//显示打印到文件复选框
            editdialog.AllowSelection = true;//显示选择按钮
            editdialog.AllowSomePages = true;//启用页选择
            //打印页面相关选项
            pagesetting.PageSettings = pagesettingcol;//页面设置保存对象

        }
        /// <summary>
        /// 预览模板
        /// </summary>
        /// <param name="editbitmap">模板底图集合</param>
        /// <param name="editconrol">模板控件集合</param>
        public static void PrintView(List<Bitmap> map, List<List<Control>> control)
        {
            editbitmap = map;
            editcontrol = control;

            editdialog.ShowDialog();
            pagesetting.ShowDialog();
            editprintdocumet.DefaultPageSettings = pagesettingcol;
            editprintdialog.ShowDialog();
        }
        /// <summary>
        /// 直接打印
        /// </summary>
        /// <param name="map">模板底图</param>
        /// <param name="control">模板控件集合</param>
        public static void PrintDialogSetting(List<Bitmap> map, List<List<Control>> control)
        {
            editbitmap = map;
            editcontrol = control;
            editdialog.ShowDialog();

            pagesetting.ShowDialog();
            editprintdocumet.DefaultPageSettings = pagesettingcol;//页面相关设置选项
            editprintdocumet.Print();
        }
        /// <summary>
        /// 打印每页时发生
        /// </summary>
        static void editprintdocumet_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.PageUnit = GraphicsUnit.Display;//选择打印机的打印度量单位

            e.Graphics.DrawImage(editbitmap[printcurrent], 0, 0, editbitmap[printcurrent].Width, editbitmap[printcurrent].Height);//绘制底图

            foreach (Control child in editcontrol[printcurrent])
            {
                e.Graphics.DrawString(child.Text, new Font("宋体", 12), Brushes.Black, child.Location.X, child.Location.Y);//绘制控件的文本
            }
            e.HasMorePages = printcurrent < editbitmap.Count - 1 ? true : false;
            if (e.HasMorePages)
            {
                printcurrent++;
            }
            else
            {
                printcurrent = 0;
            }
        }
    }
}