using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scribble
{
    public enum Shape
    {
        circle,
        square,
        msft,
        cursive,

    }

    public class ScribblePoint
    {
        public Point pt;
        public Pen pen;
        public Shape shape;
    }
}
