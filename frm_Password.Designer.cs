namespace LPR_Laptrinhvb
{
    partial class frm_Password
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.txt_matkhaucu = new System.Windows.Forms.TextBox();
            this.txt_matkhau2 = new System.Windows.Forms.TextBox();
            this.txt_matkhau1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_doimatkhau = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_matkhau1);
            this.groupBox1.Controls.Add(this.txt_matkhau2);
            this.groupBox1.Controls.Add(this.txt_matkhaucu);
            this.groupBox1.Controls.Add(this.txt_taikhoan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đổi mật khẩu";
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Location = new System.Drawing.Point(137, 19);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(135, 20);
            this.txt_taikhoan.TabIndex = 0;
            // 
            // txt_matkhaucu
            // 
            this.txt_matkhaucu.Location = new System.Drawing.Point(137, 48);
            this.txt_matkhaucu.Name = "txt_matkhaucu";
            this.txt_matkhaucu.Size = new System.Drawing.Size(135, 20);
            this.txt_matkhaucu.TabIndex = 1;
            // 
            // txt_matkhau2
            // 
            this.txt_matkhau2.Location = new System.Drawing.Point(137, 106);
            this.txt_matkhau2.Name = "txt_matkhau2";
            this.txt_matkhau2.Size = new System.Drawing.Size(135, 20);
            this.txt_matkhau2.TabIndex = 2;
            // 
            // txt_matkhau1
            // 
            this.txt_matkhau1.Location = new System.Drawing.Point(137, 77);
            this.txt_matkhau1.Name = "txt_matkhau1";
            this.txt_matkhau1.Size = new System.Drawing.Size(135, 20);
            this.txt_matkhau1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật khẩu mới\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nhập lại mật khẩu mới";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Huy);
            this.groupBox2.Controls.Add(this.btn_doimatkhau);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 54);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btn_doimatkhau
            // 
            this.btn_doimatkhau.Location = new System.Drawing.Point(12, 18);
            this.btn_doimatkhau.Name = "btn_doimatkhau";
            this.btn_doimatkhau.Size = new System.Drawing.Size(120, 30);
            this.btn_doimatkhau.TabIndex = 0;
            this.btn_doimatkhau.Text = "Đổi mật khẩu";
            this.btn_doimatkhau.UseVisualStyleBackColor = true;
            this.btn_doimatkhau.Click += new System.EventHandler(this.btn_doimatkhau_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(152, 18);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(120, 30);
            this.btn_Huy.TabIndex = 1;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // frm_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 184);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Password";
            this.Text = "frm_Password";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_matkhau1;
        private System.Windows.Forms.TextBox txt_matkhau2;
        private System.Windows.Forms.TextBox txt_matkhaucu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_doimatkhau;
    }
}