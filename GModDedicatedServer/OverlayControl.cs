using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GModDedicatedServer
{
    class OverlayControl : TextBox
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams CP = base.CreateParams;
                CP.ExStyle |= 0x20;
                return CP;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // base.OnPaintBackground(pevent);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            Pen pen = new Pen(Color.Red, 4f);
            pevent.Graphics.DrawEllipse(pen, this.ClientRectangle);
        }
    }
}
