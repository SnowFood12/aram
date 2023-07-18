namespace asm_DangKi
{
    partial class frm_KiemKho
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
            this.tab_KiemKho = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_DanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.lbl_NguoiKiemKho = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_NgayKiemKho = new System.Windows.Forms.Label();
            this.lbl_HangTrongKho = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_HangHetHSD = new System.Windows.Forms.Label();
            this.btn_LoaiBo = new System.Windows.Forms.Button();
            this.tab_KiemKho.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_KiemKho
            // 
            this.tab_KiemKho.Controls.Add(this.tabPage1);
            this.tab_KiemKho.Controls.Add(this.tabPage2);
            this.tab_KiemKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_KiemKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_KiemKho.Location = new System.Drawing.Point(0, 0);
            this.tab_KiemKho.Name = "tab_KiemKho";
            this.tab_KiemKho.SelectedIndex = 0;
            this.tab_KiemKho.Size = new System.Drawing.Size(1206, 600);
            this.tab_KiemKho.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1370, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kiểm tra hàng tồn kho";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_LoaiBo);
            this.tabPage2.Controls.Add(this.lbl_HangHetHSD);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.lbl_HangTrongKho);
            this.tabPage2.Controls.Add(this.lbl_NgayKiemKho);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.lbl_NguoiKiemKho);
            this.tabPage2.Controls.Add(this.dgv_DanhSachSanPham);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1198, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kiểm tra hàng hết hạn";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_DanhSachSanPham
            // 
            this.dgv_DanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_DanhSachSanPham.Location = new System.Drawing.Point(3, 242);
            this.dgv_DanhSachSanPham.Name = "dgv_DanhSachSanPham";
            this.dgv_DanhSachSanPham.RowHeadersWidth = 51;
            this.dgv_DanhSachSanPham.RowTemplate.Height = 24;
            this.dgv_DanhSachSanPham.Size = new System.Drawing.Size(1192, 313);
            this.dgv_DanhSachSanPham.TabIndex = 0;
            // 
            // lbl_NguoiKiemKho
            // 
            this.lbl_NguoiKiemKho.AutoSize = true;
            this.lbl_NguoiKiemKho.Location = new System.Drawing.Point(43, 17);
            this.lbl_NguoiKiemKho.Name = "lbl_NguoiKiemKho";
            this.lbl_NguoiKiemKho.Size = new System.Drawing.Size(196, 29);
            this.lbl_NguoiKiemKho.TabIndex = 1;
            this.lbl_NguoiKiemKho.Text = "Người kiểm kho:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(974, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(173, 36);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // lbl_NgayKiemKho
            // 
            this.lbl_NgayKiemKho.AutoSize = true;
            this.lbl_NgayKiemKho.Location = new System.Drawing.Point(779, 37);
            this.lbl_NgayKiemKho.Name = "lbl_NgayKiemKho";
            this.lbl_NgayKiemKho.Size = new System.Drawing.Size(189, 29);
            this.lbl_NgayKiemKho.TabIndex = 3;
            this.lbl_NgayKiemKho.Text = "Ngày kiểm kho:";
            // 
            // lbl_HangTrongKho
            // 
            this.lbl_HangTrongKho.AutoSize = true;
            this.lbl_HangTrongKho.Location = new System.Drawing.Point(43, 83);
            this.lbl_HangTrongKho.Name = "lbl_HangTrongKho";
            this.lbl_HangTrongKho.Size = new System.Drawing.Size(192, 29);
            this.lbl_HangTrongKho.TabIndex = 4;
            this.lbl_HangTrongKho.Text = "Hàng trong kho:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hiển thị";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_HangHetHSD
            // 
            this.lbl_HangHetHSD.AutoSize = true;
            this.lbl_HangHetHSD.Location = new System.Drawing.Point(43, 135);
            this.lbl_HangHetHSD.Name = "lbl_HangHetHSD";
            this.lbl_HangHetHSD.Size = new System.Drawing.Size(303, 29);
            this.lbl_HangHetHSD.TabIndex = 6;
            this.lbl_HangHetHSD.Text = "Hàng đã hết hạn sử dụng:";
            // 
            // btn_LoaiBo
            // 
            this.btn_LoaiBo.Location = new System.Drawing.Point(378, 128);
            this.btn_LoaiBo.Name = "btn_LoaiBo";
            this.btn_LoaiBo.Size = new System.Drawing.Size(107, 42);
            this.btn_LoaiBo.TabIndex = 7;
            this.btn_LoaiBo.Text = "Loại bỏ";
            this.btn_LoaiBo.UseVisualStyleBackColor = true;
            // 
            // frm_KiemKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 600);
            this.Controls.Add(this.tab_KiemKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_KiemKho";
            this.Text = "frm_KiemKho";
            this.tab_KiemKho.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_KiemKho;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_DanhSachSanPham;
        private System.Windows.Forms.Label lbl_NguoiKiemKho;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_LoaiBo;
        private System.Windows.Forms.Label lbl_HangHetHSD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_HangTrongKho;
        private System.Windows.Forms.Label lbl_NgayKiemKho;
    }
}