using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Scribble
{
    public class ScribbleTool
    {
        public int size = 10;
        public Color color = Color.Black;
        public Shape shape = Shape.cursive;
        public bool isPen = true;
        public Pen pen;
        public Brush brush;

        public ScribbleTool(bool isFilled)
        {
            if (isFilled)
            {
                this.isPen = false;
                makeBrush();
            }
            else
            {
                this.isPen = true;
                makePen();
            }
        }

        private void makePen()
        {
            pen = new Pen(color, size);
            pen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
        }

        private void makeBrush()
        {
            Brush brush = SystemBrushes.FromSystemColor(color);
        }
    }

}
