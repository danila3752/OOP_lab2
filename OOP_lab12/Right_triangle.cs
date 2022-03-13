using System.Collections.Generic;
using System.Drawing;

namespace OOP_lab12
{
    class Right_triangle : Polyline
    {
        public Right_triangle() { }
        public Right_triangle(Point point, Point Bottom) : base(new List<Point>() { point, Bottom, new Point(point.x, Bottom.y) }) { }

    }
}
