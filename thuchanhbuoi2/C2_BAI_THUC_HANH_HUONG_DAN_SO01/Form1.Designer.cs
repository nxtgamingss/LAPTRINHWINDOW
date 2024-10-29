namespace c2bai1
{
    partial class frmPractice_c2_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDoitieude = new System.Windows.Forms.Button();
            this.btnThemForm = new System.Windows.Forms.Button();
            this.btnGoiFormKhac = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDoitieude
            // 
            this.btnDoitieude.Location = new System.Drawing.Point(204, 188);
            this.btnDoitieude.Name = "btnDoitieude";
            this.btnDoitieude.Size = new System.Drawing.Size(133, 49);
            this.btnDoitieude.TabIndex = 0;
            this.btnDoitieude.Text = "Đổi tiêu đề Form";
            this.btnDoitieude.UseVisualStyleBackColor = true;
            this.btnDoitieude.Click += new System.EventHandler(this.btnDoitieude_Click_1);
            // 
            // btnThemForm
            // 
            this.btnThemForm.Location = new System.Drawing.Point(436, 188);
            this.btnThemForm.Name = "btnThemForm";
            this.btnThemForm.Size = new System.Drawing.Size(129, 49);
            this.btnThemForm.TabIndex = 1;
            this.btnThemForm.Text = "Tạo Form mới";
            this.btnThemForm.UseVisualStyleBackColor = true;
            this.btnThemForm.Click += new System.EventHandler(this.btnThemForm_Click);
            // 
            // btnGoiFormKhac
            // 
            this.btnGoiFormKhac.Location = new System.Drawing.Point(204, 272);
            this.btnGoiFormKhac.Name = "btnGoiFormKhac";
            this.btnGoiFormKhac.Size = new System.Drawing.Size(133, 52);
            this.btnGoiFormKhac.TabIndex = 2;
            this.btnGoiFormKhac.Text = "Gọi hiển thị Form khác";
            this.btnGoiFormKhac.UseVisualStyleBackColor = true;
            this.btnGoiFormKhac.Click += new System.EventHandler(this.btnGoiFormKhac_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(436, 272);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(129, 52);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát Chương trình";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "THIẾT LẬP CÁC THUỘC TÍNH CỦA FORM";
            // 
            // frmPractice_c2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGoiFormKhac);
            this.Controls.Add(this.btnThemForm);
            this.Controls.Add(this.btnDoitieude);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.KeyPreview = true;
            this.Name = "frmPractice_c2_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài thực hành hướng dẫn 01 – Chương 1";
            this.Load += new System.EventHandler(this.frmPractice_c2_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoitieude;
        private System.Windows.Forms.Button btnThemForm;
        private System.Windows.Forms.Button btnGoiFormKhac;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
    }
}

