using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c2bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Text = "Bài tập 2- Chương 2";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là sự kiện di chuyển chuột ");

        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;

        }

        private void btnTCT_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
           hoi= MessageBox.Show("Bạn có muốn thoát không,", "Sự kiện thoát ", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes) { 
                Application.Exit();
            }
        }
    }
}
