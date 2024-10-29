using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3BAI3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThuchien_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNhapA.Text);
            int b = int.Parse(txtNhapB.Text);
            int c = int.Parse(txtNhapA.Text);
            int d = int.Parse(txtNhapB.Text);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            txtUCLN.Text = a.ToString();
            txtBCNN.Text = (c * d / a).ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhapA.Text = "";
            txtNhapB.Text = "";
            txtUCLN.Text = "";
            txtBCNN.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
