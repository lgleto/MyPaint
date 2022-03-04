using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    class Line : Shape
    {
        public Line(int xStart, int yStart, int xEnd, int yEnd, Pen pen)
            : base(xStart, yStart, xEnd, yEnd, pen)
        {

        }

        public override void Draw(Graphics g) {
            var point1 = new Point(XStart, YStart);
            var point2 = new Point(XEnd, YEnd);
            g.DrawLine(Pen, point1, point2);
        }

    }
}
