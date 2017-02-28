using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Scribble
{
    class ScribbleTool
    {
        public int size;
        public Color color;
        public Shape shape;
        public bool isFilled;
        public bool isPen;
        public bool isBrush;

        public Pen makePen()
        {
            Pen myPen = new Pen(color, size);
            myPen.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
            return myPen;
        }

        public Brush makeBrush()
        {
            var myBrush = SystemBrushes.FromSystemColor(color);
            return myBrush;
        }
    }

}
