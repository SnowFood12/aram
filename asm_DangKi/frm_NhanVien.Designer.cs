namespace asm_DangKi
{
    partial class frm_NhanVien
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_ThongTinTaiKhoan = new System.Windows.Forms.DataGridView();
            this.lbl_tenDangNhap = new System.Windows.Forms.Label();
            this.lbl_ThongTinTaiKhoan = new System.Windows.Forms.Label();
            this.lbl_taiKhoan = new System.Windows.Forms.Label();
            this.lbl_hoVaTen = new System.Windows.Forms.Label();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_soDienThoai = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.llbl_suaMatKhau = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.pic_thongTinTaiKhoan = new System.Windows.Forms.PictureBox();
            this.chk_tdn = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_thongTinTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1220, 601);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chk_tdn);
            this.tabPage1.Controls.Add(this.dgv_ThongTinTaiKhoan);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1212, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin tài khoản";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.llbl_suaMatKhau);
            this.tabPage2.Controls.Add(this.btn_sua);
            this.tabPage2.Controls.Add(this.pic_thongTinTaiKhoan);
            this.tabPage2.Controls.Add(this.lbl_Email);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.lbl_soDienThoai);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lbl_MatKhau);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lbl_hoVaTen);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lbl_taiKhoan);
            this.tabPage2.Controls.Add(this.lbl_ThongTinTaiKhoan);
            this.tabPage2.Controls.Add(this.lbl_tenDangNhap);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1212, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sửa thông tin tài khoản";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_ThongTinTaiKhoan
            // 
            this.dgv_ThongTinTaiKhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ThongTinTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongTinTaiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_ThongTinTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.dgv_ThongTinTaiKhoan.Name = "dgv_ThongTinTaiKhoan";
            this.dgv_ThongTinTaiKhoan.RowHeadersWidth = 51;
            this.dgv_ThongTinTaiKhoan.RowTemplate.Height = 24;
            this.dgv_ThongTinTaiKhoan.Size = new System.Drawing.Size(1067, 335);
            this.dgv_ThongTinTaiKhoan.TabIndex = 0;
            // 
            // lbl_tenDangNhap
            // 
            this.lbl_tenDangNhap.AutoSize = true;
            this.lbl_tenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenDangNhap.Location = new System.Drawing.Point(183, 218);
            this.lbl_tenDangNhap.Name = "lbl_tenDangNhap";
            this.lbl_tenDangNhap.Size = new System.Drawing.Size(145, 25);
            this.lbl_tenDangNhap.TabIndex = 0;
            this.lbl_tenDangNhap.Text = "Tên đăng nhập";
            // 
            // lbl_ThongTinTaiKhoan
            // 
            this.lbl_ThongTinTaiKhoan.AutoSize = true;
            this.lbl_ThongTinTaiKhoan.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThongTinTaiKhoan.Location = new System.Drawing.Point(355, 1);
            this.lbl_ThongTinTaiKhoan.Name = "lbl_ThongTinTaiKhoan";
            this.lbl_ThongTinTaiKhoan.Size = new System.Drawing.Size(313, 40);
            this.lbl_ThongTinTaiKhoan.TabIndex = 1;
            this.lbl_ThongTinTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // lbl_taiKhoan
            // 
            this.lbl_taiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_taiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_taiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_taiKhoan.Location = new System.Drawing.Point(384, 210);
            this.lbl_taiKhoan.Name = "lbl_taiKhoan";
            this.lbl_taiKhoan.Size = new System.Drawing.Size(333, 38);
            this.lbl_taiKhoan.TabIndex = 2;
            // 
            // lbl_hoVaTen
            // 
            this.lbl_hoVaTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_hoVaTen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_hoVaTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoVaTen.Location = new System.Drawing.Point(384, 338);
            this.lbl_hoVaTen.Name = "lbl_hoVaTen";
            this.lbl_hoVaTen.Size = new System.Drawing.Size(333, 38);
            this.lbl_hoVaTen.TabIndex = 4;
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_MatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatKhau.Location = new System.Drawing.Point(384, 279);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(333, 38);
            this.lbl_MatKhau.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ và tên";
            // 
            // lbl_soDienThoai
            // 
            this.lbl_soDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_soDienThoai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_soDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_soDienThoai.Location = new System.Drawing.Point(384, 397);
            this.lbl_soDienThoai.Name = "lbl_soDienThoai";
            this.lbl_soDienThoai.Size = new System.Drawing.Size(333, 38);
            this.lbl_soDienThoai.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số điện thoại";
            // 
            // lbl_Email
            // 
            this.lbl_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Email.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(384, 461);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(333, 38);
            this.lbl_Email.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email";
            // 
            // btn_sua
            // 
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(756, 213);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(77, 35);
            this.btn_sua.TabIndex = 12;
            this.btn_sua.Text = ">>";
            this.btn_sua.UseVisualStyleBackColor = true;
            // 
            // llbl_suaMatKhau
            // 
            this.llbl_suaMatKhau.AutoSize = true;
            this.llbl_suaMatKhau.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbl_suaMatKhau.LinkColor = System.Drawing.Color.Teal;
            this.llbl_suaMatKhau.Location = new System.Drawing.Point(766, 287);
            this.llbl_suaMatKhau.Name = "llbl_suaMatKhau";
            this.llbl_suaMatKhau.Size = new System.Drawing.Size(42, 24);
            this.llbl_suaMatKhau.TabIndex = 13;
            this.llbl_suaMatKhau.TabStop = true;
            this.llbl_suaMatKhau.Text = "Sửa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1022, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic_thongTinTaiKhoan
            // 
            this.pic_thongTinTaiKhoan.Image = global::asm_DangKi.Properties.Resources.image_account;
            this.pic_thongTinTaiKhoan.Location = new System.Drawing.Point(440, 54);
            this.pic_thongTinTaiKhoan.Name = "pic_thongTinTaiKhoan";
            this.pic_thongTinTaiKhoan.Size = new System.Drawing.Size(159, 128);
            this.pic_thongTinTaiKhoan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_thongTinTaiKhoan.TabIndex = 11;
            this.pic_thongTinTaiKhoan.TabStop = false;
            // 
            // chk_tdn
            // 
            this.chk_tdn.AutoSize = true;
            this.chk_tdn.Location = new System.Drawing.Point(6, 6);
            this.chk_tdn.Name = "chk_tdn";
            this.chk_tdn.Size = new System.Drawing.Size(18, 17);
            this.chk_tdn.TabIndex = 1;
            this.chk_tdn.UseVisualStyleBackColor = true;
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 601);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_NhanVien";
            this.Text = "frm_NhanVien";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_thongTinTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_ThongTinTaiKhoan;
        private System.Windows.Forms.Label lbl_ThongTinTaiKhoan;
        private System.Windows.Forms.Label lbl_tenDangNhap;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_hoVaTen;
        private System.Windows.Forms.Label lbl_taiKhoan;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_soDienThoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pic_thongTinTaiKhoan;
        private System.Windows.Forms.LinkLabel llbl_suaMatKhau;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chk_tdn;
    }
}