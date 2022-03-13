using System.Drawing;
using System.Collections.Generic;

namespace OOP_lab12
{
    class ShapeList
    {
        private List<Shape> shapeList;

        public ShapeList()
        {
            this.shapeList = new List<Shape>();
        }

        public int Count()
        {
            return shapeList.Count;
        }

        public void add(Shape shape)
        {
            shapeList.Add(shape);
        }

        public void removeLast()
        {
            shapeList.RemoveAt(shapeList.Count-1);
        }

        public void draw(Graphics g)
        {
            foreach(Shape shape in shapeList)
            {
                shape.draw(g);
            }
        }
    }
}
