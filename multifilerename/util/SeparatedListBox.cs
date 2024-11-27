using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multifilerename.util
{
    public class SeparatedListBox : ListBox
    {
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index > 0)
            {
                // 绘制分隔线
                e.Graphics.DrawLine(Pens.Black, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
            }
            string itemText = (e.Index < 0 || e.Index >= Items.Count) ? "" : Items[e.Index].ToString();
            e.Graphics.DrawString(itemText, e.Font, new SolidBrush(e.ForeColor), new PointF(e.Bounds.X, e.Bounds.Y));
            e.DrawFocusRectangle();
        }
    }
}
