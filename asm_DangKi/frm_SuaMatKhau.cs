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
    public partial class frm_SuaMatKhau: Form
    {
        public frm_SuaMatKhau()
        {
            InitializeComponent();
        }
        string str = "Data Source=LAPTOP-JAKJA372\\TAIMAIKHONGDUOC;Initial Catalog=SNOWFOOD;Integrated Security=True"; // khai báo chuỗi liên kết 
        SqlConnection conn = null;
        private void chk_HienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_HienThiMK.Checked)
            {
                txt_MatKhauCu.UseSystemPasswordChar = false; // hiển thị mật khẩu khi chk_HienThiMK.Checked = true 
                txt_MatKhauMoi.UseSystemPasswordChar = false; // hiển thị mật khẩu khi chk_HienThiMK.Checked = true 
                txt_XacNhanMatKhau.UseSystemPasswordChar = false; // hiển thị mật khẩu khi chk_HienThiMK.Checked = true 
            }
            else
            {
                   // ẩn mật khẩu khi chk_HienThiMK.Checked = false 
                txt_MatKhauCu.UseSystemPasswordChar = true; 
                txt_MatKhauMoi.UseSystemPasswordChar = true; 
                txt_XacNhanMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void btn_ThayDoiMatKhau_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(str))
            {
                conn.Open();

                if (string.IsNullOrWhiteSpace(txt_MatKhauCu.Text) || string.IsNullOrWhiteSpace(txt_MatKhauMoi.Text) || string.IsNullOrWhiteSpace(txt_XacNhanMatKhau.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (txt_MatKhauCu.Text.Length < 5 )
                {
                    err_kiemTra.SetError(txt_MatKhauCu, "Mật khẩu không hợp lệ");
                    return;

                }
                else if (txt_MatKhauMoi.Text.Length < 5)
                {
                    err_kiemTra.SetError(txt_MatKhauMoi, "Mật khẩu không hợp lệ");
                    return;
                }
                else if (txt_MatKhauMoi.Text.Length < 5)
                {
                    err_kiemTra.SetError(txt_XacNhanMatKhau, "Mật khẩu không hợp lệ");
                    return;
                }

                string Matkhau = @"UPDATE TaiKhoan SET MatKhau = @matKhauMoi WHERE MatKhau = @matKhauCu";
                SqlCommand cmd = new SqlCommand(Matkhau, conn);

                cmd.Parameters.AddWithValue("@matKhauMoi", txt_MatKhauMoi.Text);
                cmd.Parameters.AddWithValue("@matKhauCu", txt_MatKhauCu.Text);

                cmd.ExecuteNonQuery();
            }
        }

        private void txt_MatKhauCu_TextChanged(object sender, EventArgs e)
        {
            err_kiemTra.SetError(txt_MatKhauCu, "");

            if (txt_MatKhauCu.Text.Length < 5)
            {
                err_kiemTra.SetError(txt_MatKhauCu, "Mật khẩu không hợp lệ");
            }
        }

        private void txt_MatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            // Xóa thông báo lỗi trước khi kiểm tra
            err_kiemTra.SetError(txt_MatKhauMoi, "");

            if (txt_MatKhauMoi.Text.Length < 5)
            {
                err_kiemTra.SetError(txt_MatKhauMoi, "Mật khẩu không hợp lệ");
                
            }
        }

        private void txt_XacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {
            // Xóa thông báo lỗi trước khi kiểm tra
            err_kiemTra.SetError(txt_XacNhanMatKhau, "");

            if (txt_XacNhanMatKhau.Text.Length < 5)
            {
                err_kiemTra.SetError(txt_XacNhanMatKhau, "Mật khẩu không hợp lệ");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frm_NhanVien nhanVien = new frm_NhanVien();
            nhanVien.Show();
            this.Hide();
        }
    }
}
