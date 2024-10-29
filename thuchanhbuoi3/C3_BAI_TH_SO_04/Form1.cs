using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3BAI5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       private int GetDaysInMonth(int month, int year)
        {
            return DateTime.DaysInMonth(year, month);
        }

        private void btnTH_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtThang.Text, out int month) && int.TryParse(txtNam.Text, out int year))
            {
                int days = GetDaysInMonth(month, year);
                txtKQ.Text = $"Số ngày của tháng {month} trong năm {year} là {days}.";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tháng và năm hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            txtThang.Clear();
            txtNam.Clear();
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
