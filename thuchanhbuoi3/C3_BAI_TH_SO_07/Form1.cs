using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3_Bai_thuc_hanh_so_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 31; i++)
            {
                cmbNgay.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                cmbThang.Items.Add(i);
            }


            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                cmbNam.Items.Add(i);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (cmbNgay.SelectedItem != null && cmbThang.SelectedItem != null && cmbNam.SelectedItem != null)
            {
                string truong = txtTruong.Text;
                string ngay = cmbNgay.SelectedItem.ToString();
                string thang = cmbThang.SelectedItem.ToString();
                string nam = cmbNam.SelectedItem.ToString();
                string NĐT = txtNĐT.Text;
                txtKetQua.Text = $"{truong}" +"\n"+
                                 $",Ngày: {ngay}, Tháng: {thang}, Năm: {nam},"
                                 + "\n" + $"{NĐT}";

            }
            else
            {
                MessageBox.Show("Vui lòng chọn đầy đủ Ngày, Tháng và Năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
