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
using Excel = Microsoft.Office.Interop.Excel;

namespace asm_DangKi
{
    public partial class frm_KiemKho : Form
    {
        public frm_KiemKho()
        {
            InitializeComponent();
            lbl_ThoiGianTab1.Text = DateTime.Now.ToString();
            lbl_ThoiGianKiem.Text = DateTime.Now.ToString();
            // lấy giá trị từ biến toàn cục HoVaTen
            lbl_TenUesr.Text = frm_DangNhap.HoVaTen;
            lbl_HienTen.Text = frm_DangNhap.HoVaTen;
            //Load sản phẩm vào comboBox
            LoadSanPhamVaoComboBox();
            //Khóa các button 
            btn_CanBangKho.Enabled = false;
            btn_XuatFile.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Huy.Enabled = false;
            ibtn_XuatFileHSD.Enabled = false;
        }
        SqlConnection conn = null;
        string strconn = "Data Source=LPL\\LONGPOLY;Initial Catalog=SNOWFOOD;Integrated Security=True";
        private SqlDataAdapter dataAdapter;
        private DataTable table;
        public void Load_dgv_DanhSachSanPham()
        {
            try
            {
                conn = new SqlConnection(strconn);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            string strcmd = @"SELECT * FROM SanPham";
            SqlCommand cmd = new SqlCommand(strcmd, conn);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adt.Fill(ds, "SanPham");
            dgv_DanhSachSanPham.DataSource = ds.Tables["SanPham"];
            conn.Close();
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            Load_dgv_DanhSachSanPham();
        }

        private void btn_LoaiBo_Click(object sender, EventArgs e)
        {
            try
            {
                // Update các sản phẩm hết hạn sử dụng tuy tình trạng còn tốt 
                string updateHSD = "UPDATE SanPham SET TinhTrang = N'Hết hạn' WHERE HanSuDung < GETDATE()";
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    dataAdapter = new SqlDataAdapter(updateHSD, conn);
                    table = new DataTable();
                    dataAdapter.Fill(table);
                }
                // Lấy danh sách các sản phẩm đã hết hạn sử dụng 
                string spHSD = "SELECT * FROM SanPham WHERE HanSuDung < GETDATE()";
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    dataAdapter = new SqlDataAdapter(spHSD, conn);
                    table = new DataTable();
                    dataAdapter.Fill(table);
                }

                if (table.Rows.Count > 0)
                {
                    // Hiển thị danh sách sản phẩm hết hạn lên DataGridView
                    dgv_DanhSachSanPham.DataSource = table;
                    // Xóa các sản phẩm hết hạn khỏi CSDL
                    string xoaSPHetHSD = "DELETE FROM SanPham WHERE HanSuDung < GETDATE()";
                    using (conn = new SqlConnection(strconn))
                    {
                        SqlCommand cmd = new SqlCommand(xoaSPHetHSD, conn);
                        conn.Open();
                        int spHetHSD = cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Đã loại bỏ các sản phẩm hết hạn sử dụng ra khỏi kho thực phẩm!");
                    }
                }
                else
                {
                    MessageBox.Show("Không có sản phẩm nào hết hạn để loại bỏ!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            ibtn_XuatFileHSD.Enabled = true;
        }

        private void ibtn_XuatFileHSD_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo đối tượng Excel
                Excel.Application excel = new Excel.Application();
                Excel.Workbook workbook = excel.Workbooks.Add();

                // Thêm một sheet mới và đặt tên cho sheet
                Excel.Worksheet worksheet = workbook.ActiveSheet;
                worksheet.Name = "Danh sách sản phẩm hết hạn";

                // Thêm thông tin người kiểm kho và thời gian kiểm kho vào sheet
                worksheet.Cells[1, 1] = "Tên người kiểm kho: " + lbl_HienTen.Text;
                worksheet.Cells[2, 1] = "Thời gian kiểm kho: " + DateTime.Now.ToString();
                worksheet.Cells[4, 2] = "DANH SÁCH LOẠI BỎ CÁC SẢN PHẨM HẾT HẠN SỬ DỤNG";

                // Thêm tiêu đề cho các cột
                worksheet.Cells[6, 2] = "Mã sản phẩm";
                worksheet.Cells[6, 3] = "Tên sản phẩm";
                worksheet.Cells[6, 4] = "Giá bán";
                worksheet.Cells[6, 5] = "Số lượng";
                worksheet.Cells[6, 6] = "Ngày nhập kho";
                worksheet.Cells[6, 7] = "Ngày sản xuất";
                worksheet.Cells[6, 8] = "Hạn sử dụng";
                worksheet.Cells[6, 9] = "Tình trạng";
                worksheet.Cells[6, 10] = "Ghi chú";

                // Thêm dữ liệu cho các sản phẩm hết hạn
                int row = 7;
                foreach (DataRow dr in table.Rows)
                {
                    worksheet.Cells[row, 2] = dr["MaSanPham"].ToString();
                    worksheet.Cells[row, 3] = dr["TenSanPham"].ToString();
                    worksheet.Cells[row, 4] = dr["GiaBan"].ToString();
                    worksheet.Cells[row, 5] = dr["SoLuong"].ToString();
                    worksheet.Cells[row, 6] = dr["NgayNhapKho"].ToString();
                    worksheet.Cells[row, 7] = dr["NgaySanXuat"].ToString();
                    worksheet.Cells[row, 8] = dr["HanSuDung"].ToString();
                    worksheet.Cells[row, 9] = dr["TinhTrang"].ToString();
                    worksheet.Cells[row, 10] = dr["GhiChu"].ToString();
                    row++;
                }

                // Lưu file Excel và đóng các đối tượng
                workbook.SaveAs("DanhSachSanPhamHetHan.xlsx");
                workbook.Close();
                excel.Quit();

                // Hiển thị thông báo khi xuất file thành công
                MessageBox.Show("Đã xuất file Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        //Phần kiểm tra tồn kho
        public void LoadSanPhamVaoComboBox()
        {
            using (conn = new SqlConnection(strconn))
            {
                string query = "SELECT * FROM SanPham";
                dataAdapter = new SqlDataAdapter(query, conn);
                DataSet _dataset = new DataSet();
                dataAdapter.Fill(_dataset, "SanPham");

                cbo_SanPham.DataSource = _dataset.Tables["SanPham"];
                cbo_SanPham.DisplayMember = "TenSanPham";
                cbo_SanPham.ValueMember = "MaSanPham";
            }
        }
        public void CapNhatTongSLLechVaTongChiPhiLech()
        {
            int tongSoLuongLech = 0;
            int tongChiPhiLech = 0;

            foreach (DataGridViewRow row in dgv_XuLySanPham.Rows)
            {
                if (!row.IsNewRow)
                {
                    int soLuongLech = Convert.ToInt32(row.Cells["SLLech"].Value);
                    int giaTriLech = Convert.ToInt32(row.Cells["GiaTriLech"].Value);
                    if (soLuongLech > 0)
                    {
                        row.Cells["XuHuong"].Value = "Lệch tăng";
                    }
                    else
                    {
                        row.Cells["XuHuong"].Value = "Lệch giảm";
                    }

                    tongSoLuongLech += soLuongLech;
                    tongChiPhiLech += giaTriLech;
                }
                lbl_TongSLLech.Text = tongSoLuongLech.ToString();
                lbl_TongChiPhiLech.Text = tongChiPhiLech.ToString() + " VNĐ";
            }
        }

        private void cbo_SanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSanPham = cbo_SanPham.SelectedValue.ToString();
            // Truy vấn cơ sở dữ liệu để lấy thông tin chi tiết về sản phẩm đó
            using (conn = new SqlConnection(strconn))
            {
                conn.Open();
                string query = "SELECT * FROM SanPham WHERE MaSanPham = @maSanPham";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maSanPham", maSanPham);
                SqlDataReader reader = cmd.ExecuteReader();

                // Thêm thông tin về sản phẩm này vào DataGridView
                if (reader.Read())
                {
                    string tenSanPham = reader["TenSanPham"].ToString();
                    int giaSanPham = Convert.ToInt32(reader["GiaBan"]);
                    int soLuong = Convert.ToInt32(reader["SoLuong"]);
                    dgv_XuLySanPham.Rows.Add(maSanPham, tenSanPham, giaSanPham, soLuong);
                }

                reader.Close();
            }
            btn_Xoa.Enabled = true;
            btn_Huy.Enabled = true;
        }

        private void dgv_XuLySanPham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Tính toán giá trị của từng dòng
                int soLuongTonKho = Convert.ToInt32(dgv_XuLySanPham.Rows[e.RowIndex].Cells["SLTonKho"].Value);
                int soLuongThucTe = Convert.ToInt32(dgv_XuLySanPham.Rows[e.RowIndex].Cells["SLThucTe"].Value);
                if (soLuongThucTe <= 0)
                {
                    MessageBox.Show("Số lượng thực tế phải lớn hơn 0");
                    dgv_XuLySanPham.Rows[e.RowIndex].Cells["SLThucTe"].Value = null;
                    return;
                }
                int soLuongLech = soLuongThucTe - soLuongTonKho;
                int giaBan = Convert.ToInt32(dgv_XuLySanPham.Rows[e.RowIndex].Cells["GBan"].Value);
                int giaTri = soLuongLech * giaBan;

                // Cập nhật giá trị của cột "Giá trị"
                dgv_XuLySanPham.Rows[e.RowIndex].Cells["SLLech"].Value = soLuongLech;
                dgv_XuLySanPham.Rows[e.RowIndex].Cells["GiaTriLech"].Value = giaTri;
            }
            CapNhatTongSLLechVaTongChiPhiLech();

            
            btn_CanBangKho.Enabled = true;
        }

