using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Winform
{
    public partial class Clock : Form
    {

        Bitmap bitmap;
        Graphics cg;
        Font font = new Font("Arial", 12);
        Brush my_brush = new SolidBrush(Color.Black);
        int cx, cy;
        int width = 300, height = 300;
        public Clock()
        {
            InitializeComponent();
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            font=new Font("Arial", 12);
            my_brush = new SolidBrush(Color.Black);
            bitmap = new Bitmap(width, height);
            cg = Graphics.FromImage(bitmap);
            cg.Clear(Color.BurlyWood);
            cx = width / 2;
            cy = height / 2;
            //pictureBox1.Image = bitmap;
            //timer1.Interval = 1000;
            //timer1.Tick += Timer1_Tick;
            //timer1.Start();
            Draw();
        }

        private void Draw()
        {
            cg.Clear(Color.White);
            cg.DrawEllipse(Pens.Black, 0, 0, width - 1, height - 1);
            cg.DrawString("12", font, my_brush, new Point(140,3));
            cg.DrawString("1", font, my_brush, new Point(218,22));
            cg.DrawString("2", font, my_brush, new Point(263,70));
            cg.DrawString("3", font, my_brush, new Point(285, 140));
            cg.DrawString("4", font, my_brush, new Point(263, 212));
            cg.DrawString("5", font, my_brush, new Point(218, 259));
            cg.DrawString("6", font, my_brush, new Point(142,279));
            cg.DrawString("7", font, my_brush, new Point(70, 259));
            cg.DrawString("8", font, my_brush, new Point(22, 212));
            cg.DrawString("9", font, my_brush, new Point(1,140));
            cg.DrawString("10", font, my_brush, new Point(22,70));
            cg.DrawString("11", font, my_brush, new Point(70, 22));

            Pen hr = new Pen(Color.Chocolate, 4);
            Pen min = new Pen(Color.Blue, 2);
            Pen sec= new Pen(Color.Red, 1);

            cg.DrawLine(hr, cx, cy,160, 100);
            cg.DrawLine(min, cx, cy, 200, 50);
            cg.DrawLine(sec, cx, cy, 220, 75);



            pictureBox1.Image = bitmap;
            //for (int i = 0; i < 12; i++)
            //{
            //    double angle = i * Math.PI / 6;
            //    int x1 = (int)(cx + Math.Sin(angle) * (width / 2 - 10));
            //    int y1 = (int)(cy - Math.Cos(angle) * (height / 2 - 10));
            //    int x2 = (int)(cx + Math.Sin(angle) * (width / 2 - 20));
            //    int y2 = (int)(cy - Math.Cos(angle) * (height / 2 - 20));
            //    cg.DrawLine(Pens.Black, x1, y1, x2, y2);
            //}
            //DateTime now = DateTime.Now;
            //double hourAngle = now.Hour % 12 * Math.PI / 6 + now.Minute * Math.PI / 360;
            //double minuteAngle = now.Minute * Math.PI / 30 + now.Second * Math.PI / 1800;
            //double secondAngle = now.Second * Math.PI / 30;
            //int hourX = (int)(cx + Math.Sin(hourAngle) * (width / 4));
            //int hourY = (int)(cy - Math.Cos(hourAngle) * (height / 4));
            //int minuteX = (int)(cx + Math.Sin(minuteAngle) * (width / 3));
            //int minuteY = (int)(cy - Math.Cos(minuteAngle) * (height / 3));
            //int secondX = (int)(cx + Math.Sin(secondAngle) * (width / 2 - 20));
            //int secondY = (int)(cy - Math.Cos(secondAngle) * (height / 2 - 20));
            //cg.DrawLine(Pens.Black, cx, cy, hourX, hourY);
            //cg.DrawLine(Pens.Black, cx, cy, minuteX, minuteY);
            //cg.DrawLine(Pens.Red, cx, cy, secondX, secondY);
            //pictureBox1.Image = bitmap;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
