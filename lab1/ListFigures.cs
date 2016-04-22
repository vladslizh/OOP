using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace lab1
{
    class ListFigures
    {
        private List<Figure> listFigures = new List<Figure>();
        private Bitmap bmp;

        public ListFigures(PictureBox picture)
        {
            bmp = new Bitmap(picture.Width, picture.Height);
        }

        public void AddFigure(Figure figure)
        {
            listFigures.Add(figure);
        }

        public Bitmap DrawFigures()
        {
            foreach (var figure in listFigures)
            {
                figure.Draw(bmp);
            }
            return bmp;
        }
    }
}