        private void btn_CanBangKho_Click(object sender, EventArgs e)
        {
            try
            {
                using (conn = new SqlConnection(strconn))
                {
                    conn.Open();

                    string updateKho = "UPDATE SanPham SET SoLuong = @SoLuongThucTe WHERE MaSanPham= @MaSanPham";
                    SqlCommand cmd = new SqlCommand(updateKho, conn);

                    foreach (DataGridViewRow row in dgv_XuLySanPham.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@MaSanPham", row.Cells["MaSP"].Value.ToString());
                            cmd.Parameters.AddWithValue("@SoLuongThucTe", row.Cells["SLThucTe"].Value);
                            //Hiện trạng thái "Đã cân bằng kho" cho cột Trạng thái
                            row.Cells["TrangThai"].Value = "Đã cân bằng kho";
                        }
                    }
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã cân bằng số lượng tồn thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btn_XuatFile.Enabled = true;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //Lấy hàng dữ liệu muốn xóa
            DataGridViewRow chonHangXoa = dgv_XuLySanPham.CurrentRow;
            //Thống báo cho người dùng muốn xóa hay không
            DialogResult luaChon = MessageBox.Show("Bạn có muốn xóa dòng này hay không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (luaChon == DialogResult.Yes)
            {
                if (chonHangXoa != null)
                {
                    dgv_XuLySanPham.Rows.Remove(chonHangXoa);
                    CapNhatTongSLLechVaTongChiPhiLech();
                }
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            DialogResult luaChon = MessageBox.Show("Bạn có muốn hủy hay không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (luaChon == DialogResult.Yes)
            {
                while (dgv_XuLySanPham.Rows.Count > 0)
                {
                    dgv_XuLySanPham.Rows.RemoveAt(0);
                }
                lbl_TongSLLech.Text = "0";
                lbl_TongChiPhiLech.Text = "0 VNĐ";
            }
            btn_Xoa.Enabled = false;
            btn_CanBangKho.Enabled = false;
            btn_Huy.Enabled = false;
            btn_XuatFile.Enabled = false;
        }

        private void btn_XuatFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo đối tượng Excel
                Excel.Application excel = new Excel.Application();
                Excel.Workbook workbook = excel.Workbooks.Add();

                // Thêm một sheet mới và đặt tên cho sheet
                Excel.Worksheet worksheet = workbook.ActiveSheet;
                worksheet.Name = "Danh sách kiểm tra hàng tồn kho";

                // Thêm thông tin người kiểm kho và thời gian kiểm kho vào sheet
                worksheet.Cells[1, 1] = "Tên người kiểm kho: " + lbl_TenUesr.Text;
                worksheet.Cells[2, 1] = "Thời gian kiểm kho: " + DateTime.Now.ToString();
                worksheet.Cells[4, 2] = "DANH SÁCH KIỂM TRA HÀNG TỒN TRONG KHO";
                worksheet.Cells[1, 8] = "TỔNG SỐ LƯỢNG LỆCH: " + lbl_TongSLLech.Text;
                worksheet.Cells[2, 8] = "TỔNG CHI PHÍ CHÊNH LỆCH: " + lbl_TongChiPhiLech.Text; 

                // Thêm tiêu đề cho các cột
                worksheet.Cells[6, 2] = "Mã sản phẩm";
                worksheet.Cells[6, 3] = "Tên sản phẩm";
                worksheet.Cells[6, 4] = "Giá bán";
                worksheet.Cells[6, 5] = "Số lượng tồn kho";
                worksheet.Cells[6, 6] = "Số lượng thực tế";
                worksheet.Cells[6, 7] = "Số lượng lệch";
                worksheet.Cells[6, 8] = "Giá trị lệch";
                worksheet.Cells[6, 9] = "Xu hướng lệch";
                worksheet.Cells[6, 10] = "Trạng thái";

                // Thêm dữ liệu cho danh sách kiểm tra tồn kho
                int row = 7;
                foreach (DataGridViewRow dr in dgv_XuLySanPham.Rows)
                {
                    worksheet.Cells[row, 2] = dr.Cells["MaSp"].Value.ToString();
                    worksheet.Cells[row, 3] = dr.Cells["TenSP"].Value.ToString();
                    worksheet.Cells[row, 4] = dr.Cells["GBan"].Value.ToString();
                    worksheet.Cells[row, 5] = dr.Cells["SLTonKho"].Value.ToString();
                    worksheet.Cells[row, 6] = dr.Cells["SLThucTe"].Value.ToString();
                    worksheet.Cells[row, 7] = dr.Cells["SLLech"].Value.ToString();
                    worksheet.Cells[row, 8] = dr.Cells["GiaTriLech"].Value.ToString();
                    worksheet.Cells[row, 9] = dr.Cells["XuHuong"].Value.ToString();
                    worksheet.Cells[row, 10] = dr.Cells["TrangThai"].Value.ToString();
                    row++;
                }

                // Lưu file Excel và đóng các đối tượng
                workbook.SaveAs("DanhSachKiemTraHangTonkho.xlsx");
                workbook.Close();
                excel.Quit();

                // Hiển thị thông báo khi xuất file thành công
                MessageBox.Show("Đã xuất file Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
