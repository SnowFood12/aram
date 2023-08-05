using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asm_DangKi
{
    public partial class frm_TenDangNhap : Form
    {
        public frm_TenDangNhap()
        {
            InitializeComponent();
        }

        string str = "Data Source=.;Initial Catalog=SNOWFOOD;Integrated Security=True"; // khai báo chuỗi liên kết 
        SqlConnection conn = null; // khai báo biến liên kết 

        private void label3_Click(object sender, EventArgs e)
        {
/*            frm_NhanVien DangNhap = new frm_NhanVien();
            DangNhap.Show();*/

            //DangNhap.Dock = DockStyle.Fill;
            frm_TrangChu trangChu = new frm_TrangChu();
            trangChu.Show();
            frm_NhanVien DangNhap = new frm_NhanVien();
            DangNhap.Show();
            DangNhap.Dock = DockStyle.Fill;
            this.Hide();

        }

        private void btn_SuaTenDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo đối tượng SqlConnection và mở kết nối
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();

                    
                    if (string.IsNullOrWhiteSpace(txt_MatKhau.Text) || txt_MatKhau.Text.Length < 5)
                    {
                        MessageBox.Show("Mật khẩu phải >5 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrWhiteSpace(txt_TenDangNhapMoi.Text) || txt_TenDangNhapMoi.Text.Length < 5)
                    {
                        MessageBox.Show("Tên đăng nhập không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        string tenMoi = "UPDATE TaiKhoan SET TenDangNhap = @tenDangNhap WHERE MatKhau = @matKhau";

                        // Khởi tạo đối tượng SqlCommand và thiết lập tham số
                        SqlCommand cmd = new SqlCommand(tenMoi, conn);
                        cmd.Parameters.AddWithValue("@tenDangNhap", txt_TenDangNhapMoi.Text);
                        cmd.Parameters.AddWithValue("@matKhau", txt_MatKhau.Text);

                        // Thực thi truy vấn và lấy số hàng bị ảnh hưởng
                        int kt = cmd.ExecuteNonQuery();

                        if (kt > 0)
                        {


                            MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thay đổi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
