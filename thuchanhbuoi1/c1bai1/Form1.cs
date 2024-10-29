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

namespace c1bai1
{
    public partial class frmPractice_c1_1 : Form
    {
        public frmPractice_c1_1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            //Vẽ hình chữ nhật
            Graphics g = pe.Graphics;
            Rectangle rect = new Rectangle(80, 30, 100, 200);
            LinearGradientBrush lBrush = new
            LinearGradientBrush(rect, Color.Red, Color.Yellow,
            LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(lBrush, rect);
            //Vẽ hình tròn
            Pen pn = new Pen(Color.Blue);

            Rectangle rectE = new Rectangle(230, 80, 100, 200);
            LinearGradientBrush lBrushE = new

            LinearGradientBrush(rect,

            Color.Orange, Color.Magenta, LinearGradientMode.Vertical);
            g.FillRectangle(lBrush, rect);
            g.FillEllipse(lBrushE, 230, 80, 100, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
