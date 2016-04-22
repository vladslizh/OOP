using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class GraphProg : Form
    {
        private ListFigures listFigures;
        private Point start, end;

        public GraphProg()
        {
            InitializeComponent();

            Init();
            Draw();
        }

        private void Init()
        {   
            listFigures = new ListFigures(pictureBox);

            Line line = new Line(100, 50, 200, 80);
            listFigures.AddFigure(line);

            Square square = new Square(150, 150, 100);
            listFigures.AddFigure(square);

            Rectangle rectangle = new Rectangle(250,50, 140, 80);
            listFigures.AddFigure(rectangle);

            Circle circle = new Circle(350, 150, 100);
            listFigures.AddFigure(circle);

            Ellipse ellipse = new Ellipse(270, 150, 70, 120);
            listFigures.AddFigure(ellipse);

            Polygon polygon = new Polygon(50, 120, 140, 180, 120, 230, 50, 180);
            listFigures.AddFigure(polygon);
        }

        private void Draw()
        {
            pictureBox.Image = listFigures.DrawFigures();           
        }

        private void GraphProg_Load(object sender, System.EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, System.EventArgs e)
        {

        }

        private void listShapes_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void label1Coord_Click(object sender, System.EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, System.EventArgs e)
        {

        }

        private void buttonDraw_Click(object sender, System.EventArgs e)
        {
            DrawFigure();
        }

        private void DrawFigure()
        {
            
        }
    }
}