using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3BAI6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int FindMax(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        private void btnTH_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNhapa.Text, out int a) && int.TryParse(txtNhapb.Text, out int b) && int.TryParse(txtNhapc.Text, out int c))
            {
                int max = FindMax(a, b, c);
                txtKQ.Text = $"Số lớn nhất là: {max}.";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập các số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            txtNhapa.Clear();
            txtNhapb.Clear();
            txtNhapc.Clear();
            txtKQ.Clear();
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
