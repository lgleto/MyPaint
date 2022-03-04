using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    abstract class Shape
    {
        public int XStart { get; set; }
        public int XEnd { get; set; }
        public int YStart { get; set; }
        public int YEnd { get; set; }
        public Pen Pen { get; set; }

        public Shape(int xStart, int yStart, int xEnd, int yEnd, Pen pen)
        {
            XStart = xStart;
            XEnd = xEnd;
            YStart = yStart;
            YEnd = yEnd;
            Pen = pen;
        }

        public abstract void Draw(Graphics g);
  
    }
}
