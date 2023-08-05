namespace asm_DangKi
{
    partial class frm_DoiTac
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
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.grp_DsThongTinDoiTac = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_SDT = new System.Windows.Forms.Label();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.lbl_TenDoiTac = new System.Windows.Forms.Label();
            this.lbl_MaDoiTac = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_TenDoiTac = new System.Windows.Forms.TextBox();
            this.txt_MaDoiTac = new System.Windows.Forms.TextBox();
            this.dgv_DanhSach = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grp_DsDoiTac = new System.Windows.Forms.GroupBox();
            this.dgv_DSDTAC = new System.Windows.Forms.DataGridView();
            this.grp_DoiTac = new System.Windows.Forms.GroupBox();
            this.lbl_DoiTac = new System.Windows.Forms.Label();
            this.txt_timDT = new System.Windows.Forms.TextBox();
            this.grp_TimTheo = new System.Windows.Forms.GroupBox();
            this.rdo_sdt = new System.Windows.Forms.RadioButton();
            this.rdo_ten = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rdo_ma = new System.Windows.Forms.RadioButton();
            this.lbl_TieuDe = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grp_DsThongTinDoiTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.grp_DsDoiTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDTAC)).BeginInit();
            this.grp_DoiTac.SuspendLayout();
            this.grp_TimTheo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1426, 755);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btn_xoa);
            this.tabPage1.Controls.Add(this.btn_sua);
            this.tabPage1.Controls.Add(this.btn_them);
            this.tabPage1.Controls.Add(this.grp_DsThongTinDoiTac);
            this.tabPage1.Controls.Add(this.dgv_DanhSach);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 45);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1418, 706);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin đối tác";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_xoa.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(1091, 437);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(165, 81);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sua.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(598, 437);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(228, 81);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Cập nhật";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_them.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(165, 437);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(162, 81);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // grp_DsThongTinDoiTac
            // 
            this.grp_DsThongTinDoiTac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_DsThongTinDoiTac.BackColor = System.Drawing.Color.MediumTurquoise;
            this.grp_DsThongTinDoiTac.Controls.Add(this.pictureBox1);
            this.grp_DsThongTinDoiTac.Controls.Add(this.lbl_Email);
            this.grp_DsThongTinDoiTac.Controls.Add(this.lbl_SDT);
            this.grp_DsThongTinDoiTac.Controls.Add(this.lbl_DiaChi);
            this.grp_DsThongTinDoiTac.Controls.Add(this.lbl_TenDoiTac);
            this.grp_DsThongTinDoiTac.Controls.Add(this.lbl_MaDoiTac);
            this.grp_DsThongTinDoiTac.Controls.Add(this.txt_Email);
            this.grp_DsThongTinDoiTac.Controls.Add(this.txt_SoDienThoai);
            this.grp_DsThongTinDoiTac.Controls.Add(this.txt_DiaChi);
            this.grp_DsThongTinDoiTac.Controls.Add(this.txt_TenDoiTac);
            this.grp_DsThongTinDoiTac.Controls.Add(this.txt_MaDoiTac);
            this.grp_DsThongTinDoiTac.Location = new System.Drawing.Point(0, 534);
            this.grp_DsThongTinDoiTac.Name = "grp_DsThongTinDoiTac";
            this.grp_DsThongTinDoiTac.Size = new System.Drawing.Size(1418, 274);
            this.grp_DsThongTinDoiTac.TabIndex = 2;
            this.grp_DsThongTinDoiTac.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::asm_DangKi.Properties.Resources.handshake;
            this.pictureBox1.Location = new System.Drawing.Point(8, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(852, 129);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(86, 29);
            this.lbl_Email.TabIndex = 34;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(852, 53);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(174, 29);
            this.lbl_SDT.TabIndex = 33;
            this.lbl_SDT.Text = "Số điện thoại:";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(223, 203);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(100, 29);
            this.lbl_DiaChi.TabIndex = 32;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // lbl_TenDoiTac
            // 
            this.lbl_TenDoiTac.AutoSize = true;
            this.lbl_TenDoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDoiTac.Location = new System.Drawing.Point(223, 132);
            this.lbl_TenDoiTac.Name = "lbl_TenDoiTac";
            this.lbl_TenDoiTac.Size = new System.Drawing.Size(151, 29);
            this.lbl_TenDoiTac.TabIndex = 31;
            this.lbl_TenDoiTac.Text = "Tên đối tác:";
            // 
            // lbl_MaDoiTac
            // 
            this.lbl_MaDoiTac.AutoSize = true;
            this.lbl_MaDoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDoiTac.Location = new System.Drawing.Point(223, 56);
            this.lbl_MaDoiTac.Name = "lbl_MaDoiTac";
            this.lbl_MaDoiTac.Size = new System.Drawing.Size(140, 29);
            this.lbl_MaDoiTac.TabIndex = 30;
            this.lbl_MaDoiTac.Text = "Mã đối tác:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(1125, 120);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(274, 35);
            this.txt_Email.TabIndex = 29;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Location = new System.Drawing.Point(1125, 44);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(274, 35);
            this.txt_SoDienThoai.TabIndex = 28;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(461, 191);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(339, 35);
            this.txt_DiaChi.TabIndex = 27;
            // 
            // txt_TenDoiTac
            // 
            this.txt_TenDoiTac.Location = new System.Drawing.Point(461, 117);
            this.txt_TenDoiTac.Name = "txt_TenDoiTac";
            this.txt_TenDoiTac.Size = new System.Drawing.Size(339, 35);
            this.txt_TenDoiTac.TabIndex = 26;
            // 
            // txt_MaDoiTac
            // 
            this.txt_MaDoiTac.Location = new System.Drawing.Point(461, 50);
            this.txt_MaDoiTac.Name = "txt_MaDoiTac";
            this.txt_MaDoiTac.Size = new System.Drawing.Size(339, 35);
            this.txt_MaDoiTac.TabIndex = 25;
            // 
            // dgv_DanhSach
            // 
            this.dgv_DanhSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_DanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSach.Location = new System.Drawing.Point(64, 46);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            this.dgv_DanhSach.RowHeadersWidth = 62;
            this.dgv_DanhSach.RowTemplate.Height = 28;
            this.dgv_DanhSach.Size = new System.Drawing.Size(1285, 363);
            this.dgv_DanhSach.TabIndex = 1;
            this.dgv_DanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSach_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, -34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH ĐỐI TÁC ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.grp_DsDoiTac);
            this.tabPage2.Controls.Add(this.grp_DoiTac);
            this.tabPage2.Controls.Add(this.grp_TimTheo);
            this.tabPage2.Controls.Add(this.lbl_TieuDe);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 45);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1418, 706);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm kiếm thông tin đối tác";
            // 
            // grp_DsDoiTac
            // 
            this.grp_DsDoiTac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_DsDoiTac.BackColor = System.Drawing.Color.MediumTurquoise;
            this.grp_DsDoiTac.Controls.Add(this.dgv_DSDTAC);
            this.grp_DsDoiTac.Location = new System.Drawing.Point(61, 305);
            this.grp_DsDoiTac.Name = "grp_DsDoiTac";
            this.grp_DsDoiTac.Size = new System.Drawing.Size(1295, 501);
            this.grp_DsDoiTac.TabIndex = 13;
            this.grp_DsDoiTac.TabStop = false;
            this.grp_DsDoiTac.Text = "Danh sách Đối tác";
            // 
            // dgv_DSDTAC
            // 
            this.dgv_DSDTAC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DSDTAC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_DSDTAC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DSDTAC.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DSDTAC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSDTAC.Location = new System.Drawing.Point(6, 52);
            this.dgv_DSDTAC.Name = "dgv_DSDTAC";
            this.dgv_DSDTAC.RowHeadersWidth = 62;
            this.dgv_DSDTAC.RowTemplate.Height = 28;
            this.dgv_DSDTAC.Size = new System.Drawing.Size(1284, 444);
            this.dgv_DSDTAC.TabIndex = 10;
            // 
            // grp_DoiTac
            // 
            this.grp_DoiTac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_DoiTac.BackColor = System.Drawing.Color.MediumTurquoise;
            this.grp_DoiTac.Controls.Add(this.lbl_DoiTac);
            this.grp_DoiTac.Controls.Add(this.txt_timDT);
            this.grp_DoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_DoiTac.Location = new System.Drawing.Point(61, 72);
            this.grp_DoiTac.Name = "grp_DoiTac";
            this.grp_DoiTac.Size = new System.Drawing.Size(606, 198);
            this.grp_DoiTac.TabIndex = 12;
            this.grp_DoiTac.TabStop = false;
            this.grp_DoiTac.Text = "Đối tác cần tìm";
            // 
            // lbl_DoiTac
            // 
            this.lbl_DoiTac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DoiTac.AutoSize = true;
            this.lbl_DoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoiTac.Location = new System.Drawing.Point(225, 40);
            this.lbl_DoiTac.Name = "lbl_DoiTac";
            this.lbl_DoiTac.Size = new System.Drawing.Size(118, 32);
            this.lbl_DoiTac.TabIndex = 1;
            this.lbl_DoiTac.Text = "Đối tác:";
            // 
            // txt_timDT
            // 
            this.txt_timDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_timDT.Enabled = false;
            this.txt_timDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timDT.Location = new System.Drawing.Point(106, 110);
            this.txt_timDT.Multiline = true;
            this.txt_timDT.Name = "txt_timDT";
            this.txt_timDT.Size = new System.Drawing.Size(384, 50);
            this.txt_timDT.TabIndex = 0;
            this.txt_timDT.TextChanged += new System.EventHandler(this.txt_timDT_TextChanged);
            // 
            // grp_TimTheo
            // 
            this.grp_TimTheo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_TimTheo.BackColor = System.Drawing.Color.MediumTurquoise;
            this.grp_TimTheo.Controls.Add(this.rdo_sdt);
            this.grp_TimTheo.Controls.Add(this.rdo_ten);
            this.grp_TimTheo.Controls.Add(this.pictureBox2);
            this.grp_TimTheo.Controls.Add(this.rdo_ma);
            this.grp_TimTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_TimTheo.Location = new System.Drawing.Point(694, 72);
            this.grp_TimTheo.Name = "grp_TimTheo";
            this.grp_TimTheo.Size = new System.Drawing.Size(657, 198);
            this.grp_TimTheo.TabIndex = 11;
            this.grp_TimTheo.TabStop = false;
            this.grp_TimTheo.Text = "Bạn muốn tìm theo?";
            // 
            // rdo_sdt
            // 
            this.rdo_sdt.AutoSize = true;
            this.rdo_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_sdt.Location = new System.Drawing.Point(219, 131);
            this.rdo_sdt.Name = "rdo_sdt";
            this.rdo_sdt.Size = new System.Drawing.Size(164, 29);
            this.rdo_sdt.TabIndex = 3;
            this.rdo_sdt.TabStop = true;
            this.rdo_sdt.Text = "Số điện thoại";
            this.rdo_sdt.UseVisualStyleBackColor = true;
            this.rdo_sdt.CheckedChanged += new System.EventHandler(this.rdo_sdt_CheckedChanged);
            // 
            // rdo_ten
            // 
            this.rdo_ten.AutoSize = true;
            this.rdo_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_ten.Location = new System.Drawing.Point(439, 56);
            this.rdo_ten.Name = "rdo_ten";
            this.rdo_ten.Size = new System.Drawing.Size(137, 29);
            this.rdo_ten.TabIndex = 2;
            this.rdo_ten.TabStop = true;
            this.rdo_ten.Text = "Họ và Tên";
            this.rdo_ten.UseVisualStyleBackColor = true;
            this.rdo_ten.CheckedChanged += new System.EventHandler(this.rdo_ten_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::asm_DangKi.Properties.Resources.handshake;
            this.pictureBox2.Location = new System.Drawing.Point(30, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // rdo_ma
            // 
            this.rdo_ma.AutoSize = true;
            this.rdo_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_ma.Location = new System.Drawing.Point(219, 56);
            this.rdo_ma.Name = "rdo_ma";
            this.rdo_ma.Size = new System.Drawing.Size(73, 29);
            this.rdo_ma.TabIndex = 0;
            this.rdo_ma.TabStop = true;
            this.rdo_ma.Text = "Mã ";
            this.rdo_ma.UseVisualStyleBackColor = true;
            this.rdo_ma.CheckedChanged += new System.EventHandler(this.rdo_ma_CheckedChanged);
            // 
            // lbl_TieuDe
            // 
            this.lbl_TieuDe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_TieuDe.AutoSize = true;
            this.lbl_TieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TieuDe.Location = new System.Drawing.Point(485, -27);
            this.lbl_TieuDe.Name = "lbl_TieuDe";
            this.lbl_TieuDe.Size = new System.Drawing.Size(290, 36);
            this.lbl_TieuDe.TabIndex = 5;
            this.lbl_TieuDe.Text = "TÌM KIẾM ĐỐI TÁC";
            // 
            // frm_DoiTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 755);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_DoiTac";
            this.Text = "frm_DoiTac";
            this.Load += new System.EventHandler(this.frm_DoiTac_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grp_DsThongTinDoiTac.ResumeLayout(false);
            this.grp_DsThongTinDoiTac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grp_DsDoiTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDTAC)).EndInit();
            this.grp_DoiTac.ResumeLayout(false);
            this.grp_DoiTac.PerformLayout();
            this.grp_TimTheo.ResumeLayout(false);
            this.grp_TimTheo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grp_DsThongTinDoiTac;
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_SDT;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.Label lbl_TenDoiTac;
        private System.Windows.Forms.Label lbl_MaDoiTac;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_TenDoiTac;
        private System.Windows.Forms.TextBox txt_MaDoiTac;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label lbl_TieuDe;
        private System.Windows.Forms.Label lbl_DoiTac;
        private System.Windows.Forms.TextBox txt_timDT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgv_DSDTAC;
        private System.Windows.Forms.GroupBox grp_TimTheo;
        private System.Windows.Forms.RadioButton rdo_sdt;
        private System.Windows.Forms.RadioButton rdo_ten;
        private System.Windows.Forms.RadioButton rdo_ma;
        private System.Windows.Forms.GroupBox grp_DoiTac;
        private System.Windows.Forms.GroupBox grp_DsDoiTac;
    }
}