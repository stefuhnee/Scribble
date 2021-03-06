﻿using System;
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

        public ScribbleTool(bool isFilled, int size, Color color, Shape shape)
        {
            this.size = size;
            this.color = color;
            this.shape = shape;
            makeBrush();

            if (isFilled)
                this.isPen = false;
            else
            {
                this.isPen = true;
                makePen();
            }
        }

        private void makePen()
        {
            pen = new Pen(brush);
        }

        private void makeBrush()
        {
           brush = new SolidBrush(color);
        }
    }

}
