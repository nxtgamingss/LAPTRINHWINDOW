using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c1bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            Font f = new Font("Times New Roman", 15);
            Brush _brush = new
            SolidBrush(Color.Chocolate); PointF _pf =
            new PointF(130, 30);
            g.DrawString("Hello World", f, _brush, _pf);

            Pen pn = new Pen(Color.Orange);
            Point pt1 = new Point(120, 200);
            Point pt2 = new Point(230, 200);
            Point pt3 = new Point(255, 100);
            Point pt4 = new Point(280, 200);
            Point pt5 = new Point(380, 200);
            Point pt6 = new Point(305, 250);
            Point pt7 = new Point(330, 350);
            Point pt8 = new Point(255, 275);
            Point pt9 = new Point(170, 350);
            Point pt10 = new Point(205, 250);

            g.DrawLine(pn, pt1, pt2);
            g.DrawLine(pn, pt2, pt3);
            g.DrawLine(pn, pt3, pt4);
            g.DrawLine(pn, pt4, pt5);
            g.DrawLine(pn, pt5, pt6);
            g.DrawLine(pn, pt6, pt7);
            g.DrawLine(pn, pt7, pt8);
            g.DrawLine(pn, pt8, pt9);
            g.DrawLine(pn, pt9, pt10);
            g.DrawLine(pn, pt10, pt1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
