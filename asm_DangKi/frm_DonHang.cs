using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Media.Media3D;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace asm_DangKi

{
    public partial class frm_DonHang : Form
    {
        string str = "Data Source=.;Initial Catalog=SNOWFOOD;Integrated Security=True";
        SqlConnection conn = null;
        int viTri = -1;

        public frm_DonHang()
        {
            InitializeComponent();

            // gọi hàm load dữ liệu 
            LoadDuLieuVaocbo_SanPham();

            // gọi hàm load cbo_DoiTac 
            LoadDuLieuVaocbo_DoiTac();

            // gọi hàm load txt_NhanVienTaoHoaDon
            Loadtxt_TenNhanVien();

            // gọi hàm load bảng giao dịch
            LoadBangGiaoDich();

            // tính tổng doanh thu
            TongDoanhThu();

            txt_SoLuong.ReadOnly = true;

            btn_Huy.Hide();

            btn_SuaDonHang.Enabled = false; 
            btn_ThanhToan.Enabled = false;
            btn_ThemVaoDonHang.Enabled = false;
            btn_XoaDonHang.Enabled = false;
        }

        //=========================================

        // load dữ liệu vào cbo_LuaChonSanPham
        public void LoadDuLieuVaocbo_SanPham()
        {
            try
            {
                using (conn = new SqlConnection(str))
                {
                    string query = "select * from SanPham";
                    SqlDataAdapter _adapter = new SqlDataAdapter(query, conn);
                    DataSet _dataset = new DataSet();
                    _adapter.Fill(_dataset, "SanPham");

                    cbo_LuaChonSanPham.DataSource = _dataset.Tables["SanPham"];
                    cbo_LuaChonSanPham.DisplayMember = "TenSanPham";
                    cbo_LuaChonSanPham.ValueMember = "MaSanPham";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //=========================================

        // load dữ liệu vào cbo_DoiTac
        public void LoadDuLieuVaocbo_DoiTac()
        {
            try
            {
                using (conn = new SqlConnection(str))
                {
                    string query = "select * from DoiTac";
                    SqlDataAdapter _adapter = new SqlDataAdapter(query, conn);
                    DataSet _dataset = new DataSet();
                    _adapter.Fill(_dataset, "DoiTac");

                    cbo_TenDoiTac.DataSource = _dataset.Tables["DoiTac"];
                    cbo_TenDoiTac.DisplayMember = "TenDoiTac";
                    cbo_TenDoiTac.ValueMember = "MaDoiTac";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //=========================================

        // load dữ liệu để thêm vào txt_NhanVienTaoHoaDon
        public void Loadtxt_TenNhanVien()
        {
            try
            {
                using (conn = new SqlConnection(str))
                {
                    conn.Open();
                    string query = "select * from TaiKhoan";
                    SqlDataAdapter _adapter = new SqlDataAdapter(query, conn);
                    DataSet _dataset = new DataSet();
                    _adapter.Fill(_dataset, "TaiKhoan");

                    cbo_NhanVien.DataSource = _dataset.Tables["TaiKhoan"];
                    cbo_NhanVien.DisplayMember = "HoVaTen";
                    cbo_NhanVien.ValueMember = "TenDangNhap";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //=========================================

        // load dữ liệu của bảng hoá đơn 
        public void LoadDatagridviewHoaDon()
        {
            try
            {
                using (conn = new SqlConnection(str))
                {
                    dgv_DonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    string query = $"select * from HoaDon where MaHoaDon = '{txt_MaHoaDon.Text}' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter _adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    _adapter.Fill(dt);
                    dgv_DonHang.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //=========================================

        // load dữ liệu của bảng đơn hàng 
        public void LoadDataGridViewDoHang()
        {
            try
            {
                using (conn = new SqlConnection(str))
                {
                    dgv_DonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    string query = $"select * from HoaDon_dsSanPham where MaHoaDon = '{txt_MaHoaDon.Text}' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter _adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    _adapter.Fill(dt);
                    dgv_ThonTinDonHangSanPham.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //=========================================

        // thay đổi các textbox khi đổi dữ liệu trong combobox
        private void cbo_LuaChonSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (conn = new SqlConnection(str))
                {
                    conn.Open();
                    string query = "select * from SanPham where MaSanPham = @ma";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", cbo_LuaChonSanPham.SelectedValue.ToString());
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txt_DonGia.Text = reader["GiaBan"].ToString();
                        txt_HangTonKho.Text = reader["SoLuong"].ToString();
                    }
                    txt_SoLuong.ReadOnly = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //=========================================

        // thay đổi các textbox khi đổi dữ liệu trong combobox
        private void cbo_TenDoiTac_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (conn = new SqlConnection(str))
                {
                    conn.Open();
                    string query = "select * from DoiTac where MaDoiTac = @ma";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", cbo_TenDoiTac.SelectedValue.ToString());
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txt_SoDienThoaiDoiTac.Text = reader["SoDT"].ToString();
                        txt_DiaChiDoiTac.Text = reader["DiaChi"].ToString();
                    }
                } // thay đổi các textbox khi đổi dữ liệu trong combobox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //=========================================

        // tạo hoá đơn mới khi click vào button
        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MaHoaDon.Text.Length < 3)
                {
                    MessageBox.Show("Mã hoá đơn không hợp lệ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ThemHoaDon();

                    txt_MaHoaDon.ReadOnly = true;
                    btn_TaoHoaDon.Hide();
                    btn_Huy.Show();
                    btn_ThemVaoDonHang.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //=========================================

        // tạo hoá đơn 
        public void ThemHoaDon() 
        {
            using (conn = new SqlConnection(str))
            {
                string query = "select * from HoaDon";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter _adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(_adapter);
                _adapter.Fill(dataSet, "HoaDon");
                DataRow dataRow = dataSet.Tables["HoaDon"].NewRow();
                dataRow["MaHoaDon"] = txt_MaHoaDon.Text;
                dataRow["MaDoiTac"] = cbo_TenDoiTac.SelectedValue.ToString();
                DateTime dateTime = dtm_NgayTaoHoaDon.Value;
                dataRow["NgayTaoHoaDon"] = dateTime.ToString("yyyy/MM/dd");
                dataRow["TongTien"] = 0;
                dataRow["NVTaoDon"] = cbo_NhanVien.SelectedValue.ToString();

                dataSet.Tables["HoaDon"].Rows.Add(dataRow);
                _adapter.Update(dataSet.Tables["HoaDon"]);
                LoadDatagridviewHoaDon();



            }
        }

        //=========================================

        // thêm sản phẩm vào đơn hàng
        public void ThemSanPhamVaoDonHang()
        {
            using (conn = new SqlConnection(str))
            {
                dgv_ThonTinDonHangSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                int soLuong = int.Parse(txt_SoLuong.Text);
                int tongTien = int.Parse(txt_TongTien.Text);

                string query = $"select * from HoaDon_dsSanPham where MaHoaDon = '{txt_MaHoaDon.Text}' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);

                dataAdapter.Fill(dataSet, "HoaDon_dsSanPham");
                DataRow dataRow = dataSet.Tables["HoaDon_dsSanPham"].NewRow();
                dataRow["MaHoaDon"] = txt_MaHoaDon.Text;
                dataRow["MaSanPham"] = cbo_LuaChonSanPham.SelectedValue.ToString();
                dataRow["SoLuong"] = soLuong;
                dataRow["TongTien"] = tongTien;

                dataSet.Tables["HoaDon_dsSanPham"].Rows.Add(dataRow);
                dataAdapter.Update(dataSet.Tables["HoaDon_dsSanPham"]);
                LoadDatagridviewHoaDon();
            }
        }

        //=========================================

        // tính tổng tiền khi thêm sản phẩm vào đơn hàng
        public void TongTienDonHang()
        {
            int tongTienDonHang = int.Parse(txt_TongTien.Text);
            int tongTien = 0;

            // lấy giá trị tổng tiền ban đầu của hoá đơn 
            using (conn = new SqlConnection(str))
            {
                conn.Open();
                string query = "select * from HoaDon where MaHoaDon = @MaHoaDon ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", txt_MaHoaDon.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tongTien = int.Parse(reader["TongTien"].ToString());
                }
            }

            // cập nhật tổng tiền trong hoá đơn 
            using (conn = new SqlConnection(str))
            {
                conn.Open();
                dgv_DonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                string query = $"update HoaDon set TongTien = '{tongTien + tongTienDonHang}' where MaHoaDon = '{txt_MaHoaDon.Text}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                LoadDatagridviewHoaDon();
                txt_TongTienHoaDon.Text = (tongTien + tongTienDonHang).ToString();
            } 

        }

        //=========================================

        // Giảm số lượng tồn kho khi thêm sản phẩm vào đơn hàng ( số lượng tồn kho mới = số lượng đơn hàng - số lượng tồn kho cũ)
        public void SoLuongSauKhiThemDonHang()
        {
            int soLuong = int.Parse(txt_SoLuong.Text);
            int soLuongTonKho = int.Parse(txt_HangTonKho.Text);
            int soLuongConLai;
            soLuongConLai = soLuongTonKho - soLuong;
            using (conn = new SqlConnection(str))
            {
                conn.Open();
                string query = $"update SanPham set SoLuong = @SoLuong where MaSanPham = @Ma ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", cbo_LuaChonSanPham.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@SoLuong", soLuongConLai);
                cmd.ExecuteNonQuery();
                txt_HangTonKho.Text = soLuongConLai.ToString();
            }
        }

        //=========================================

        // xử lý sự kiện khi click vào button thêm vào đơn hàng
        private void btn_ThemVaoDonHang_Click(object sender, EventArgs e)
        {
            try
            {
                int soLuong = int.Parse(txt_SoLuong.Text);
                int hangTonKho = int.Parse(txt_HangTonKho.Text);

                if (soLuong <= 0 || soLuong > hangTonKho)
                {
                    MessageBox.Show("Số lượng > Hàng tồn kho", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ThemSanPhamVaoDonHang();
                    LoadDataGridViewDoHang();
                    TongTienDonHang();
                    SoLuongSauKhiThemDonHang();

                    btn_ThanhToan.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //=========================================

        // xử lý sự kiện khi nhập số lượng vào txt_SoLuong
        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            int soLuong = 0;
            int.TryParse(txt_SoLuong.Text, out soLuong);
            int tongTien = soLuong * int.Parse(txt_DonGia.Text); // giá tiền của mỗi sản phẩm
            txt_TongTien.Text = tongTien.ToString();
        }

        //=========================================

        // xoá sản phẩm trong đơn hàng khi click vào button
        private void btn_XoaDonHang_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xoá không !!!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if ( result == DialogResult.OK)
                {
                    XoaSanPhamTrongDonHang();
                    SoLuongSauKhiXoaSanPhamTrongDonHang();
                    TongTienSauKhiXoaSanPhamTrongDonHang();

                    btn_SuaDonHang.Enabled = false;
                    btn_ThemVaoDonHang.Enabled = true;
                    btn_XoaDonHang.Enabled = false;
                    int tongTien = int.Parse(txt_TongTienHoaDon.Text); 
                    if ( tongTien == 0 )
                    {
                        btn_ThanhToan.Enabled = false;
                    }
                    else
                    {
                        btn_ThanhToan.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //=========================================

        // xử lý sự kiện khi click vào datagrilview
        private void dgv_ThonTinDonHangSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    using (conn = new SqlConnection(str))
                    {
                        string query = $"select * from HoaDon_dsSanPham where MaHoaDon = '{txt_MaHoaDon.Text}'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);

                        adapter.Fill(dataSet, "HoaDon_dsSanPham");
                        viTri = e.RowIndex;
                        DataRow dataRow = dataSet.Tables["HoaDon_dsSanPham"].Rows[viTri];
                        cbo_LuaChonSanPham.SelectedValue = dataRow["MaSanPham"].ToString();
                        txt_SoLuong.Text = dataRow["SoLuong"].ToString();
                        txt_TongTien.Text = dataRow["TongTien"].ToString();
                    }

                    btn_SuaDonHang.Enabled = true;
                    btn_ThanhToan.Enabled = false;
                    btn_ThemVaoDonHang.Enabled = false;
                    btn_XoaDonHang.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        //=========================================

        // xoá sản phẩm trong đơn hàng 
        public void XoaSanPhamTrongDonHang()
        {
            using (conn = new SqlConnection(str))
            {
                string query = $"select * from HoaDon_dsSanPham where MaHoaDon = '{txt_MaHoaDon.Text}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);

                adapter.Fill(dataSet, "HoaDon_dsSanPham");
                DataRow dataRow = dataSet.Tables["HoaDon_dsSanPham"].Rows[viTri];
                dataRow.Delete();
                adapter.Update(dataSet.Tables["HoaDon_dsSanPham"]);
                LoadDataGridViewDoHang();
            }
        }

        //=========================================

        // số lượng sản phẩm sau khi xoá sản phẩm trong đơn hàng
        public void SoLuongSauKhiXoaSanPhamTrongDonHang()
        {
            int soLuong = int.Parse(txt_SoLuong.Text);
            int soLuongTonKho = int.Parse(txt_HangTonKho.Text);
            int soLuongConLai;
            soLuongConLai = soLuongTonKho + soLuong;
            using (conn = new SqlConnection(str))
            {
                conn.Open();
                string query = $"update SanPham set SoLuong = @SoLuong where MaSanPham = @Ma ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", cbo_LuaChonSanPham.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@SoLuong", soLuongConLai);
                cmd.ExecuteNonQuery();
                txt_HangTonKho.Text = soLuongConLai.ToString();
            }
        }

        //=========================================

        // tổng tiền sau khi xoá sản phẩm trong đơn hàng
        public void TongTienSauKhiXoaSanPhamTrongDonHang()
        {
            int tongTienDonHang = int.Parse(txt_TongTien.Text);
            int tongTien = 0;
            using (conn = new SqlConnection(str))
            {
                conn.Open();
                string query = "select * from HoaDon where MaHoaDon = @MaHoaDon ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaHoaDon", txt_MaHoaDon.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tongTien = int.Parse(reader["TongTien"].ToString());
                }
            } // lấy giá trị tổng tiền ban đầu của hoá đơn 

            using (conn = new SqlConnection(str))
            {
                conn.Open();
                dgv_DonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                string query = $"update HoaDon set TongTien = '{tongTien - tongTienDonHang}' where MaHoaDon = '{txt_MaHoaDon.Text}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                LoadDatagridviewHoaDon();
                txt_TongTienHoaDon.Text = (tongTien - tongTienDonHang).ToString();
            } // cập nhật tổng tiền trong hoá đơn 
        }

        //=========================================

        // sửa số lượng sản phẩm trong đơn hàng sau khi cick vào button
        private void btn_SuaDonHang_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn sửa không !!!" , "Thông báo" , MessageBoxButtons.OKCancel , MessageBoxIcon.Question );
                if (result == DialogResult.OK)
                {
                    SoLuongSauKhiSuaSanPhamTrongDonHang();
                    TongGiaSauKhiSuaSanPhamTrongDonHang();
                    SuaSanPhamTrongDonHang();
                    
                    btn_SuaDonHang.Enabled = false;
                    btn_ThanhToan.Enabled = true;
                    btn_ThemVaoDonHang.Enabled = true;
                    btn_XoaDonHang.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //=========================================

        // sữa số lượng sản phẩm trong đơn hàng 
        public void SuaSanPhamTrongDonHang()
        {
            using (conn = new SqlConnection(str))
            {
                string query = $"select * from HoaDon_dsSanPham where MaHoaDon = '{txt_MaHoaDon.Text}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);

                adapter.Fill(dataSet, "HoaDon_dsSanPham");
                DataRow dataRow = dataSet.Tables["HoaDon_dsSanPham"].Rows[viTri];

                dataRow.BeginEdit();
                dataRow["SoLuong"] = txt_SoLuong.Text;
                dataRow["TongTien"] = txt_TongTien.Text;
                dataRow.EndEdit();

                adapter.Update(dataSet.Tables["HoaDon_dsSanPham"]);
                LoadDataGridViewDoHang();
            }
        }

        //=========================================

        // số lượng sau khi sữa sản phẩm trong đơn hàng

        public void SoLuongSauKhiSuaSanPhamTrongDonHang()
        {
            int soLuong = 0; 
            int soLuongTonKho = int.Parse(txt_HangTonKho.Text);
            int soLuongMoi = int.Parse(txt_SoLuong.Text);


            using (conn = new SqlConnection(str))
            {
                conn.Open();
                string query = "select * from HoaDon_dsSanPham where MaSanPham = @Ma  and MaHoaDon = @MaHoaDon ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", cbo_LuaChonSanPham.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@MaHoaDon", txt_MaHoaDon.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    soLuong = int.Parse(reader["SoLuong"].ToString());
                }
            } // lấy số lượng ban đầu trong đơn hàng

            int khoangChenhLech = 0;
            int soLuongConLai = 0;

            if ( soLuong < soLuongMoi)
            {
                khoangChenhLech = soLuongMoi - soLuong;
                soLuongConLai = soLuongTonKho - khoangChenhLech;
                CapNhatSoLuong(soLuongConLai); 
            }
            else if ( soLuong > soLuongMoi)
            {
                khoangChenhLech = soLuong - soLuongMoi; 
                soLuongConLai = soLuongTonKho + khoangChenhLech;
                CapNhatSoLuong(soLuongConLai) ;
            }

        } 
        //---------------------------------------------------                                          
        public void CapNhatSoLuong(int soLuongConLai)
        {
            using (conn = new SqlConnection(str))
            {
                conn.Open();
                string query = $"update SanPham set SoLuong = @SoLuong where MaSanPham = @Ma ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", cbo_LuaChonSanPham.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@SoLuong", soLuongConLai);
                cmd.ExecuteNonQuery();
                txt_HangTonKho.Text = soLuongConLai.ToString();
            }
        }

        //=========================================

        // tổng giá sau khi sữa sản phẩm trong đơn hàng 
        public void TongGiaSauKhiSuaSanPhamTrongDonHang()
        {
            int tongGiaMoi = int.Parse(txt_TongTien.Text);
            int tongGiaCu = 0;
            int tongGiaHoaDon = 0;
            using (conn = new SqlConnection(str))
            {
                conn.Open();
                string query = "select * from HoaDon_dsSanPham where MaSanPham = @Ma  and MaHoaDon = @MaHoaDon ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", cbo_LuaChonSanPham.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@MaHoaDon", txt_MaHoaDon.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tongGiaCu = int.Parse(reader["TongTien"].ToString());
                }
            } // lấy giá trị tổng tiền ban đầu của sản phẩm

            using (conn = new SqlConnection(str))
            {
                conn.Open();
                string query = "select * from HoaDon where MaHoaDon = @Ma ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", txt_MaHoaDon.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tongGiaHoaDon = int.Parse(reader["TongTien"].ToString());
                }
            } // lấy giá trị tổng tiền ban đầu của hoá đơn 

            int khoangChenhLech = 0 ; 
            int tongTienHoaDonMoi = 0 ; 
            if ( tongGiaCu < tongGiaMoi)
            {
                khoangChenhLech = tongGiaMoi - tongGiaCu;
                tongTienHoaDonMoi = tongGiaHoaDon + khoangChenhLech;
                CapNhatGiaTien(tongTienHoaDonMoi); 
            }
            else if ( tongGiaCu > tongGiaMoi)
            {
                khoangChenhLech = tongGiaCu - tongGiaMoi;
                tongTienHoaDonMoi = tongGiaHoaDon - khoangChenhLech;
                CapNhatGiaTien(tongTienHoaDonMoi); 
            }
            LoadDatagridviewHoaDon();

        }
        //------------------------------------------------------
        public void CapNhatGiaTien( int tongTienHoaDonMoi)
        {
            using (conn = new SqlConnection(str))
            {
                conn.Open();
                string query = $"update HoaDon set TongTien = @SoLuong where MaHoaDon = @Ma ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Ma", txt_MaHoaDon.Text);
                cmd.Parameters.AddWithValue("@SoLuong", tongTienHoaDonMoi);
                cmd.ExecuteNonQuery();
                txt_TongTienHoaDon.Text = tongTienHoaDonMoi.ToString();
            }
        }
        //=========================================

        // sữ lý sự kiện khi click vào button thanh toán
        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                ThemHoaDonVaoBangGiaoDich();
                TongDoanhThu();

                btn_TaoHoaDon.Show();

                txt_MaHoaDon.ReadOnly = false; 

                txt_MaHoaDon.Clear();
                txt_HangTonKho.Clear();

                txt_SoLuong.ReadOnly = true;

                txt_SoLuong.Clear();
                txt_TongTien.Clear();
                txt_TongTienHoaDon.Clear();
                txt_DonGia.Clear();
                btn_Huy.Hide();

                btn_SuaDonHang.Enabled = false;
                btn_ThanhToan.Enabled = false;
                btn_ThemVaoDonHang.Enabled = false;
                btn_XoaDonHang.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //=========================================

        // thêm vào bảng giao dịch khi click vào button thanh toán
        public void ThemHoaDonVaoBangGiaoDich()
        {
            using (conn = new SqlConnection(str))
            {

                string query = $"select * from GiaoDich ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);

                dataAdapter.Fill(dataSet, "GiaoDich");
                DataRow dataRow = dataSet.Tables["GiaoDich"].NewRow();
                dataRow["MaHoaDon"] = txt_MaHoaDon.Text;

                dataSet.Tables["GiaoDich"].Rows.Add(dataRow);
                dataAdapter.Update(dataSet.Tables["GiaoDich"]);
                LoadBangGiaoDich();
            }
            dgv_DonHang.DataSource = null;
            dgv_ThonTinDonHangSanPham.DataSource = null;
        }

        //=========================================

        // load bảng giao dịch 
        public void LoadBangGiaoDich()
        {
            try
            {
                using (conn = new SqlConnection(str))
                {
                    dgv_GiaoDich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    string query = $"SELECT * FROM HoaDon INNER JOIN GiaoDich ON HoaDon.MaHoaDon = GiaoDich.MaHoaDon ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter _adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    _adapter.Fill(dt);
                    dgv_GiaoDich.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //=========================================

        // hiện thi các sản phẩm trong đơn hàng đã được giao dịch
        private void dgv_GiaoDich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {

                }
                else
                {
                    string sql;
                    using (conn = new SqlConnection(str))
                    {
                        string query = $"select * from GiaoDich";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);

                        adapter.Fill(dataSet, "HoaDon_dsSanPham");
                        DataRow dataRow = dataSet.Tables["HoaDon_dsSanPham"].Rows[e.RowIndex];
                        sql = dataRow["MaHoaDon"].ToString();
                    }

                    using (conn = new SqlConnection(str))
                    {
                        dgv_ThongTinSanPhamGiaoDich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        string query = $"SELECT HoaDon_dsSanPham.MaHoaDonSanPham , HoaDon_dsSanPham.SoLuong , SanPham.TenSanPham , SanPham.GiaBan  ,HoaDon_dsSanPham.TongTien  , SanPham.TinhTrang FROM SanPham INNER JOIN HoaDon_dsSanPham ON SanPham.MaSanPham = HoaDon_dsSanPham.MaSanPham where MaHoaDon = '{sql}'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgv_ThongTinSanPhamGiaoDich.DataSource = dt;
                    }

                    using ( conn = new SqlConnection(str))
                    {
                        dgv_ThongTinDoiTac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        string query = $"SELECT DoiTac.TenDoiTac , DoiTac.DiaChi , DoiTac.SoDT , DoiTac.Email FROM HoaDon INNER JOIN DoiTac ON HoaDon.MaDoiTac = DoiTac.MaDoiTac where MaHoaDon = '{sql}'"; 
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd); 
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgv_ThongTinDoiTac.DataSource = dt; 
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //=========================================

        // xuất file excel
        public void XuatFileExcel()
        {
            using (conn = new SqlConnection(str))
            {
                conn.Open();
                string query = "SELECT * FROM HoaDon INNER JOIN GiaoDich ON HoaDon.MaHoaDon = GiaoDich.MaHoaDon";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable(); 
                dataAdapter.Fill(dt);

                IWorkbook wb = new XSSFWorkbook();

                ISheet sheet = wb.CreateSheet("DoanhThu");

                IRow cells = sheet.CreateRow(0);
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    cells.CreateCell(i).SetCellValue(dt.Columns[i].ColumnName);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dataRow = dt.Rows[i];
                    IRow row = sheet.CreateRow(i + 1);

                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        row.CreateCell(j).SetCellValue(dataRow[j].ToString());
                    }
                }
                using (var fileStream = new FileStream("DoanhThu.xlsx", FileMode.Create, FileAccess.Write))
                {
                    wb.Write(fileStream);
                } 
            }

            // xoá toàn bộ dữ liệu trong bảng giao dịch sau khi xuất file
            using (conn = new SqlConnection(str))
            {
                conn.Open();
                string query = "TRUNCATE TABLE GiaoDich"; 
                SqlCommand cmd = new SqlCommand( query , conn );    
                cmd.ExecuteNonQuery();
            }

            using (conn = new SqlConnection(str))
            {
                conn.Open();
                string query = "DELETE FROM HoaDon_dsSanPham";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }

            using (conn = new SqlConnection(str))
            {
                conn.Open();
                string query = "DELETE FROM HoaDon";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }

            txt_TongDoanhThu.Clear(); 
        }

        //=========================================

        // tính tổng doanh thu bán hàng
        public void TongDoanhThu()
        {
            txt_TongDoanhThu.ReadOnly = true;
            using (conn = new SqlConnection(str))
            {
                int tong = 0;
                using (conn = new SqlConnection(str))
                {
                    conn.Open();
                    string query = $"select * from HoaDon";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        tong += int.Parse(sqlDataReader["TongTien"].ToString());
                    }
                    txt_TongDoanhThu.Text = tong.ToString();
                }
            }
        }

        //=========================================

        // xử lý sự kiện khi click vào button xuất file
        private void btn_XuatFile_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn các muốn xuất file không !!!!\nKhi xuất file sẽ xoá toàn bộ dữ liệu trong SQL" , "Thông báo" , MessageBoxButtons.OKCancel , MessageBoxIcon.Question);
                if ( result == DialogResult.OK)
                {
                    XuatFileExcel();
                    MessageBox.Show("Xuất file thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    dgv_ThongTinSanPhamGiaoDich.DataSource = null;
                    LoadBangGiaoDich();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        //=========================================

        // xử lý sự kiện huỷ khi click vào button huy
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn huỷ không !!!!" , "Thông báo" , MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if ( result == DialogResult.OK)
            {
                HuyHoaDon();
            }
        }

        //=========================================

        // huỷ hoá đơn
        public void HuyHoaDon()
        {
            using (conn = new SqlConnection(str))
            {
                conn.Open();
                string query = "DELETE FROM HoaDon_dsSanPham where MaHoaDon = @ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma" , txt_MaHoaDon.Text);
                cmd.ExecuteNonQuery();
            }

            using (conn = new SqlConnection(str))
            {
                conn.Open();
                string query = "DELETE FROM HoaDon where MaHoaDon = @ma";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma", txt_MaHoaDon.Text);
                cmd.ExecuteNonQuery();
            }
            dgv_DonHang.DataSource = null;
            dgv_ThonTinDonHangSanPham.DataSource = null;

            btn_TaoHoaDon.Show();
            txt_MaHoaDon.ReadOnly = false;

            txt_MaHoaDon.Clear();
            txt_HangTonKho.Clear();

            txt_SoLuong.ReadOnly = true;

            txt_SoLuong.Clear();
            txt_TongTien.Clear();
            txt_TongTienHoaDon.Clear();
            txt_DonGia.Clear();

            btn_Huy.Hide();

            btn_SuaDonHang.Enabled = false;
            btn_ThanhToan.Enabled = false;
            btn_ThemVaoDonHang.Enabled = false;
            btn_XoaDonHang.Enabled = false;
        }

        //=========================================

        // hiển thị khi click vào datagridview
        private void dgv_DonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    using (conn = new SqlConnection(str))
                    {
                        string query = $"select * from HoaDon where MaHoaDon = '{txt_MaHoaDon.Text}'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);

                        adapter.Fill(dataSet, "HoaDon");
                        DataRow dataRow = dataSet.Tables["HoaDon"].Rows[e.RowIndex];
                        cbo_NhanVien.SelectedValue = dataRow["NVTaoDon"].ToString();
                        cbo_TenDoiTac.SelectedValue = dataRow["MaDoiTac"].ToString();
                        dtm_NgayTaoHoaDon.Text = dataRow["NgayTaoHoaDon"].ToString(); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //=========================================
    }
}
