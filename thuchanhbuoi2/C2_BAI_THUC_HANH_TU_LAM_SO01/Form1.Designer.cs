namespace c2bai2
{
    partial class Form1
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
            this.btnMM = new System.Windows.Forms.Button();
            this.btnClick = new System.Windows.Forms.Button();
            this.btnTCT = new System.Windows.Forms.Button();
            this.btnTC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMM
            // 
            this.btnMM.Location = new System.Drawing.Point(158, 149);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(161, 50);
            this.btnMM.TabIndex = 0;
            this.btnMM.Text = "Sự kiện MouseMove";
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(464, 149);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(183, 55);
            this.btnClick.TabIndex = 1;
            this.btnClick.Text = "Sự kiện Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnTCT
            // 
            this.btnTCT.Location = new System.Drawing.Point(464, 272);
            this.btnTCT.Name = "btnTCT";
            this.btnTCT.Size = new System.Drawing.Size(183, 52);
            this.btnTCT.TabIndex = 2;
            this.btnTCT.Text = "Thoát chương trình ";
            this.btnTCT.UseVisualStyleBackColor = true;
            this.btnTCT.Click += new System.EventHandler(this.btnTCT_Click);
            // 
            // btnTC
            // 
            this.btnTC.Location = new System.Drawing.Point(158, 272);
            this.btnTC.Name = "btnTC";
            this.btnTC.Size = new System.Drawing.Size(161, 52);
            this.btnTC.TabIndex = 3;
            this.btnTC.Text = "Sự kiện TextChange";
            this.btnTC.UseVisualStyleBackColor = true;
            this.btnTC.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "SỰ KIỆN CỦA FROM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTC);
            this.Controls.Add(this.btnTCT);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.btnMM);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Bài thực hành tự làm số 01- chương 2 ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnTCT;
        private System.Windows.Forms.Button btnTC;
        private System.Windows.Forms.Label label1;
    }
}

