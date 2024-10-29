using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3BAI7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (lstWebsite.SelectedItem != null)
            {
                txtKetQua.Text = $"Website được chọn: {lstWebsite.SelectedItem.ToString()}";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một website!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKetQua.Clear();
        }
    }
}
