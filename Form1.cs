using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp =new Bitmap(pictureBox1.Width,pictureBox1.Height);
            Graphics graf = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Green);
            graf.DrawRectangle(pen, 500, 1, 200, 100);
            
            SolidBrush ellipse = new SolidBrush(Color.DeepPink);
            graf.FillEllipse(ellipse, 500, 300, 200, 70);
            graf.DrawEllipse(pen, 1, 260, 100, 100);
            SolidBrush polygon = new SolidBrush(Color.Brown);
            Point point1 = new Point(50, 50);
            Point point2 = new Point(70, 25);
            Point point3 = new Point(150, 5);
            Point point4 = new Point(250, 50);
            Point point5 = new Point(300, 100);
            Point point6 = new Point(350, 200);
            Point point7 = new Point(250, 250);

            Point[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7,
                 
             };

            graf.FillPolygon(polygon, curvePoints);

            pictureBox1.Image = bmp;
                
        }
    }
}
