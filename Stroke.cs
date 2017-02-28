using Scribble.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

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
                        tool.pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                        // TODO: turn on rounded endcaps
                        var cursivePen = new Pen(tool.pen.Color, tool.size);
                        e.Graphics.DrawEllipse(cursivePen, pt.X - tool.size, pt.Y - tool.size, tool.size, tool.size);
                        if (ptPrev != null)
                            e.Graphics.DrawLine(tool.pen, pt, ptPrev.Value);
                        ptPrev = pt;
       
                    }
                }
                else
                {
                    if (tool.shape == Shape.circle || tool.shape == Shape.cursive)
                        e.Graphics.FillEllipse(tool.brush, pt.X - tool.size, pt.Y - tool.size, tool.size, tool.size);
                    else if (tool.shape == Shape.square || tool.shape == Shape.square)
                        e.Graphics.FillRectangle(tool.brush, pt.X - tool.size, pt.Y - tool.size, tool.size, tool.size);
                    //else if (tool.shape == Shape.cursive);
                }
            }
        }
    }
}
