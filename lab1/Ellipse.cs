using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1
{
    class Ellipse : Figure
    {
        private int x, y, height, width;
        public Ellipse(int x, int y, int height, int width)
        {
            pen = new Pen(Color.Green);
            this.x = x;
            this.y = y;
            this.height = height;
            this.width = width;
        }
        
        public override Drawing FactoryMethod(Bitmap bitmap)
        {
            return new DrawEllipse(this, bitmap);
        }
    }
}