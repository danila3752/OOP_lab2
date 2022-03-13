using System.Drawing;

namespace OOP_lab12
{
    abstract public class Shape
    {
        private Color borderColor;

        public Shape()
        {
            borderColor = Color.FromName("Black");
        }

        public Color getBorderColor()
        {
            return borderColor;
        }

        public void setBorderColor(Color borderColor)
        {
            this.borderColor = borderColor;
        }

        public abstract void draw(Graphics g);
    }
}
