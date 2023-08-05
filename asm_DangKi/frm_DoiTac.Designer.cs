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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DoiTac));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.grp_DsThongTinDoiTac = new System.Windows.Forms.GroupBox();
            this.pic_DoiTac = new System.Windows.Forms.PictureBox();
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
            this.lbl_DanhSachDoiTac = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grp_DsDoiTac = new System.Windows.Forms.GroupBox();
            this.dgv_DSDTAC = new System.Windows.Forms.DataGridView();
            this.grp_DoiTac = new System.Windows.Forms.GroupBox();
            this.lbl_DoiTac = new System.Windows.Forms.Label();
            this.txt_timDT = new System.Windows.Forms.TextBox();
            this.grp_TimTheo = new System.Windows.Forms.GroupBox();
            this.rdo_sdt = new System.Windows.Forms.RadioButton();
            this.rdo_ten = new System.Windows.Forms.RadioButton();
            this.pic_DT = new System.Windows.Forms.PictureBox();
            this.rdo_ma = new System.Windows.Forms.RadioButton();
            this.lbl_TieuDe = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grp_DsThongTinDoiTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DoiTac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.grp_DsDoiTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDTAC)).BeginInit();
            this.grp_DoiTac.SuspendLayout();
            this.grp_TimTheo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DT)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1307, 837);
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
            this.tabPage1.Controls.Add(this.lbl_DanhSachDoiTac);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1299, 795);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin đối tác";
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_xoa.BackColor = System.Drawing.Color.White;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(989, 466);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(147, 65);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sua.BackColor = System.Drawing.Color.White;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(551, 466);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(203, 65);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Cập nhật";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_them.BackColor = System.Drawing.Color.White;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(166, 466);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(144, 65);
            this.btn_them.TabIndex = 3;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // grp_DsThongTinDoiTac
            // 
            this.grp_DsThongTinDoiTac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_DsThongTinDoiTac.BackColor = System.Drawing.Color.White;
            this.grp_DsThongTinDoiTac.Controls.Add(this.pic_DoiTac);
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
            this.grp_DsThongTinDoiTac.Location = new System.Drawing.Point(19, 543);
            this.grp_DsThongTinDoiTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_DsThongTinDoiTac.Name = "grp_DsThongTinDoiTac";
            this.grp_DsThongTinDoiTac.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_DsThongTinDoiTac.Size = new System.Drawing.Size(1260, 219);
            this.grp_DsThongTinDoiTac.TabIndex = 2;
            this.grp_DsThongTinDoiTac.TabStop = false;
            // 
            // pic_DoiTac
            // 
            this.pic_DoiTac.Image = ((System.Drawing.Image)(resources.GetObject("pic_DoiTac.Image")));
            this.pic_DoiTac.Location = new System.Drawing.Point(7, 32);
            this.pic_DoiTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_DoiTac.Name = "pic_DoiTac";
            this.pic_DoiTac.Size = new System.Drawing.Size(188, 164);
            this.pic_DoiTac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_DoiTac.TabIndex = 35;
            this.pic_DoiTac.TabStop = false;
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email.Location = new System.Drawing.Point(757, 103);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(72, 25);
            this.lbl_Email.TabIndex = 34;
            this.lbl_Email.Text = "Email:";
            // 
            // lbl_SDT
            // 
            this.lbl_SDT.AutoSize = true;
            this.lbl_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SDT.Location = new System.Drawing.Point(757, 42);
            this.lbl_SDT.Name = "lbl_SDT";
            this.lbl_SDT.Size = new System.Drawing.Size(146, 25);
            this.lbl_SDT.TabIndex = 33;
            this.lbl_SDT.Text = "Số điện thoại:";
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChi.Location = new System.Drawing.Point(198, 162);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(85, 25);
            this.lbl_DiaChi.TabIndex = 32;
            this.lbl_DiaChi.Text = "Địa chỉ:";
            // 
            // lbl_TenDoiTac
            // 
            this.lbl_TenDoiTac.AutoSize = true;
            this.lbl_TenDoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDoiTac.Location = new System.Drawing.Point(198, 106);
            this.lbl_TenDoiTac.Name = "lbl_TenDoiTac";
            this.lbl_TenDoiTac.Size = new System.Drawing.Size(127, 25);
            this.lbl_TenDoiTac.TabIndex = 31;
            this.lbl_TenDoiTac.Text = "Tên đối tác:";
            // 
            // lbl_MaDoiTac
            // 
            this.lbl_MaDoiTac.AutoSize = true;
            this.lbl_MaDoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaDoiTac.Location = new System.Drawing.Point(198, 45);
            this.lbl_MaDoiTac.Name = "lbl_MaDoiTac";
            this.lbl_MaDoiTac.Size = new System.Drawing.Size(119, 25);
            this.lbl_MaDoiTac.TabIndex = 30;
            this.lbl_MaDoiTac.Text = "Mã đối tác:";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(1000, 96);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(244, 30);
            this.txt_Email.TabIndex = 29;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Location = new System.Drawing.Point(1000, 35);
            this.txt_SoDienThoai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(244, 30);
            this.txt_SoDienThoai.TabIndex = 28;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(410, 153);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(302, 30);
            this.txt_DiaChi.TabIndex = 27;
            // 
            // txt_TenDoiTac
            // 
            this.txt_TenDoiTac.Location = new System.Drawing.Point(410, 94);
            this.txt_TenDoiTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TenDoiTac.Name = "txt_TenDoiTac";
            this.txt_TenDoiTac.Size = new System.Drawing.Size(302, 30);
            this.txt_TenDoiTac.TabIndex = 26;
            // 
            // txt_MaDoiTac
            // 
            this.txt_MaDoiTac.Location = new System.Drawing.Point(410, 40);
            this.txt_MaDoiTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_MaDoiTac.Name = "txt_MaDoiTac";
            this.txt_MaDoiTac.Size = new System.Drawing.Size(302, 30);
            this.txt_MaDoiTac.TabIndex = 25;
            // 
            // dgv_DanhSach
            // 
            this.dgv_DanhSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_DanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_DanhSach.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSach.Location = new System.Drawing.Point(166, 153);
            this.dgv_DanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_DanhSach.Name = "dgv_DanhSach";
            this.dgv_DanhSach.RowHeadersWidth = 62;
            this.dgv_DanhSach.RowTemplate.Height = 28;
            this.dgv_DanhSach.Size = new System.Drawing.Size(1105, 290);
            this.dgv_DanhSach.TabIndex = 1;
            this.dgv_DanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSach_CellClick);
            // 
            // lbl_DanhSachDoiTac
            // 
            this.lbl_DanhSachDoiTac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DanhSachDoiTac.AutoSize = true;
            this.lbl_DanhSachDoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DanhSachDoiTac.Location = new System.Drawing.Point(428, 89);
            this.lbl_DanhSachDoiTac.Name = "lbl_DanhSachDoiTac";
            this.lbl_DanhSachDoiTac.Size = new System.Drawing.Size(293, 29);
            this.lbl_DanhSachDoiTac.TabIndex = 0;
            this.lbl_DanhSachDoiTac.Text = "DANH SÁCH ĐỐI TÁC ";
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
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1299, 795);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm kiếm thông tin đối tác";
            // 
            // grp_DsDoiTac
            // 
            this.grp_DsDoiTac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_DsDoiTac.BackColor = System.Drawing.Color.White;
            this.grp_DsDoiTac.Controls.Add(this.dgv_DSDTAC);
            this.grp_DsDoiTac.Location = new System.Drawing.Point(73, 360);
            this.grp_DsDoiTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_DsDoiTac.Name = "grp_DsDoiTac";
            this.grp_DsDoiTac.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_DsDoiTac.Size = new System.Drawing.Size(1151, 401);
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
            this.dgv_DSDTAC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DSDTAC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DSDTAC.Location = new System.Drawing.Point(5, 42);
            this.dgv_DSDTAC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_DSDTAC.Name = "dgv_DSDTAC";
            this.dgv_DSDTAC.RowHeadersWidth = 62;
            this.dgv_DSDTAC.RowTemplate.Height = 28;
            this.dgv_DSDTAC.Size = new System.Drawing.Size(1141, 355);
            this.dgv_DSDTAC.TabIndex = 10;
            // 
            // grp_DoiTac
            // 
            this.grp_DoiTac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_DoiTac.BackColor = System.Drawing.Color.White;
            this.grp_DoiTac.Controls.Add(this.lbl_DoiTac);
            this.grp_DoiTac.Controls.Add(this.txt_timDT);
            this.grp_DoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_DoiTac.Location = new System.Drawing.Point(73, 174);
            this.grp_DoiTac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_DoiTac.Name = "grp_DoiTac";
            this.grp_DoiTac.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_DoiTac.Size = new System.Drawing.Size(539, 158);
            this.grp_DoiTac.TabIndex = 12;
            this.grp_DoiTac.TabStop = false;
            this.grp_DoiTac.Text = "Đối tác cần tìm";
            // 
            // lbl_DoiTac
            // 
            this.lbl_DoiTac.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DoiTac.AutoSize = true;
            this.lbl_DoiTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoiTac.Location = new System.Drawing.Point(200, 32);
            this.lbl_DoiTac.Name = "lbl_DoiTac";
            this.lbl_DoiTac.Size = new System.Drawing.Size(101, 29);
            this.lbl_DoiTac.TabIndex = 1;
            this.lbl_DoiTac.Text = "Đối tác:";
            // 
            // txt_timDT
            // 
            this.txt_timDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_timDT.Enabled = false;
            this.txt_timDT.Location = new System.Drawing.Point(94, 88);
            this.txt_timDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_timDT.Multiline = true;
            this.txt_timDT.Name = "txt_timDT";
            this.txt_timDT.Size = new System.Drawing.Size(342, 41);
            this.txt_timDT.TabIndex = 0;
            this.txt_timDT.TextChanged += new System.EventHandler(this.txt_timDT_TextChanged);
            // 
            // grp_TimTheo
            // 
            this.grp_TimTheo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grp_TimTheo.BackColor = System.Drawing.Color.White;
            this.grp_TimTheo.Controls.Add(this.rdo_sdt);
            this.grp_TimTheo.Controls.Add(this.rdo_ten);
            this.grp_TimTheo.Controls.Add(this.pic_DT);
            this.grp_TimTheo.Controls.Add(this.rdo_ma);
            this.grp_TimTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_TimTheo.Location = new System.Drawing.Point(636, 174);
            this.grp_TimTheo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_TimTheo.Name = "grp_TimTheo";
            this.grp_TimTheo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_TimTheo.Size = new System.Drawing.Size(584, 158);
            this.grp_TimTheo.TabIndex = 11;
            this.grp_TimTheo.TabStop = false;
            this.grp_TimTheo.Text = "Bạn muốn tìm theo?";
            // 
            // rdo_sdt
            // 
            this.rdo_sdt.AutoSize = true;
            this.rdo_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_sdt.Location = new System.Drawing.Point(195, 105);
            this.rdo_sdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_sdt.Name = "rdo_sdt";
            this.rdo_sdt.Size = new System.Drawing.Size(140, 24);
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
            this.rdo_ten.Location = new System.Drawing.Point(390, 45);
            this.rdo_ten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_ten.Name = "rdo_ten";
            this.rdo_ten.Size = new System.Drawing.Size(116, 24);
            this.rdo_ten.TabIndex = 2;
            this.rdo_ten.TabStop = true;
            this.rdo_ten.Text = "Họ và Tên";
            this.rdo_ten.UseVisualStyleBackColor = true;
            this.rdo_ten.CheckedChanged += new System.EventHandler(this.rdo_ten_CheckedChanged);
            // 
            // pic_DT
            // 
            this.pic_DT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_DT.Image = ((System.Drawing.Image)(resources.GetObject("pic_DT.Image")));
            this.pic_DT.Location = new System.Drawing.Point(27, 45);
            this.pic_DT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_DT.Name = "pic_DT";
            this.pic_DT.Size = new System.Drawing.Size(116, 83);
            this.pic_DT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_DT.TabIndex = 8;
            this.pic_DT.TabStop = false;
            // 
            // rdo_ma
            // 
            this.rdo_ma.AutoSize = true;
            this.rdo_ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_ma.Location = new System.Drawing.Point(195, 45);
            this.rdo_ma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdo_ma.Name = "rdo_ma";
            this.rdo_ma.Size = new System.Drawing.Size(61, 24);
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
            this.lbl_TieuDe.Location = new System.Drawing.Point(478, 82);
            this.lbl_TieuDe.Name = "lbl_TieuDe";
            this.lbl_TieuDe.Size = new System.Drawing.Size(246, 29);
            this.lbl_TieuDe.TabIndex = 5;
            this.lbl_TieuDe.Text = "TÌM KIẾM ĐỐI TÁC";
            // 
            // frm_DoiTac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 837);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DoiTac";
            this.Text = "frm_DoiTac";
            this.Load += new System.EventHandler(this.frm_DoiTac_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grp_DsThongTinDoiTac.ResumeLayout(false);
            this.grp_DsThongTinDoiTac.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DoiTac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSach)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grp_DsDoiTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DSDTAC)).EndInit();
            this.grp_DoiTac.ResumeLayout(false);
            this.grp_DoiTac.PerformLayout();
            this.grp_TimTheo.ResumeLayout(false);
            this.grp_TimTheo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_DT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grp_DsThongTinDoiTac;
        private System.Windows.Forms.DataGridView dgv_DanhSach;
        private System.Windows.Forms.Label lbl_DanhSachDoiTac;
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
        private System.Windows.Forms.PictureBox pic_DoiTac;
        private System.Windows.Forms.PictureBox pic_DT;
        private System.Windows.Forms.DataGridView dgv_DSDTAC;
        private System.Windows.Forms.GroupBox grp_TimTheo;
        private System.Windows.Forms.RadioButton rdo_sdt;
        private System.Windows.Forms.RadioButton rdo_ten;
        private System.Windows.Forms.RadioButton rdo_ma;
        private System.Windows.Forms.GroupBox grp_DoiTac;
        private System.Windows.Forms.GroupBox grp_DsDoiTac;
    }
}