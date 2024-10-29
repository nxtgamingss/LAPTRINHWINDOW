using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3BAI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txtNhapc.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                txtNhapc.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double a = double.Parse(txtNhapa.Text);
                double b = double.Parse(txtNhapb.Text);
                if (a == 0)
                {
                    if (b == 0)
                        txtKetqua.Text = "Phương trình vô số nghiệm.";
                    else
                        txtKetqua.Text = "Phương trình vô nghiệm.";
                }
                else
                {
                    double result = -b / a;
                    txtKetqua.Text = "Nghiệm: " + result.ToString();
                }
            }
            else if (radioButton2.Checked)
            {
                double a = double.Parse(txtNhapa.Text);
                double b = double.Parse(txtNhapb.Text);
                double c = double.Parse(txtNhapc.Text);
                double delta = b * b - 4 * a * c;

                if (delta < 0)
                {
                    txtKetqua.Text = "Phương trình vô nghiệm.";
                }
                else if (delta == 0)
                {
                    double result = -b / (2 * a);
                    txtKetqua.Text = "Nghiệm kép: " + result.ToString();
                }
                else
                {
                    double result1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double result2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    txtKetqua.Text = "Hai nghiệm: " + result1.ToString() + " và " + result2.ToString();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
