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
        public ScribbleTool tool;

        public void DrawThyself(PaintEventArgs e)
        {
            Point? ptPrev = null;
            foreach (Point pt in mouseTrack)
            {
                if (tool.isPen)
                {
                    if (tool.shape == Shape.circle)
                        e.Graphics.DrawEllipse(tool.pen, pt.X - tool.size, pt.Y - tool.size, tool.size, tool.size);
                    else if (tool.shape == Shape.square)
                        e.Graphics.DrawRectangle(tool.pen, pt.X - tool.size, pt.Y - tool.size, tool.size, tool.size);
                    else if (tool.shape == Shape.msft)
                        e.Graphics.DrawImage(Resources.msft, pt);
                    else if (tool.shape == Shape.cursive)
                    {
                        // TODO: turn on rounded endcaps
                        if (ptPrev != null)
                            e.Graphics.DrawLine(tool.pen, pt, ptPrev.Value);
                        ptPrev = pt;
                    }
                }

                
            }
        }
    }
}
