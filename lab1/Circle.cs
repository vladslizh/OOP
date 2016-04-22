using System.Drawing;

namespace lab1
{
    class Circle : Ellipse
    {
        public Circle(int x, int y, int height) : base(x, y, height,height)
        {
            pen = new Pen(Color.Blue);
        }
       
    }
}
