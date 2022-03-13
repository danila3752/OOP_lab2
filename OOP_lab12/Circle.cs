using System.Drawing;
using System;

namespace OOP_lab12
{
    class Circle : Ellipse 
    {
        public Circle(Point top, float side) : base(top,  new Point(top.x + side, top.y + side)) { }

    }
}
