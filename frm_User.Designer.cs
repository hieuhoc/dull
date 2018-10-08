namespace LPR_Laptrinhvb
{
    partial class frm_User
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
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_lammoi = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_xoathongtinnguoidung = new System.Windows.Forms.Button();
            this.btn_dangkynguoidung = new System.Windows.Forms.Button();
            this.btn_suathongtinguoidung = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_nguoidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennguoidung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMTND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_timkiem = new System.Windows.Forms.ComboBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_manguoidung = new System.Windows.Forms.TextBox();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.txt_hovaten = new System.Windows.Forms.TextBox();
            this.txt_cmtnd = new System.Windows.Forms.TextBox();
            this.txt_sodienthoai = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.cbo_chucvu = new System.Windows.Forms.ComboBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.dtp_ngaysinh);
            this.groupBox1.Controls.Add(this.cbo_chucvu);
            this.groupBox1.Controls.Add(this.txt_cmtnd);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.txt_hovaten);
            this.groupBox1.Controls.Add(this.txt_sodienthoai);
            this.groupBox1.Controls.Add(this.txt_taikhoan);
            this.groupBox1.Controls.Add(this.txt_manguoidung);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = global::LPR_Laptrinhvb.Properties.Resources.if_free_29_618316;
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(633, 19);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 30);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Image = global::LPR_Laptrinhvb.Properties.Resources.if_view_refresh_118801;
            this.btn_lammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_lammoi.Location = new System.Drawing.Point(552, 19);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(75, 30);
            this.btn_lammoi.TabIndex = 5;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_lammoi.UseVisualStyleBackColor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Image = global::LPR_Laptrinhvb.Properties.Resources.if_floppy_285657;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(471, 19);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 30);
            this.btn_luu.TabIndex = 4;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_xoathongtinnguoidung
            // 
            this.btn_xoathongtinnguoidung.Image = global::LPR_Laptrinhvb.Properties.Resources.if_free_27_616650;
            this.btn_xoathongtinnguoidung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoathongtinnguoidung.Location = new System.Drawing.Point(311, 19);
            this.btn_xoathongtinnguoidung.Name = "btn_xoathongtinnguoidung";
            this.btn_xoathongtinnguoidung.Size = new System.Drawing.Size(154, 30);
            this.btn_xoathongtinnguoidung.TabIndex = 3;
            this.btn_xoathongtinnguoidung.Text = "Xóa thông tin người dùng";
            this.btn_xoathongtinnguoidung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoathongtinnguoidung.UseVisualStyleBackColor = true;
            this.btn_xoathongtinnguoidung.Click += new System.EventHandler(this.btn_xoathongtinnguoidung_Click);
            // 
            // btn_dangkynguoidung
            // 
            this.btn_dangkynguoidung.Image = global::LPR_Laptrinhvb.Properties.Resources.if_list_add_user_9381;
            this.btn_dangkynguoidung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangkynguoidung.Location = new System.Drawing.Point(5, 19);
            this.btn_dangkynguoidung.Name = "btn_dangkynguoidung";
            this.btn_dangkynguoidung.Size = new System.Drawing.Size(135, 30);
            this.btn_dangkynguoidung.TabIndex = 1;
            this.btn_dangkynguoidung.Text = "Đăng ký người dùng";
            this.btn_dangkynguoidung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dangkynguoidung.UseVisualStyleBackColor = true;
            this.btn_dangkynguoidung.Click += new System.EventHandler(this.btn_dangkynguoidung_Click);
            // 
            // btn_suathongtinguoidung
            // 
            this.btn_suathongtinguoidung.Image = global::LPR_Laptrinhvb.Properties.Resources.if_tools_599559;
            this.btn_suathongtinguoidung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suathongtinguoidung.Location = new System.Drawing.Point(146, 19);
            this.btn_suathongtinguoidung.Name = "btn_suathongtinguoidung";
            this.btn_suathongtinguoidung.Size = new System.Drawing.Size(159, 30);
            this.btn_suathongtinguoidung.TabIndex = 2;
            this.btn_suathongtinguoidung.Text = "Sửa thông tin người dùng";
            this.btn_suathongtinguoidung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_suathongtinguoidung.UseVisualStyleBackColor = true;
            this.btn_suathongtinguoidung.Click += new System.EventHandler(this.btn_suathongtinguoidung_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(735, 377);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách người dùng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_nguoidung,
            this.tennguoidung,
            this.taikhoan,
            this.ngaysinh,
            this.chucvu,
            this.CMTND,
            this.sodienthoai,
            this.diachi});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(729, 358);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ID_nguoidung
            // 
            this.ID_nguoidung.DataPropertyName = "ID_nguoidung";
            this.ID_nguoidung.HeaderText = "Mã người dùng";
            this.ID_nguoidung.Name = "ID_nguoidung";
            // 
            // tennguoidung
            // 
            this.tennguoidung.DataPropertyName = "tennguoidung";
            this.tennguoidung.HeaderText = "Họ và tên";
            this.tennguoidung.Name = "tennguoidung";
            // 
            // taikhoan
            // 
            this.taikhoan.DataPropertyName = "taikhoan";
            this.taikhoan.HeaderText = "Tài khoản";
            this.taikhoan.Name = "taikhoan";
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "ngaysinh";
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            // 
            // chucvu
            // 
            this.chucvu.DataPropertyName = "chucvu";
            this.chucvu.HeaderText = "Chức vụ";
            this.chucvu.Name = "chucvu";
            // 
            // CMTND
            // 
            this.CMTND.DataPropertyName = "CMTND";
            this.CMTND.HeaderText = "CMTND";
            this.CMTND.Name = "CMTND";
            // 
            // sodienthoai
            // 
            this.sodienthoai.DataPropertyName = "sodienthoai";
            this.sodienthoai.HeaderText = "Số điện thoại";
            this.sodienthoai.Name = "sodienthoai";
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "diachi";
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_timkiem);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbo_timkiem);
            this.groupBox3.Controls.Add(this.btn_timkiem);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(723, 75);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(270, 22);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(350, 20);
            this.txt_timkiem.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập ký tự";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn trường";
            // 
            // cbo_timkiem
            // 
            this.cbo_timkiem.FormattingEnabled = true;
            this.cbo_timkiem.Items.AddRange(new object[] {
            "Mã người dùng",
            "Họ và tên",
            "Tài khoản"});
            this.cbo_timkiem.Location = new System.Drawing.Point(78, 21);
            this.cbo_timkiem.Name = "cbo_timkiem";
            this.cbo_timkiem.Size = new System.Drawing.Size(121, 21);
            this.cbo_timkiem.TabIndex = 1;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Image = global::LPR_Laptrinhvb.Properties.Resources.if_system_search_118797;
            this.btn_timkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiem.Location = new System.Drawing.Point(634, 16);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(81, 30);
            this.btn_timkiem.TabIndex = 0;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_manguoidung
            // 
            this.txt_manguoidung.Location = new System.Drawing.Point(140, 41);
            this.txt_manguoidung.Name = "txt_manguoidung";
            this.txt_manguoidung.Size = new System.Drawing.Size(200, 20);
            this.txt_manguoidung.TabIndex = 7;
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Location = new System.Drawing.Point(140, 93);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(200, 20);
            this.txt_taikhoan.TabIndex = 8;
            // 
            // txt_hovaten
            // 
            this.txt_hovaten.Location = new System.Drawing.Point(140, 67);
            this.txt_hovaten.Name = "txt_hovaten";
            this.txt_hovaten.Size = new System.Drawing.Size(200, 20);
            this.txt_hovaten.TabIndex = 9;
            // 
            // txt_cmtnd
            // 
            this.txt_cmtnd.Location = new System.Drawing.Point(511, 67);
            this.txt_cmtnd.Name = "txt_cmtnd";
            this.txt_cmtnd.Size = new System.Drawing.Size(200, 20);
            this.txt_cmtnd.TabIndex = 8;
            // 
            // txt_sodienthoai
            // 
            this.txt_sodienthoai.Location = new System.Drawing.Point(511, 93);
            this.txt_sodienthoai.Name = "txt_sodienthoai";
            this.txt_sodienthoai.Size = new System.Drawing.Size(200, 20);
            this.txt_sodienthoai.TabIndex = 9;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(511, 119);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(200, 20);
            this.txt_diachi.TabIndex = 10;
            // 
            // cbo_chucvu
            // 
            this.cbo_chucvu.FormattingEnabled = true;
            this.cbo_chucvu.Items.AddRange(new object[] {
            "Quản trị viên",
            "Kiểm soát viên",
            "Quản lý"});
            this.cbo_chucvu.Location = new System.Drawing.Point(511, 40);
            this.cbo_chucvu.Name = "cbo_chucvu";
            this.cbo_chucvu.Size = new System.Drawing.Size(200, 21);
            this.cbo_chucvu.TabIndex = 11;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(140, 119);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(200, 20);
            this.dtp_ngaysinh.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.btn_suathongtinguoidung);
            this.groupBox4.Controls.Add(this.btn_dangkynguoidung);
            this.groupBox4.Controls.Add(this.btn_xoathongtinnguoidung);
            this.groupBox4.Controls.Add(this.btn_luu);
            this.groupBox4.Controls.Add(this.btn_lammoi);
            this.groupBox4.Controls.Add(this.btn_thoat);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 145);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(729, 133);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã người dùng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Họ và tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tài khoản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Chức vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(421, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "CMTND";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Số điện thoại";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(421, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Địa chỉ";
            // 
            // frm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_User";
            this.Text = "User";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_lammoi;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_xoathongtinnguoidung;
        private System.Windows.Forms.Button btn_dangkynguoidung;
        private System.Windows.Forms.Button btn_suathongtinguoidung;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_timkiem;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_nguoidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennguoidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMTND;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.ComboBox cbo_chucvu;
        private System.Windows.Forms.TextBox txt_cmtnd;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_hovaten;
        private System.Windows.Forms.TextBox txt_sodienthoai;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.TextBox txt_manguoidung;
    }
}