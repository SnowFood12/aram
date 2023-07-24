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

namespace asm_DangKi
{
    public partial class frm_DonHang : Form
    {   
        string str = "Data Source=.;Initial Catalog=SNOWFOOD;Integrated Security=True   "; 
        SqlConnection conn = null;
        public frm_DonHang()
        {
            InitializeComponent();
            // gọi hàm load dữ liệu 
            LoadDuLieuVaocbo_SanPham(); 
            // gọi hàm load cbo_DoiTac 
            LoadDuLieuVaocbo_DoiTac();
            // gọi hàm load txt_NhanVienTaoHoaDon
            Loadtxt_TenNhanVien();
        }
        void LoadDuLieuVaocbo_SanPham()
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
        } // load dữ liệu vào cbo_LuaChonSanPham

        void LoadDuLieuVaocbo_DoiTac()
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
            catch ( Exception ex )
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } // load dữ liệu vào cbo_DoiTac

        void Loadtxt_TenNhanVien()
        {
            try
            {
                using (conn = new SqlConnection(str))
                {
                    conn.Open();
                    string query = "select * from TaiKhoan";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txt_NhanVienTaoHoaDon.Text = reader["HoVaTen"].ToString();
                    }
                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        } // load dữ liệu để thêm vào txt_NhanVienTaoHoaDon

        void LoadDatagridviewHoaDon()
        {
            try
            {
                using (conn = new SqlConnection(str))
                {
                    dgv_DonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    string query = "select * from HoaDon";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter _adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    _adapter.Fill(dt);
                    dgv_DonHang.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " +  ex.Message , "Thông báo", MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        } // thay đổi các textbox khi đổi dữ liệu trong combobox
        
   

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
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                using ( conn = new SqlConnection(str))
                {
                    string query = "select * from HoaDon";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter _adapter = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    SqlCommandBuilder sqlCommand = new SqlCommandBuilder(_adapter);
                    _adapter.Fill(dataSet, "HoaDon");
                    DataRow dataRow = dataSet.Tables["HoaDon"].NewRow();
                    dataRow["MaHoaDon"] = txt_MaHoaDon.Text;

                }
            }
            catch ( Exception ex )
            {
                MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
