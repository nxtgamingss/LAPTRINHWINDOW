using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C3_BAI_HD_SO_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtChia = new System.Windows.Forms.RadioButton();
            this.rbtNhan = new System.Windows.Forms.RadioButton();
            this.rbtTru = new System.Windows.Forms.RadioButton();
            this.rbtCong = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(227, 355);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 33);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "PHÉP TÍNH";
            // 
            // txtSoa
            // 
            this.txtSoa.Location = new System.Drawing.Point(118, 162);
            this.txtSoa.Multiline = true;
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(100, 32);
            this.txtSoa.TabIndex = 3;
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(535, 162);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(135, 32);
            this.txtKQ.TabIndex = 4;
            // 
            // txtSob
            // 
            this.txtSob.Location = new System.Drawing.Point(336, 162);
            this.txtSob.Multiline = true;
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(133, 32);
            this.txtSob.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtChia);
            this.groupBox1.Controls.Add(this.rbtNhan);
            this.groupBox1.Controls.Add(this.rbtTru);
            this.groupBox1.Controls.Add(this.rbtCong);
            this.groupBox1.Location = new System.Drawing.Point(102, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính";
            // 
            // rbtChia
            // 
            this.rbtChia.AutoSize = true;
            this.rbtChia.Location = new System.Drawing.Point(475, 55);
            this.rbtChia.Name = "rbtChia";
            this.rbtChia.Size = new System.Drawing.Size(55, 20);
            this.rbtChia.TabIndex = 3;
            this.rbtChia.TabStop = true;
            this.rbtChia.Text = "Chia";
            this.rbtChia.UseVisualStyleBackColor = true;
            this.rbtChia.CheckedChanged += new System.EventHandler(this.rbtChia_CheckedChanged);
            // 
            // rbtNhan
            // 
            this.rbtNhan.AutoSize = true;
            this.rbtNhan.Location = new System.Drawing.Point(303, 55);
            this.rbtNhan.Name = "rbtNhan";
            this.rbtNhan.Size = new System.Drawing.Size(60, 20);
            this.rbtNhan.TabIndex = 2;
            this.rbtNhan.TabStop = true;
            this.rbtNhan.Text = "Nhân";
            this.rbtNhan.UseVisualStyleBackColor = true;
            this.rbtNhan.CheckedChanged += new System.EventHandler(this.rbtNhan_CheckedChanged);
            // 
            // rbtTru
            // 
            this.rbtTru.AutoSize = true;
            this.rbtTru.Location = new System.Drawing.Point(165, 55);
            this.rbtTru.Name = "rbtTru";
            this.rbtTru.Size = new System.Drawing.Size(48, 20);
            this.rbtTru.TabIndex = 1;
            this.rbtTru.TabStop = true;
            this.rbtTru.Text = "Trừ";
            this.rbtTru.UseVisualStyleBackColor = true;
            this.rbtTru.CheckedChanged += new System.EventHandler(this.rbtTru_CheckedChanged);
            // 
            // rbtCong
            // 
            this.rbtCong.AutoSize = true;
            this.rbtCong.Location = new System.Drawing.Point(15, 55);
            this.rbtCong.Name = "rbtCong";
            this.rbtCong.Size = new System.Drawing.Size(60, 20);
            this.rbtCong.TabIndex = 0;
            this.rbtCong.TabStop = true;
            this.rbtCong.Text = "Cộng";
            this.rbtCong.UseVisualStyleBackColor = true;
            this.rbtCong.CheckedChanged += new System.EventHandler(this.rbtCong_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(495, 355);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 33);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số b";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kết quả";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(802, 390);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSob);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoa);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÀI_TẬP_HƯỚNG_DẪN_02_CHƯƠNG_3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private double Calculate(double number1, double number2)
        {
            if (rbtCong.Checked)
                return number1 + number2;
            else if (rbtTru.Checked)
                return number1 - number2;
            else if (rbtNhan.Checked)
                return number1 * number2;
            else if (rbtChia.Checked)
                return number2 != 0 ? number1 / number2 : 0;
            return 0;
        }

       

        private void rbtChia_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtSoa.Text, out double number1) &&
      double.TryParse(txtSob.Text, out double number2))
            {
                txtKQ.Text = Calculate(number1, number2).ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSoa.Clear();
            txtSob.Clear();
            txtKQ.Clear();
            rbtCong.Checked = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void rbtCong_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtSoa.Text, out double number1) &&
      double.TryParse(txtSob.Text, out double number2))
            {
                txtKQ.Text = Calculate(number1, number2).ToString();
            }
        }

        private void rbtTru_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtSoa.Text, out double number1) &&
      double.TryParse(txtSob.Text, out double number2))
            {
                txtKQ.Text = Calculate(number1, number2).ToString();
            }
        }

        private void rbtNhan_CheckedChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtSoa.Text, out double number1) &&
      double.TryParse(txtSob.Text, out double number2))
            {
                txtKQ.Text = Calculate(number1, number2).ToString();
            }
        }
    }
}
