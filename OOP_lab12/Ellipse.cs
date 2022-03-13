using System;
using System.Collections.Generic;
using System.Drawing;

namespace OOP_lab12
{
    class Ellipse : Polyline
    {
        private Point fixedPoint, movingPoint;

        public Ellipse() { }
        static float invCathetus(float cathetus)
        {
            return (float)Math.Sqrt(1 - cathetus * cathetus);
        }

        public static List<Point> GetPoints(Point topLeft, float width, float height)
        {
            List<Point> points = new List<Point>();
            float rX = (float)(width / 2), rY = (float)height / 2;
            int N = (int)Math.Abs(width * height / 10);

            float dx = 1.0F / N / 2;
            for (float xCoef = -1; xCoef <= 1; xCoef += dx)
            {
                float y = invCathetus(xCoef) * rY;
                float x = xCoef * rX + topLeft.x;
                points.Insert(points.Count/2, new Point(x, y + topLeft.y));
                points.Insert(points.Count / 2 + 1, new Point(x, -y + topLeft.y));
            }
            return points;
        }

        public Ellipse(Point topLeft, Point bottom) //: base(GetPoints(topLeft, bottom.x-topLeft.x, topLeft.y-bottom.y)) { }
        {
            fixedPoint = topLeft;
            movingPoint = bottom;
        }

        public override void draw(Graphics g)
        {
            Pen pen = new Pen(getBorderColor(), 2);
            System.Drawing.RectangleF rect = new System.Drawing.RectangleF(fixedPoint.x, fixedPoint.y, movingPoint.x - fixedPoint.x, movingPoint.y - fixedPoint.y);
            g.DrawEllipse(pen, rect);
        }
    }
}
