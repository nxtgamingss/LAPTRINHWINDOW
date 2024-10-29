using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C2BAI3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Bài tập thực hành tự làm số 2 – Chương 2";
            MessageBox.Show("Đây là sự kiện Form Load");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đây là sự kiện Click chuột trên Form");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Đây là sự kiện Form Closing chuột trên Form");

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Application.Exit();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Đây là sự kiện Form Closed chuột trên Form");
        }
    }
}
