using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace OOP_lab12
{

    public partial class Form1 : Form
    {
        private static Point topPoint = new Point();
        private Point previousPoint = new Point(topPoint);
        private bool mouseIsDown = false;
        private bool isShiftDown = false;
        Shape previousFigure;
        Graphics g;
        ShapeList shapeList = new ShapeList();
        public Form1()
        {
            InitializeComponent();
            g = DrawPanel.CreateGraphics();
        }

        public void MyKeyPressEventHandler(Object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            (DrawPanel as Control).KeyPress += new KeyPressEventHandler(MyKeyPressEventHandler);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            DrawPanel.Width = this.Width - 40;
            DrawPanel.Height = this.Height - DrawPanel.Top - 50;
        }

        private void DrawPanel_Click(object sender, EventArgs e)
        {
            MouseEventArgs e2 = (MouseEventArgs)e;

            Point point = new Point(e2.X, e2.Y);
            point.setBorderColor(panelColor.BackColor);
            point.draw(g);
            shapeList.add(point);
        }

        private void Black_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Black.BackColor;
        }

        private void Gray_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Gray.BackColor;
        }

        private void Brown_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Brown.BackColor;
        }

        private void White_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = White.BackColor;
        }

        private void DrawPanel_MouseDown(object sender, MouseEventArgs e)
        {
            topPoint.x = e.X;
            topPoint.y = e.Y;
            previousPoint.x = topPoint.x;
            previousPoint.y = topPoint.y;
            mouseIsDown = true;
            previousFigure = new Point(topPoint.x, topPoint.y);
        }

        public void ErasePrevious(Shape shape)
        {
            shape.setBorderColor(DrawPanel.BackColor);
            shape.draw(g);
            shapeList.draw(g);
        }

        private void DrawPanel_MouseMove(object sender, MouseEventArgs e)
        {
            Point bottomPoint = new Point(e.X, e.Y);
            isShiftDown = Control.ModifierKeys == Keys.Shift;
            if (mouseIsDown && ButtonRect.Checked && !isShiftDown)
            {
                ErasePrevious(previousFigure);
                
                Rectangle rect = new Rectangle(topPoint, bottomPoint);
                rect.setBorderColor(panelColor.BackColor);
                rect.draw(g);
                previousFigure = rect;
                previousPoint = bottomPoint;
            }
            if (mouseIsDown && ButtonRect.Checked && isShiftDown)
            {
                ErasePrevious(previousFigure);

                Square rect = new Square(topPoint, bottomPoint.x-topPoint.x);
                rect.setBorderColor(panelColor.BackColor);
                rect.draw(g);
                previousFigure = rect;
                previousPoint = bottomPoint;
            }
            if (mouseIsDown && ButtonTriangle.Checked)
            {
                ErasePrevious(previousFigure);

                Triangle triangle = new Triangle(topPoint, bottomPoint);
                triangle.setBorderColor(panelColor.BackColor);
                triangle.draw(g);
                previousFigure = triangle;
                previousPoint = bottomPoint;
            }
            if (mouseIsDown && ButtonEllipse.Checked && !isShiftDown)
            {
                ErasePrevious(previousFigure);

                Ellipse ellipse = new Ellipse(topPoint, bottomPoint);
                ellipse.setBorderColor(panelColor.BackColor);
                ellipse.draw(g);
                previousFigure = ellipse;
                previousPoint = bottomPoint;
            }
            if (mouseIsDown && ButtonEllipse.Checked && isShiftDown)
            {
                ErasePrevious(previousFigure);

                Circle circle = new Circle(topPoint, bottomPoint.x-topPoint.x);
                circle.setBorderColor(panelColor.BackColor);
                circle.draw(g);
                previousFigure = circle;
                previousPoint = bottomPoint;
            }
            if (mouseIsDown && ButtonPrTriangle.Checked)
            {
                ErasePrevious(previousFigure);

                Right_triangle triangle = new Right_triangle(topPoint, bottomPoint);
                triangle.setBorderColor(panelColor.BackColor);
                triangle.draw(g);
                previousFigure = triangle;
                previousPoint = bottomPoint;
            }
            if (mouseIsDown && ButtonSegment.Checked)
            {
                ErasePrevious(previousFigure);

                Polyline line = new Polyline(new List<Point>() { topPoint, bottomPoint });
                line.setBorderColor(panelColor.BackColor);
                line.draw(g);
                previousFigure = line;
                previousPoint = bottomPoint;
            }
        }

        private void DrawPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
            Point top = new Point(topPoint.x, topPoint.y);
            if(top.x == previousPoint.x && top.y == previousPoint.y)
            {
                Point point = new Point(top.x, top.y);
                point.setBorderColor(panelColor.BackColor);
                point.draw(g);
                shapeList.add(point);
                return;
            }
            if (ButtonRect.Checked && !isShiftDown)
            {
                Rectangle rect = new Rectangle(top, new Point(previousPoint.x, previousPoint.y));
                rect.setBorderColor(panelColor.BackColor);
                shapeList.add(rect);
            }
            if (ButtonRect.Checked && isShiftDown)
            {
                Square rect = new Square(top, previousPoint.x-top.x);
                rect.setBorderColor(panelColor.BackColor);
                shapeList.add(rect);
                isShiftDown = false;
            }
            if (ButtonTriangle.Checked)
            {
                Triangle rect = new Triangle(top, new Point(previousPoint.x, previousPoint.y));
                rect.setBorderColor(panelColor.BackColor);
                shapeList.add(rect);
            }
            if (ButtonEllipse.Checked && !isShiftDown)
            {
                Ellipse ellipse = new Ellipse(top, new Point(e.X, e.Y));
                ellipse.setBorderColor(panelColor.BackColor);
                shapeList.add(ellipse);
            }
            if (ButtonEllipse.Checked && isShiftDown)
            {
                Circle circle = new Circle(top, previousPoint.x - top.x);
                circle.setBorderColor(panelColor.BackColor);
                shapeList.add(circle);
                isShiftDown = false;
            }
            if (ButtonPrTriangle.Checked)
            {
                Right_triangle triangle = new Right_triangle(top, new Point(e.X, e.Y));
                triangle.setBorderColor(panelColor.BackColor);
                shapeList.add(triangle);
            }
            if (ButtonSegment.Checked)
            {
                Polyline line = new Polyline(new List<Point>() { top, new Point(e.X, e.Y) });
                line.setBorderColor(panelColor.BackColor);
                shapeList.add(line);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
                isShiftDown = true;
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Yellow.BackColor;
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Orange.BackColor;
        }

        private void Red_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Red.BackColor;
        }

        private void Green_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Green.BackColor;
        }

        private void Lime_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Lime.BackColor;
        }

        private void SkyBlue_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = SkyBlue.BackColor;
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Blue.BackColor;
        }

        private void Teal_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Teal.BackColor;
        }

        private void Purple_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = Purple.BackColor;
        }

        private void LightPurple_Click(object sender, EventArgs e)
        {
            panelColor.BackColor = LightPurple.BackColor;
        }
    }
}
