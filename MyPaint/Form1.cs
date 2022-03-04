using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{

    public enum DesignType { 
        Line,
        Circle,
        Pen,
        Rectangle
    }
    public partial class Form1 : Form
    {
        int xStart;
        int yStart;

        List<Shape> shapes = new List<Shape>();
        Shape shape;

        bool isMousePressed = false;

        DesignType designType = DesignType.Line;
        Pen pen = new Pen(Color.Black, 1);

        public Form1()
        {
            InitializeComponent();
        }

        private void panelDrawing_Paint(object sender, PaintEventArgs e)
        {
 
            Graphics g = e.Graphics;
            foreach (var shape in shapes)
            {
                shape.Draw(g);
            }
            if(shape != null)
            {
                shape.Draw(g);
            }
        }

        private void panelDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            isMousePressed = true;
            xStart = e.X;
            yStart = e.Y;
        }

        private void panelDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            switch (designType) {
                case DesignType.Line:
                    shapes.Add(new Line(xStart, yStart, e.X, e.Y, pen));
                    break;
                case DesignType.Circle:
                    shapes.Add(new Circle(xStart, yStart, e.X, e.Y, pen));
                    break;
            }
            this.shape = null;
            panelDrawing.Refresh();
            isMousePressed = false;
        }

        private void panelDrawing_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMousePressed)
            {
                switch (designType)
                {
                    case DesignType.Line:
                        shape = new Line(xStart, yStart, e.X, e.Y, pen);
                        break;
                    case DesignType.Circle:
                        shape = new Circle(xStart, yStart, e.X, e.Y, pen);
                        break;
                }
                panelDrawing.Refresh();
            }
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            designType = DesignType.Line;
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            designType = DesignType.Circle;
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black, 1);
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Red, 1);
        }
    }
}
