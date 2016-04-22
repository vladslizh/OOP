using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1
{
    abstract class Figure
    {
        protected Pen pen;
        private Point startCoord, endCoord;
        public abstract Drawing FactoryMethod(Bitmap bitmap);

        public Pen GetPen()
        {
            return pen;
        }

        public Point SetStartCoord(Point coord)
        {
            return startCoord = coord;
        }

        public Point GetStartCoord()
        {
            return startCoord;
        }

        public Point SetEndCoord(Point coord)
        {
            return endCoord = coord;
        }

        public Point GetEndCoord()
        {
            return endCoord;
        }

    }
}