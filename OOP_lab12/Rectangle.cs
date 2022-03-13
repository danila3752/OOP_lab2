using System.Collections.Generic;

namespace OOP_lab12
{
    class Rectangle : Polyline
    {
        public Rectangle() {  }
        public Rectangle(Point top, Point bottom) : base(new List<Point>() { top, new Point(bottom.x, top.y), bottom, new Point(top.x, bottom.y) }) { }
    }
}
