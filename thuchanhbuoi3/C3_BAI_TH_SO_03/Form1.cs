using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3BAI4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        private List<int> FindPrimesLessThan(int n)
        {
            List<int> primes = new List<int>();
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtNhapn.Text, out int n))
            {
               
                txtKiemTraSNT.Text = IsPrime(n) ? $"{n} là số nguyên tố" : $"{n} không phải là số nguyên tố";

               
                var primes = FindPrimesLessThan(n);
                txtTimSNT.Text = string.Join(", ", primes);
            }
            else
            {
                txtKiemTraSNT.Text = "";
                txtTimSNT.Text = "";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
