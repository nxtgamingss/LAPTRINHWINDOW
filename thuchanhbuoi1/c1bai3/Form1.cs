using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c1bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            //Ellipse
            Graphics g = pe.Graphics;
            Rectangle rect = new Rectangle(200, 180, 200, 180);
            LinearGradientBrush lBrush = new
            LinearGradientBrush(rect, Color.Gold, Color.Pink,
            LinearGradientMode.Vertical);
            g.FillEllipse(lBrush, rect);

            Pen pn = new Pen(Color.Chocolate, 15);
            Rectangle CP = new Rectangle(250, 220, 15, 15);
            Rectangle CT = new Rectangle(330, 220, 15, 15);
            g.DrawEllipse(pn, CP);
            g.DrawEllipse(pn, CT);

            Pen pc = new Pen(Color.Chocolate, 10);
            Rectangle cg = new Rectangle(240, 200, 120, 120);
            g.DrawArc(pc, cg, 35, 100);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
