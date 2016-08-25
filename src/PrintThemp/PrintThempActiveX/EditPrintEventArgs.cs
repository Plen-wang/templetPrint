using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PrintThempActiveX
{
    /// <summary>
    /// 模板打印委托传送的信息
    /// </summary>
    public class EditPrintEventArgs
    {
        /// <summary>
        /// 模板集合
        /// </summary>
        public List<Bitmap> editbitmap = new List<Bitmap>();
        /// <summary>
        /// 控件集合
        /// </summary>
        public List<List<Control>> editcontrol = new List<List<Control>>();

    }
}
