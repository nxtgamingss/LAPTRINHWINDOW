using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3BAI1
{
    public partial class frmPractice_c3_g1 : Form
    {
        public frmPractice_c3_g1()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if ((txtTENDN.Text == "admin") && (txtMATKHAU.Text == "@123"))
                MessageBox.Show("Bạn đã đăng nhập thành công");
            else
                MessageBox.Show("Tên ĐN hoặc mật mẩu sai.Hãy nhập lại!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show(" Bạn có muốn thoát không ?",
                " Thoát Form",MessageBoxButtons.YesNo);

            if (hoi == DialogResult.Yes)
                Application.Exit();
        }
    }
}
