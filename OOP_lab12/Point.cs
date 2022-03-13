using System.Windows.Forms;
using System.Drawing;

namespace OOP_lab12
{
    class Point : Shape
    {
        public float x, y;

        public Point() { }

        public Point(Point point)
        {
            this.x = point.x;
            this.y = point.y;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public override void draw(Graphics g)
        {
            SolidBrush aBrush = new SolidBrush(getBorderColor());
            g.FillRectangle(aBrush, this.x, this.y, 2, 2);
        }
    }
}
