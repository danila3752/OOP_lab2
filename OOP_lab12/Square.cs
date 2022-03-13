using System.Drawing;

namespace OOP_lab12
{
    class Square : Rectangle
    {

        public Square(Point top, float Side) : base(top, new Point(top.x+Side, top.y+Side)) { }
    }
}
