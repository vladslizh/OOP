using System.Drawing;

namespace lab1
{
    class Polygon : Figure
    {
        private int[] xCoordinates, yCoordinates;

        public Polygon() { }
        public Polygon(params int[] coordinatesXY)
        {
            xCoordinates = new int[coordinatesXY.Length / 2];
            yCoordinates = new int[coordinatesXY.Length / 2];
            for (int i = 0; i < xCoordinates.Length; i++)
            {
                xCoordinates[i] = coordinatesXY[2*i];
                yCoordinates[i] = coordinatesXY[2*i + 1];
            }
            pen = new Pen(Color.Yellow);
        }

        public override void Draw(Bitmap bitmap)
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            int i;
            for (i = 0; i < xCoordinates.Length - 1; i++)
            {
                graphics.DrawLine(pen, xCoordinates[i], yCoordinates[i], xCoordinates[i + 1], yCoordinates[i + 1]);
            }
            graphics.DrawLine(pen , xCoordinates[i], yCoordinates[i], xCoordinates[0], yCoordinates[0]);
        }
    }
}