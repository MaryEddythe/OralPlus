using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace OralPlus
{
    public class CircularPictureBox: PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new Region(path);
            }
        }
    }
}
