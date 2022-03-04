using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    class Circle : Shape
    {
        public Circle(int xStart, int yStart, int xEnd, int yEnd, Pen pen) 
            : base(xStart,  yStart,  xEnd,  yEnd,  pen)
        {
  
        }
        public override void Draw(Graphics g) {
            g.DrawEllipse(Pen, XStart, YStart, XEnd, YEnd);
        }
    }
}
