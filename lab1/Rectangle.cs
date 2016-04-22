using System.Drawing;

namespace lab1
{
    class Rectangle : Figure
    {
        protected int width,x,y,height;
        public Rectangle(int x, int y, int height, int width)
        {
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
            pen = new Pen(Color.Purple);
        }

        public override void Draw(Bitmap bitmap)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawRectangle(pen, x, y, height, width);
        }
    }
}