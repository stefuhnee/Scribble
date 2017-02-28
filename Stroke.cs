using Scribble.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scribble
{
    public class Stroke
    {
        public List<Point> mouseTrack = new List<Point>();
        public Pen pen;
        public Shape shape;

        public void DrawThyself(PaintEventArgs e)
        {
            Point? ptPrev = null;
            foreach (Point pt in mouseTrack)
            {
                if (shape == Shape.circle)
                    e.Graphics.DrawEllipse(pen, pt.X - 10, pt.Y - 10, 20, 20);
                else if (shape == Shape.square)
                    e.Graphics.DrawRectangle(pen, pt.X - 10, pt.Y - 10, 20, 20);
                else if (shape == Shape.msft)
                    e.Graphics.DrawImage(Resources.msft, pt);
                else if (shape == Shape.cursive)
                {
                    // TODO: turn on rounded endcaps
                    if (ptPrev != null)
                        e.Graphics.DrawLine(pen, pt, ptPrev.Value);
                    ptPrev = pt;
                }
            }
        }
    }
}
