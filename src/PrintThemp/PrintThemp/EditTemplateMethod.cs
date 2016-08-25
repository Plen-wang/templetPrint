using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Data;
using System.Drawing;

namespace PrintThemp
{
    /// <summary>
    /// 该类封装了模板中零散的方法
    /// </summary>
    public static class EditTemplateMethod
    {
        /// <summary>
        /// 获取 Xml 节点内的文本，节点不存在时返回空值。
        /// </summary>
        /// <param name="node">Xml 节点。</param>
        /// <returns>节点内的文本。</returns>
        public static string GetXmlNodeText(XmlNode node)
        {
            if (node != null)
            {
                return node.InnerText.Trim();
            }
            else
            {
                return string.Empty;
            }
        }
        /// <summary>
        /// 获取 Xml 节点内的文本数值，节点不存在时返回 "0"（默认）或者指定的缺省文本数值。
        /// </summary>
        /// <param name="node">Xml 节点。</param>
        /// <returns>节点内的文本数值。</returns>
        public static string GetXmlNodeTextInt(XmlNode node, string textInt)
        {
            if (node != null)
            {
                return node.InnerText.Trim();
            }
            else if (textInt != null)
            {
                return textInt;
            }
            else
            {
                return "0";
            }
        }
        /// <summary>
        /// 只允许输入数字、小数点和负号。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void KeyPressFloat(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            switch (ch)
            {
                case (char)3:	// 判断是否为 Ctrl + C
                    return;

                case (char)22:	// 判断是否为 Ctrl + V
                    return;

                case (char)24:	// 判断是否为 Ctrl + X
                    return;

                case (char)26:	// 判断是否为 Ctrl + Z
                    return;

                case (char)27:	// 判断是否为 Esc 键
                    return;

                case '\r':		// 判断是否为 Enter 键
                    return;

                case '\b':		// 判断是否为 Backspace 键
                    return;

                case '.':		// 判断是否为 . 键
                    return;

                case '-':		// 判断是否为 - 键
                    return;

                default:
                    if (!(ch >= '0' && ch <= '9')) // 数字以外的按键都作为已处理
                    {
                        e.Handled = true;
                        return;
                    }
                    break;
            }
        }
        /// <summary>
        /// 只允许输入字母、数字和下划线。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void KeyPressStandardInput(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            switch (ch)
            {
                case (char)3:	// 判断是否为 Ctrl + C
                    return;

                case (char)22:	// 判断是否为 Ctrl + V
                    return;

                case (char)24:	// 判断是否为 Ctrl + X
                    return;

                case (char)26:	// 判断是否为 Ctrl + Z
                    return;

                case (char)27:	// 判断是否为 Esc 键
                    return;

                case '\r':		// 判断是否为 Enter 键
                    return;

                case '\b':		// 判断是否为 Backspace 键
                    return;

                case '_':		// 判断是否为 _ 键
                    return;

                default:
                    if (!((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z') || (ch >= '0' && ch <= '9')))// 字母、数字以外的按键都作为已处理
                    {
                        e.Handled = true;//拦截事件处理程序替代系统处理线程
                        return;
                    }
                    break;
            }
        }
        /// <summary>
        /// 只允许输入字母、数字、下划线、括号、星号、分号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void KeyPressStandard(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            switch (ch)
            {
                case (char)3:	// 判断是否为 Ctrl + C
                    return;

                case (char)22:	// 判断是否为 Ctrl + V
                    return;

                case (char)24:	// 判断是否为 Ctrl + X
                    return;

                case (char)26:	// 判断是否为 Ctrl + Z
                    return;

                case (char)27:	// 判断是否为 Esc 键
                    return;

                case (char)32:  //空格键
                    return;

                case '\r':		// 判断是否为 Enter 键
                    return;

                case '\b':		// 判断是否为 Backspace 键
                    return;

                case '_':		// 判断是否为 _ 键
                    return;
                case '(':
                    return;
                case ')':
                    return;
                case ';':
                    return;
                case ',':
                    return;
                case '.':
                    return;
                default:
                    if (!((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z') || (ch >= '0' && ch <= '9') || ch == '*'))// 字母、数字以外的按键都作为已处理
                    {
                        e.Handled = true;//拦截事件处理程序替代系统处理线程
                        return;
                    }
                    break;
            }
        }
        /// <summary>
        /// 将XmlDocument转换成DataTable|只支持单行数据
        /// </summary>
        /// <param name="Node">XmlNode</param>
        /// <returns>DataTable</returns>
        public static DataTable XmlToDataTable(XmlNode Node)
        {
            DataTable NodeToDt = new DataTable(Node.Name);
            DataRow NodeRow;
            //插入列
            foreach (XmlNode i in Node)
            {
                if (i.NodeType == XmlNodeType.Element)
                {
                    NodeToDt.Columns.Add(i.Name);
                }
            }
            NodeRow = NodeToDt.NewRow();
            //插入行
            foreach (XmlNode i in Node)
            {
                NodeRow[i.Name] = i.InnerText;
            }
            return NodeToDt;
        }
        /// <summary>
        /// 为参数中指定的节点添加子节点。
        /// </summary>
        /// <param name="doc">节点隶属的 XML 文档。</param>
        /// <param name="element">要添加子节点的节点。</param>
        /// <param name="elementName">子节点的名称。</param>
        /// <param name="elementValue">子节点的值，如果该值为 null，则表示要生成的节点将会有子节点。</param>
        /// <returns>添加的子节点。</returns>
        public static XmlElement AppendChildElement(XmlDocument doc, XmlElement element, string elementName, string elementValue)
        {
            XmlElement childElement = doc.CreateElement(elementName);

            if (elementValue != null && elementValue != string.Empty)
            {
                childElement.InnerText = elementValue;
            }

            element.AppendChild(childElement);

            return childElement;
        }
        /// <summary>
        /// 缩放图片并返回缩放后的图片
        /// </summary>
        /// <param name="img">Bitmap</param>
        /// <param name="neww">新的宽度</param>
        /// <param name="newh">新的高度</param>
        /// <returns>Bitmap</returns>
        public static Bitmap ResizeImage(Bitmap img, int neww, int newh)
        {
            Bitmap newimg = new Bitmap(neww, newh);
            Graphics g = Graphics.FromImage(newimg);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear ;
            g.DrawImage(newimg, new Rectangle(0, 0, neww, newh), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
            g.Dispose();
            return newimg;
        }

    }
}
