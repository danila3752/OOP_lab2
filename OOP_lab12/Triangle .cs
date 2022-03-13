using System.Collections.Generic;
using System.Drawing;

namespace OOP_lab12
{
    class Triangle : Polyline
    {
        public Triangle() { }
        public Triangle(Point point, Point Bottom) : base(new List<Point>() {point, Bottom, new Point(2 * point.x - Bottom.x, Bottom.y) }) { }
    }
}
