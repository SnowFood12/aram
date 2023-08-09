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
    public partial class frm_SuaMatKhau : Form
    {
        public frm_SuaMatKhau()
        {
            InitializeComponent();
        }
        string str = "Data Source=.;Initial Catalog=SNOWFOOD;Integrated Security=True"; // khai báo chuỗi liên kết 
        SqlConnection conn = null;
        private void chk_HienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_HienThiMK.Checked)
            {

                txt_MatKhauMoi.UseSystemPasswordChar = false; // hiển thị mật khẩu khi chk_HienThiMK.Checked = true 
                txt_XacNhanMatKhau.UseSystemPasswordChar = false; // hiển thị mật khẩu khi chk_HienThiMK.Checked = true 
            }
            else
            {
                // ẩn mật khẩu khi chk_HienThiMK.Checked = false 

                txt_MatKhauMoi.UseSystemPasswordChar = true;
                txt_XacNhanMatKhau.UseSystemPasswordChar = true;
            }
        }


        public static string MatKhauCu { get; set; }
        private void btn_ThayDoiMatKhau_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(str))
            {
                conn.Open();

                if (string.IsNullOrWhiteSpace(txt_MatKhauMoi.Text) || string.IsNullOrWhiteSpace(txt_XacNhanMatKhau.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                else if (txt_XacNhanMatKhau.Text != txt_MatKhauMoi.Text)
                {
                    MessageBox.Show("Mật khẩu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {



                    string Matkhau = @"UPDATE TaiKhoan SET MatKhau = @matKhauMoi WHERE MatKhau = @matKhauCu";
                    SqlCommand cmd = new SqlCommand(Matkhau, conn);

                    cmd.Parameters.AddWithValue("@matKhauMoi", txt_MatKhauMoi.Text);
                    cmd.Parameters.AddWithValue("@matKhauCu", MatKhauCu);

                    int kt = cmd.ExecuteNonQuery();
                    if (kt > 0)
                    {
                        MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frm_NhanVien nhanVien = new frm_NhanVien();
                        nhanVien.Show();
                        // nhanVien.MdiParent = this;                   
                        nhanVien.Dock = DockStyle.Fill;
                        this.Hide();
                        txt_MatKhauMoi.Text = "";
                        txt_XacNhanMatKhau.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }



        private void txt_MatKhauMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_XacNhanMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            frm_NhanVien nhanVien = new frm_NhanVien();
            nhanVien.Show();
            this.Hide();
        }
    }
}
