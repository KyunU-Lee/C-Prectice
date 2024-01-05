using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto_M_S
{
    internal class BorderPanel : Panel
    {
        Pen _pen = new Pen(new SolidBrush(Color.Black), 1);
        public BorderPanel()
        {
           ResizeRedraw = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawRectangle(_pen, this.ClientRectangle);
        }
    }
}
