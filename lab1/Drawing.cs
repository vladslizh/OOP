using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1
{
    abstract class Drawing
    {

    }

    class DrawEllipse : Drawing
    {
            public DrawEllipse(Ellipse ellipse, Bitmap bitmap)
            {

                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.DrawEllipse(ellipse.GetPen(), ellipse.GetStartCoord().X, ellipse.GetStartCoord().Y, ellipse.GetEndCoord().X - ellipse.GetStartCoord().X, ellipse.GetEndCoord().Y - ellipse.GetStartCoord().Y);
            }


    }
}
