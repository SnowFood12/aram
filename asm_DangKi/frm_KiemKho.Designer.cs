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
            this.tab_TonKho = new System.Windows.Forms.TabPage();
            this.grp_ThaoTac = new System.Windows.Forms.GroupBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_CanBangKho = new System.Windows.Forms.Button();
            this.btn_XuatFile = new System.Windows.Forms.Button();
            this.lbl_TongChiPhi = new System.Windows.Forms.Label();
            this.lbl_TongSL = new System.Windows.Forms.Label();
            this.lbl_TongSLLech = new System.Windows.Forms.Label();
            this.lbl_TongChiPhiLech = new System.Windows.Forms.Label();
            this.grp_XuLi = new System.Windows.Forms.GroupBox();
            this.dgv_XuLySanPham = new System.Windows.Forms.DataGridView();
            this.MaSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTonKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLThucTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLLech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTriLech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XuHuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_ChonSP = new System.Windows.Forms.GroupBox();
            this.cbo_SanPham = new System.Windows.Forms.ComboBox();
            this.grp_ThoiGianTab1 = new System.Windows.Forms.GroupBox();
            this.lbl_ThoiGianTab1 = new System.Windows.Forms.Label();
            this.lbl_ThoiGian = new System.Windows.Forms.Label();
            this.ibtn_User1 = new FontAwesome.Sharp.IconButton();
            this.grp_NguoiKiemKhoTab1 = new System.Windows.Forms.GroupBox();
            this.lbl_TenUesr = new System.Windows.Forms.Label();
            this.lbl_NguoiKiemKho = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grp_ThongTinSP = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.grp_ThucHien = new System.Windows.Forms.GroupBox();
            this.lbl_HangHetHSD = new System.Windows.Forms.Label();
            this.ibtn_XuatFileHSD = new FontAwesome.Sharp.IconButton();
            this.lbl_BaoCaoHang = new System.Windows.Forms.Label();
            this.lbl_HangTrongKho = new System.Windows.Forms.Label();
            this.btn_HienThi = new System.Windows.Forms.Button();
            this.btn_LoaiBo = new System.Windows.Forms.Button();
            this.iBtn_User = new FontAwesome.Sharp.IconButton();
            this.grp_NguoiKiemKho = new System.Windows.Forms.GroupBox();
            this.lbl_HienTen = new System.Windows.Forms.Label();
            this.grp_ThoiGian = new System.Windows.Forms.GroupBox();
            this.lbl_ThoiGianKiem = new System.Windows.Forms.Label();
            this.btn_TatCa = new System.Windows.Forms.Button();
            this.lbl_KetLuan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_KL = new System.Windows.Forms.Label();
            this.tab_KiemKho.SuspendLayout();
            this.tab_TonKho.SuspendLayout();
            this.grp_ThaoTac.SuspendLayout();
            this.grp_XuLi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XuLySanPham)).BeginInit();
            this.grp_ChonSP.SuspendLayout();
            this.grp_ThoiGianTab1.SuspendLayout();
            this.grp_NguoiKiemKhoTab1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grp_ThongTinSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPham)).BeginInit();
            this.grp_ThucHien.SuspendLayout();
            this.grp_NguoiKiemKho.SuspendLayout();
            this.grp_ThoiGian.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_KiemKho
            // 
            this.tab_KiemKho.Controls.Add(this.tab_TonKho);
            this.tab_KiemKho.Controls.Add(this.tabPage2);
            this.tab_KiemKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_KiemKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_KiemKho.Location = new System.Drawing.Point(0, 0);
            this.tab_KiemKho.Name = "tab_KiemKho";
            this.tab_KiemKho.SelectedIndex = 0;
            this.tab_KiemKho.Size = new System.Drawing.Size(1396, 894);
            this.tab_KiemKho.TabIndex = 0;
            // 
            // tab_TonKho
            // 
            this.tab_TonKho.BackColor = System.Drawing.Color.White;
            this.tab_TonKho.Controls.Add(this.groupBox1);
            this.tab_TonKho.Controls.Add(this.grp_ThaoTac);
            this.tab_TonKho.Controls.Add(this.grp_XuLi);
            this.tab_TonKho.Controls.Add(this.grp_ChonSP);
            this.tab_TonKho.Controls.Add(this.grp_ThoiGianTab1);
            this.tab_TonKho.Controls.Add(this.ibtn_User1);
            this.tab_TonKho.Controls.Add(this.grp_NguoiKiemKhoTab1);
            this.tab_TonKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_TonKho.ForeColor = System.Drawing.Color.Black;
            this.tab_TonKho.Location = new System.Drawing.Point(4, 38);
            this.tab_TonKho.Name = "tab_TonKho";
            this.tab_TonKho.Padding = new System.Windows.Forms.Padding(3);
            this.tab_TonKho.Size = new System.Drawing.Size(1388, 852);
            this.tab_TonKho.TabIndex = 0;
            this.tab_TonKho.Text = "Kiểm tra hàng tồn kho   ";
            // 
            // grp_ThaoTac
            // 
            this.grp_ThaoTac.Controls.Add(this.btn_Huy);
            this.grp_ThaoTac.Controls.Add(this.btn_Xoa);
            this.grp_ThaoTac.Controls.Add(this.btn_CanBangKho);
            this.grp_ThaoTac.Controls.Add(this.btn_XuatFile);
            this.grp_ThaoTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThaoTac.Location = new System.Drawing.Point(1072, 17);
            this.grp_ThaoTac.Name = "grp_ThaoTac";
            this.grp_ThaoTac.Size = new System.Drawing.Size(260, 210);
            this.grp_ThaoTac.TabIndex = 23;
            this.grp_ThaoTac.TabStop = false;
            this.grp_ThaoTac.Text = "Thao tác";
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(136, 29);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(95, 50);
            this.btn_Huy.TabIndex = 22;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(35, 29);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(95, 50);
            this.btn_Xoa.TabIndex = 21;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_CanBangKho
            // 
            this.btn_CanBangKho.ForeColor = System.Drawing.Color.Black;
            this.btn_CanBangKho.Location = new System.Drawing.Point(35, 89);
            this.btn_CanBangKho.Name = "btn_CanBangKho";
            this.btn_CanBangKho.Size = new System.Drawing.Size(196, 50);
            this.btn_CanBangKho.TabIndex = 19;
            this.btn_CanBangKho.Text = "Cân bằng kho";
            this.btn_CanBangKho.UseVisualStyleBackColor = true;
            this.btn_CanBangKho.Click += new System.EventHandler(this.btn_CanBangKho_Click);
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.ForeColor = System.Drawing.Color.Black;
            this.btn_XuatFile.Location = new System.Drawing.Point(35, 149);
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.Size = new System.Drawing.Size(196, 50);
            this.btn_XuatFile.TabIndex = 20;
            this.btn_XuatFile.Text = "Xuất file";
            this.btn_XuatFile.UseVisualStyleBackColor = true;
            this.btn_XuatFile.Click += new System.EventHandler(this.btn_XuatFile_Click);
            // 
            // lbl_TongChiPhi
            // 
            this.lbl_TongChiPhi.AutoSize = true;
            this.lbl_TongChiPhi.ForeColor = System.Drawing.Color.Black;
            this.lbl_TongChiPhi.Location = new System.Drawing.Point(16, 64);
            this.lbl_TongChiPhi.Name = "lbl_TongChiPhi";
            this.lbl_TongChiPhi.Size = new System.Drawing.Size(225, 25);
            this.lbl_TongChiPhi.TabIndex = 22;
            this.lbl_TongChiPhi.Text = "Tổng chi phí chênh lệch:";
            // 
            // lbl_TongSL
            // 
            this.lbl_TongSL.AutoSize = true;
            this.lbl_TongSL.ForeColor = System.Drawing.Color.Black;
            this.lbl_TongSL.Location = new System.Drawing.Point(16, 34);
            this.lbl_TongSL.Name = "lbl_TongSL";
            this.lbl_TongSL.Size = new System.Drawing.Size(184, 25);
            this.lbl_TongSL.TabIndex = 21;
            this.lbl_TongSL.Text = "Tổng số lượng lệch:";
            // 
            // lbl_TongSLLech
            // 
            this.lbl_TongSLLech.AutoSize = true;
            this.lbl_TongSLLech.ForeColor = System.Drawing.Color.Black;
            this.lbl_TongSLLech.Location = new System.Drawing.Point(329, 34);
            this.lbl_TongSLLech.Name = "lbl_TongSLLech";
            this.lbl_TongSLLech.Size = new System.Drawing.Size(23, 25);
            this.lbl_TongSLLech.TabIndex = 0;
            this.lbl_TongSLLech.Text = "0";
            // 
            // lbl_TongChiPhiLech
            // 
            this.lbl_TongChiPhiLech.AutoSize = true;
            this.lbl_TongChiPhiLech.ForeColor = System.Drawing.Color.Black;
            this.lbl_TongChiPhiLech.Location = new System.Drawing.Point(329, 64);
            this.lbl_TongChiPhiLech.Name = "lbl_TongChiPhiLech";
            this.lbl_TongChiPhiLech.Size = new System.Drawing.Size(70, 25);
            this.lbl_TongChiPhiLech.TabIndex = 1;
            this.lbl_TongChiPhiLech.Text = "0 VNĐ";
            // 
            // grp_XuLi
            // 
            this.grp_XuLi.BackColor = System.Drawing.Color.Transparent;
            this.grp_XuLi.Controls.Add(this.dgv_XuLySanPham);
            this.grp_XuLi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_XuLi.Location = new System.Drawing.Point(18, 223);
            this.grp_XuLi.Name = "grp_XuLi";
            this.grp_XuLi.Size = new System.Drawing.Size(1347, 584);
            this.grp_XuLi.TabIndex = 17;
            this.grp_XuLi.TabStop = false;
            this.grp_XuLi.Text = "Xử lý";
            // 
            // dgv_XuLySanPham
            // 
            this.dgv_XuLySanPham.AllowUserToAddRows = false;
            this.dgv_XuLySanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_XuLySanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_XuLySanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgv_XuLySanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_XuLySanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_XuLySanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSp,
            this.TenSP,
            this.GBan,
            this.SLTonKho,
            this.SLThucTe,
            this.SLLech,
            this.GiaTriLech,
            this.XuHuong,
            this.TrangThai});
            this.dgv_XuLySanPham.GridColor = System.Drawing.Color.Black;
            this.dgv_XuLySanPham.Location = new System.Drawing.Point(18, 36);
            this.dgv_XuLySanPham.Name = "dgv_XuLySanPham";
            this.dgv_XuLySanPham.RowHeadersWidth = 51;
            this.dgv_XuLySanPham.RowTemplate.Height = 24;
            this.dgv_XuLySanPham.Size = new System.Drawing.Size(1317, 524);
            this.dgv_XuLySanPham.TabIndex = 0;
            this.dgv_XuLySanPham.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_XuLySanPham_CellEndEdit);
            // 
            // MaSp
            // 
            this.MaSp.HeaderText = "Mã Sản Phẩm";
            this.MaSp.MinimumWidth = 6;
            this.MaSp.Name = "MaSp";
            this.MaSp.ReadOnly = true;
            this.MaSp.Width = 144;
            // 
            // TenSP
            // 
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 151;
            // 
            // GBan
            // 
            this.GBan.HeaderText = "Giá bán";
            this.GBan.MinimumWidth = 6;
            this.GBan.Name = "GBan";
            this.GBan.ReadOnly = true;
            this.GBan.Width = 96;
            // 
            // SLTonKho
            // 
            this.SLTonKho.HeaderText = "Số lượng tồn kho";
            this.SLTonKho.MinimumWidth = 6;
            this.SLTonKho.Name = "SLTonKho";
            this.SLTonKho.ReadOnly = true;
            this.SLTonKho.Width = 138;
            // 
            // SLThucTe
            // 
            this.SLThucTe.HeaderText = "Số lượng thực tế";
            this.SLThucTe.MinimumWidth = 6;
            this.SLThucTe.Name = "SLThucTe";
            this.SLThucTe.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SLThucTe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SLThucTe.Width = 124;
            // 
            // SLLech
            // 
            this.SLLech.HeaderText = "Số lượng lệch";
            this.SLLech.MinimumWidth = 6;
            this.SLLech.Name = "SLLech";
            this.SLLech.ReadOnly = true;
            this.SLLech.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SLLech.Width = 120;
            // 
            // GiaTriLech
            // 
            this.GiaTriLech.HeaderText = "Giá trị lệch";
            this.GiaTriLech.MinimumWidth = 6;
            this.GiaTriLech.Name = "GiaTriLech";
            this.GiaTriLech.ReadOnly = true;
            this.GiaTriLech.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GiaTriLech.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GiaTriLech.Width = 94;
            // 
            // XuHuong
            // 
            this.XuHuong.HeaderText = "Xu hướng lệch";
            this.XuHuong.MinimumWidth = 6;
            this.XuHuong.Name = "XuHuong";
            this.XuHuong.ReadOnly = true;
            this.XuHuong.Width = 151;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            this.TrangThai.Width = 113;
            // 
            // grp_ChonSP
            // 
            this.grp_ChonSP.BackColor = System.Drawing.Color.White;
            this.grp_ChonSP.Controls.Add(this.btn_TatCa);
            this.grp_ChonSP.Controls.Add(this.cbo_SanPham);
            this.grp_ChonSP.ForeColor = System.Drawing.Color.Black;
            this.grp_ChonSP.Location = new System.Drawing.Point(102, 131);
            this.grp_ChonSP.Name = "grp_ChonSP";
            this.grp_ChonSP.Size = new System.Drawing.Size(383, 85);
            this.grp_ChonSP.TabIndex = 16;
            this.grp_ChonSP.TabStop = false;
            this.grp_ChonSP.Text = "Chọn sản phẩm";
            // 
            // cbo_SanPham
            // 
            this.cbo_SanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_SanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_SanPham.FormattingEnabled = true;
            this.cbo_SanPham.Location = new System.Drawing.Point(6, 35);
            this.cbo_SanPham.Name = "cbo_SanPham";
            this.cbo_SanPham.Size = new System.Drawing.Size(251, 37);
            this.cbo_SanPham.TabIndex = 0;
            this.cbo_SanPham.SelectedIndexChanged += new System.EventHandler(this.cbo_SanPham_SelectedIndexChanged);
            // 
            // grp_ThoiGianTab1
            // 
            this.grp_ThoiGianTab1.BackColor = System.Drawing.Color.White;
            this.grp_ThoiGianTab1.Controls.Add(this.lbl_ThoiGianTab1);
            this.grp_ThoiGianTab1.Controls.Add(this.lbl_ThoiGian);
            this.grp_ThoiGianTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ThoiGianTab1.ForeColor = System.Drawing.Color.Black;
            this.grp_ThoiGianTab1.Location = new System.Drawing.Point(388, 17);
            this.grp_ThoiGianTab1.Name = "grp_ThoiGianTab1";
            this.grp_ThoiGianTab1.Size = new System.Drawing.Size(333, 74);
            this.grp_ThoiGianTab1.TabIndex = 15;
            this.grp_ThoiGianTab1.TabStop = false;
            this.grp_ThoiGianTab1.Text = "Thời gian kiểm kho";
            // 
            // lbl_ThoiGianTab1
            // 
            this.lbl_ThoiGianTab1.AutoSize = true;
            this.lbl_ThoiGianTab1.Location = new System.Drawing.Point(15, 32);
            this.lbl_ThoiGianTab1.Name = "lbl_ThoiGianTab1";
            this.lbl_ThoiGianTab1.Size = new System.Drawing.Size(0, 25);
            this.lbl_ThoiGianTab1.TabIndex = 9;
            // 
            // lbl_ThoiGian
            // 
            this.lbl_ThoiGian.AutoSize = true;
            this.lbl_ThoiGian.Location = new System.Drawing.Point(21, 32);
            this.lbl_ThoiGian.Name = "lbl_ThoiGian";
            this.lbl_ThoiGian.Size = new System.Drawing.Size(0, 25);
            this.lbl_ThoiGian.TabIndex = 8;
            // 
            // ibtn_User1
            // 
            this.ibtn_User1.FlatAppearance.BorderSize = 0;
            this.ibtn_User1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_User1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ibtn_User1.IconColor = System.Drawing.Color.Black;
            this.ibtn_User1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_User1.IconSize = 70;
            this.ibtn_User1.Location = new System.Drawing.Point(7, 20);
            this.ibtn_User1.Name = "ibtn_User1";
            this.ibtn_User1.Size = new System.Drawing.Size(89, 83);
            this.ibtn_User1.TabIndex = 14;
            this.ibtn_User1.UseVisualStyleBackColor = true;
            // 
            // grp_NguoiKiemKhoTab1
            // 
            this.grp_NguoiKiemKhoTab1.BackColor = System.Drawing.Color.White;
            this.grp_NguoiKiemKhoTab1.Controls.Add(this.lbl_TenUesr);
            this.grp_NguoiKiemKhoTab1.Controls.Add(this.lbl_NguoiKiemKho);
            this.grp_NguoiKiemKhoTab1.ForeColor = System.Drawing.Color.Black;
            this.grp_NguoiKiemKhoTab1.Location = new System.Drawing.Point(102, 15);
            this.grp_NguoiKiemKhoTab1.Name = "grp_NguoiKiemKhoTab1";
            this.grp_NguoiKiemKhoTab1.Size = new System.Drawing.Size(280, 76);
            this.grp_NguoiKiemKhoTab1.TabIndex = 13;
            this.grp_NguoiKiemKhoTab1.TabStop = false;
            this.grp_NguoiKiemKhoTab1.Text = "Người kiểm kho";
            // 
            // lbl_TenUesr
            // 
            this.lbl_TenUesr.AutoSize = true;
            this.lbl_TenUesr.Location = new System.Drawing.Point(15, 32);
            this.lbl_TenUesr.Name = "lbl_TenUesr";
            this.lbl_TenUesr.Size = new System.Drawing.Size(0, 25);
            this.lbl_TenUesr.TabIndex = 10;
            // 
            // lbl_NguoiKiemKho
            // 
            this.lbl_NguoiKiemKho.AutoSize = true;
            this.lbl_NguoiKiemKho.ForeColor = System.Drawing.Color.White;
            this.lbl_NguoiKiemKho.Location = new System.Drawing.Point(24, 32);
            this.lbl_NguoiKiemKho.Name = "lbl_NguoiKiemKho";
            this.lbl_NguoiKiemKho.Size = new System.Drawing.Size(0, 25);
            this.lbl_NguoiKiemKho.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.grp_ThongTinSP);
            this.tabPage2.Controls.Add(this.grp_ThucHien);
            this.tabPage2.Controls.Add(this.iBtn_User);
            this.tabPage2.Controls.Add(this.grp_NguoiKiemKho);
            this.tabPage2.Controls.Add(this.grp_ThoiGian);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1388, 852);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kiểm tra hàng hết hạn";
            // 
            // grp_ThongTinSP
            // 
            this.grp_ThongTinSP.Controls.Add(this.dgv_DanhSachSanPham);
            this.grp_ThongTinSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grp_ThongTinSP.ForeColor = System.Drawing.Color.Black;
            this.grp_ThongTinSP.Location = new System.Drawing.Point(3, 359);
            this.grp_ThongTinSP.Name = "grp_ThongTinSP";
            this.grp_ThongTinSP.Size = new System.Drawing.Size(1382, 490);
            this.grp_ThongTinSP.TabIndex = 14;
            this.grp_ThongTinSP.TabStop = false;
            this.grp_ThongTinSP.Text = "Thông tin sản phẩm trong kho";
            // 
            // dgv_DanhSachSanPham
            // 
            this.dgv_DanhSachSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_DanhSachSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DanhSachSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_DanhSachSanPham.GridColor = System.Drawing.Color.Silver;
            this.dgv_DanhSachSanPham.Location = new System.Drawing.Point(3, 53);
            this.dgv_DanhSachSanPham.Name = "dgv_DanhSachSanPham";
            this.dgv_DanhSachSanPham.ReadOnly = true;
            this.dgv_DanhSachSanPham.RowHeadersWidth = 51;
            this.dgv_DanhSachSanPham.RowTemplate.Height = 24;
            this.dgv_DanhSachSanPham.Size = new System.Drawing.Size(1376, 434);
            this.dgv_DanhSachSanPham.TabIndex = 0;
            // 
            // grp_ThucHien
            // 
            this.grp_ThucHien.Controls.Add(this.lbl_HangHetHSD);
            this.grp_ThucHien.Controls.Add(this.ibtn_XuatFileHSD);
            this.grp_ThucHien.Controls.Add(this.lbl_BaoCaoHang);
            this.grp_ThucHien.Controls.Add(this.lbl_HangTrongKho);
            this.grp_ThucHien.Controls.Add(this.btn_HienThi);
            this.grp_ThucHien.Controls.Add(this.btn_LoaiBo);
            this.grp_ThucHien.ForeColor = System.Drawing.Color.Black;
            this.grp_ThucHien.Location = new System.Drawing.Point(103, 101);
            this.grp_ThucHien.Name = "grp_ThucHien";
            this.grp_ThucHien.Size = new System.Drawing.Size(691, 197);
            this.grp_ThucHien.TabIndex = 13;
            this.grp_ThucHien.TabStop = false;
            this.grp_ThucHien.Text = "Thực hiện";
            // 
            // lbl_HangHetHSD
            // 
            this.lbl_HangHetHSD.AutoSize = true;
            this.lbl_HangHetHSD.ForeColor = System.Drawing.Color.Black;
            this.lbl_HangHetHSD.Location = new System.Drawing.Point(24, 99);
            this.lbl_HangHetHSD.Name = "lbl_HangHetHSD";
            this.lbl_HangHetHSD.Size = new System.Drawing.Size(237, 25);
            this.lbl_HangHetHSD.TabIndex = 6;
            this.lbl_HangHetHSD.Text = "Hàng đã hết hạn sử dụng:";
            // 
            // ibtn_XuatFileHSD
            // 
            this.ibtn_XuatFileHSD.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtn_XuatFileHSD.IconColor = System.Drawing.Color.Black;
            this.ibtn_XuatFileHSD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_XuatFileHSD.Location = new System.Drawing.Point(531, 140);
            this.ibtn_XuatFileHSD.Name = "ibtn_XuatFileHSD";
            this.ibtn_XuatFileHSD.Size = new System.Drawing.Size(140, 45);
            this.ibtn_XuatFileHSD.TabIndex = 11;
            this.ibtn_XuatFileHSD.Text = "Xuất file";
            this.ibtn_XuatFileHSD.UseVisualStyleBackColor = true;
            this.ibtn_XuatFileHSD.Click += new System.EventHandler(this.ibtn_XuatFileHSD_Click);
            // 
            // lbl_BaoCaoHang
            // 
            this.lbl_BaoCaoHang.AutoSize = true;
            this.lbl_BaoCaoHang.ForeColor = System.Drawing.Color.Black;
            this.lbl_BaoCaoHang.Location = new System.Drawing.Point(24, 153);
            this.lbl_BaoCaoHang.Name = "lbl_BaoCaoHang";
            this.lbl_BaoCaoHang.Size = new System.Drawing.Size(362, 25);
            this.lbl_BaoCaoHang.TabIndex = 8;
            this.lbl_BaoCaoHang.Text = "Xuất báo cáo kiểm tra hàng đã hết HSD:";
            // 
            // lbl_HangTrongKho
            // 
            this.lbl_HangTrongKho.AutoSize = true;
            this.lbl_HangTrongKho.ForeColor = System.Drawing.Color.Black;
            this.lbl_HangTrongKho.Location = new System.Drawing.Point(24, 45);
            this.lbl_HangTrongKho.Name = "lbl_HangTrongKho";
            this.lbl_HangTrongKho.Size = new System.Drawing.Size(151, 25);
            this.lbl_HangTrongKho.TabIndex = 4;
            this.lbl_HangTrongKho.Text = "Hàng trong kho:";
            // 
            // btn_HienThi
            // 
            this.btn_HienThi.FlatAppearance.BorderSize = 0;
            this.btn_HienThi.ForeColor = System.Drawing.Color.Black;
            this.btn_HienThi.Location = new System.Drawing.Point(531, 35);
            this.btn_HienThi.Name = "btn_HienThi";
            this.btn_HienThi.Size = new System.Drawing.Size(140, 45);
            this.btn_HienThi.TabIndex = 5;
            this.btn_HienThi.Text = "Hiển thị";
            this.btn_HienThi.UseVisualStyleBackColor = true;
            this.btn_HienThi.Click += new System.EventHandler(this.btn_HienThi_Click);
            // 
            // btn_LoaiBo
            // 
            this.btn_LoaiBo.ForeColor = System.Drawing.Color.Black;
            this.btn_LoaiBo.Location = new System.Drawing.Point(531, 89);
            this.btn_LoaiBo.Name = "btn_LoaiBo";
            this.btn_LoaiBo.Size = new System.Drawing.Size(140, 45);
            this.btn_LoaiBo.TabIndex = 7;
            this.btn_LoaiBo.Text = "Loại bỏ";
            this.btn_LoaiBo.UseVisualStyleBackColor = true;
            this.btn_LoaiBo.Click += new System.EventHandler(this.btn_LoaiBo_Click);
            // 
            // iBtn_User
            // 
            this.iBtn_User.FlatAppearance.BorderSize = 0;
            this.iBtn_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtn_User.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iBtn_User.IconColor = System.Drawing.Color.Black;
            this.iBtn_User.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtn_User.IconSize = 70;
            this.iBtn_User.Location = new System.Drawing.Point(8, 24);
            this.iBtn_User.Name = "iBtn_User";
            this.iBtn_User.Size = new System.Drawing.Size(89, 83);
            this.iBtn_User.TabIndex = 12;
            this.iBtn_User.UseVisualStyleBackColor = true;
            // 
            // grp_NguoiKiemKho
            // 
            this.grp_NguoiKiemKho.Controls.Add(this.lbl_HienTen);
            this.grp_NguoiKiemKho.ForeColor = System.Drawing.Color.Black;
            this.grp_NguoiKiemKho.Location = new System.Drawing.Point(103, 19);
            this.grp_NguoiKiemKho.Name = "grp_NguoiKiemKho";
            this.grp_NguoiKiemKho.Size = new System.Drawing.Size(280, 76);
            this.grp_NguoiKiemKho.TabIndex = 11;
            this.grp_NguoiKiemKho.TabStop = false;
            this.grp_NguoiKiemKho.Text = "Người kiểm kho";
            // 
            // lbl_HienTen
            // 
            this.lbl_HienTen.AutoSize = true;
            this.lbl_HienTen.ForeColor = System.Drawing.Color.Black;
            this.lbl_HienTen.Location = new System.Drawing.Point(24, 32);
            this.lbl_HienTen.Name = "lbl_HienTen";
            this.lbl_HienTen.Size = new System.Drawing.Size(0, 25);
            this.lbl_HienTen.TabIndex = 9;
            // 
            // grp_ThoiGian
            // 
            this.grp_ThoiGian.Controls.Add(this.lbl_ThoiGianKiem);
            this.grp_ThoiGian.ForeColor = System.Drawing.Color.Black;
            this.grp_ThoiGian.Location = new System.Drawing.Point(389, 21);
            this.grp_ThoiGian.Name = "grp_ThoiGian";
            this.grp_ThoiGian.Size = new System.Drawing.Size(333, 74);
            this.grp_ThoiGian.TabIndex = 10;
            this.grp_ThoiGian.TabStop = false;
            this.grp_ThoiGian.Text = "Thời gian kiểm kho";
            // 
            // lbl_ThoiGianKiem
            // 
            this.lbl_ThoiGianKiem.AutoSize = true;
            this.lbl_ThoiGianKiem.Location = new System.Drawing.Point(21, 32);
            this.lbl_ThoiGianKiem.Name = "lbl_ThoiGianKiem";
            this.lbl_ThoiGianKiem.Size = new System.Drawing.Size(0, 25);
            this.lbl_ThoiGianKiem.TabIndex = 8;
            // 
            // btn_TatCa
            // 
            this.btn_TatCa.Location = new System.Drawing.Point(263, 29);
            this.btn_TatCa.Name = "btn_TatCa";
            this.btn_TatCa.Size = new System.Drawing.Size(114, 50);
            this.btn_TatCa.TabIndex = 23;
            this.btn_TatCa.Text = "Tất cả";
            this.btn_TatCa.UseVisualStyleBackColor = true;
            this.btn_TatCa.Click += new System.EventHandler(this.btn_TatCa_Click);
            // 
            // lbl_KetLuan
            // 
            this.lbl_KetLuan.AutoSize = true;
            this.lbl_KetLuan.ForeColor = System.Drawing.Color.Black;
            this.lbl_KetLuan.Location = new System.Drawing.Point(16, 94);
            this.lbl_KetLuan.Name = "lbl_KetLuan";
            this.lbl_KetLuan.Size = new System.Drawing.Size(173, 25);
            this.lbl_KetLuan.TabIndex = 24;
            this.lbl_KetLuan.Text = "Kết luận sau kiểm:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_KL);
            this.groupBox1.Controls.Add(this.lbl_TongChiPhiLech);
            this.groupBox1.Controls.Add(this.lbl_TongSLLech);
            this.groupBox1.Controls.Add(this.lbl_KetLuan);
            this.groupBox1.Controls.Add(this.lbl_TongSL);
            this.groupBox1.Controls.Add(this.lbl_TongChiPhi);
            this.groupBox1.Location = new System.Drawing.Point(497, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 130);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kiểm tra hàng tồn";
            // 
            // lbl_KL
            // 
            this.lbl_KL.AutoSize = true;
            this.lbl_KL.ForeColor = System.Drawing.Color.Black;
            this.lbl_KL.Location = new System.Drawing.Point(237, 94);
            this.lbl_KL.Name = "lbl_KL";
            this.lbl_KL.Size = new System.Drawing.Size(0, 25);
            this.lbl_KL.TabIndex = 25;
            // 
            // frm_KiemKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 894);
            this.Controls.Add(this.tab_KiemKho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_KiemKho";
            this.Text = "frm_KiemKho";
            this.tab_KiemKho.ResumeLayout(false);
            this.tab_TonKho.ResumeLayout(false);
            this.grp_ThaoTac.ResumeLayout(false);
            this.grp_XuLi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_XuLySanPham)).EndInit();
            this.grp_ChonSP.ResumeLayout(false);
            this.grp_ThoiGianTab1.ResumeLayout(false);
            this.grp_ThoiGianTab1.PerformLayout();
            this.grp_NguoiKiemKhoTab1.ResumeLayout(false);
            this.grp_NguoiKiemKhoTab1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grp_ThongTinSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPham)).EndInit();
            this.grp_ThucHien.ResumeLayout(false);
            this.grp_ThucHien.PerformLayout();
            this.grp_NguoiKiemKho.ResumeLayout(false);
            this.grp_NguoiKiemKho.PerformLayout();
            this.grp_ThoiGian.ResumeLayout(false);
            this.grp_ThoiGian.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_KiemKho;
        private System.Windows.Forms.TabPage tab_TonKho;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_DanhSachSanPham;
        private System.Windows.Forms.Button btn_LoaiBo;
        private System.Windows.Forms.Label lbl_HangHetHSD;
        private System.Windows.Forms.Button btn_HienThi;
        private System.Windows.Forms.Label lbl_HangTrongKho;
        private System.Windows.Forms.Label lbl_ThoiGianKiem;
        private System.Windows.Forms.Label lbl_HienTen;
        private System.Windows.Forms.GroupBox grp_ThoiGian;
        private System.Windows.Forms.GroupBox grp_NguoiKiemKho;
        private FontAwesome.Sharp.IconButton iBtn_User;
        private System.Windows.Forms.GroupBox grp_ThucHien;
        private System.Windows.Forms.GroupBox grp_ThongTinSP;
        private System.Windows.Forms.Label lbl_BaoCaoHang;
        private System.Windows.Forms.GroupBox grp_ThoiGianTab1;
        private System.Windows.Forms.Label lbl_ThoiGian;
        private FontAwesome.Sharp.IconButton ibtn_User1;
        private System.Windows.Forms.GroupBox grp_NguoiKiemKhoTab1;
        private System.Windows.Forms.Label lbl_TenUesr;
        private System.Windows.Forms.Label lbl_NguoiKiemKho;
        private System.Windows.Forms.Label lbl_ThoiGianTab1;
        private System.Windows.Forms.GroupBox grp_XuLi;
        private System.Windows.Forms.GroupBox grp_ChonSP;
        private System.Windows.Forms.ComboBox cbo_SanPham;
        private System.Windows.Forms.Button btn_XuatFile;
        private System.Windows.Forms.Button btn_CanBangKho;
        private System.Windows.Forms.DataGridView dgv_XuLySanPham;
        private System.Windows.Forms.Label lbl_TongChiPhiLech;
        private System.Windows.Forms.Label lbl_TongSLLech;
        private System.Windows.Forms.Label lbl_TongChiPhi;
        private System.Windows.Forms.Label lbl_TongSL;
        private System.Windows.Forms.GroupBox grp_ThaoTac;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTonKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLThucTe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLLech;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTriLech;
        private System.Windows.Forms.DataGridViewTextBoxColumn XuHuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private FontAwesome.Sharp.IconButton ibtn_XuatFileHSD;
        private System.Windows.Forms.Button btn_TatCa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_KetLuan;
        private System.Windows.Forms.Label lbl_KL;
    }
}