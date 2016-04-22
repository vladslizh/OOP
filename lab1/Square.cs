using System.Drawing;

namespace lab1
{
    class Square : Rectangle
    {

        public Square (int x, int y, int height):base(x,y,height,height)
        {
            pen = new Pen(Color.Red);
        }
    }
}