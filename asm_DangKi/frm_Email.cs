using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asm_DangKi
{
    public partial class frm_Email : Form
    {
        public frm_Email()
        {
            InitializeComponent();
        }

        private frm_TrangChu parentForm; // Thuộc tính để giữ tham chiếu đến form cha (frm_TrangChu)

        public void frm_NhanVien(frm_TrangChu parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm; // Gán form cha (frm_TrangChu) cho thuộc tính parentForm
        }


        string str = "Data Source=.;Initial Catalog=SNOWFOOD;Integrated Security=True"; // khai báo chuỗi liên kết 
        SqlConnection conn = null;


        private void chk_HienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_HienThiMK.Checked)
            {
                txt_MatKhau.UseSystemPasswordChar = false; // hiển thị mật khẩu khi chk_HienThiMK.Checked = true 
            }
            else
            {
                txt_MatKhau.UseSystemPasswordChar = true; // ẩn mật khẩu khi chk_HienThiMK.Checked = false 
            }
        }

        private void btn_SuaSoDienThoai_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo đối tượng SqlConnection và mở kết nối
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();


                    if (string.IsNullOrWhiteSpace(txt_MatKhau.Text) || string.IsNullOrWhiteSpace(txt_EmailMoi.Text))
                    {
                        MessageBox.Show("Vui longfn hập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (txt_EmailMoi.Text.Length < 8)
                    {
                        MessageBox.Show("Email không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (!Regex.IsMatch(txt_EmailMoi.Text, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"))
                    {
                        MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (txt_MatKhau.Text.Length < 5)
                    {
                        MessageBox.Show("Mật khẩu phải >5 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {

                        string soMoi = "UPDATE TaiKhoan SET Email = @email WHERE MatKhau = @matKhau";


                        SqlCommand cmd = new SqlCommand(soMoi, conn);
                        cmd.Parameters.AddWithValue("@email", txt_EmailMoi.Text);
                        cmd.Parameters.AddWithValue("@matKhau", txt_MatKhau.Text);


                        int kt = cmd.ExecuteNonQuery();

                        if (kt > 0)
                        {
                            MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txt_EmailMoi.Text = "";
                            txt_MatKhau.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Thay đổi không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_Email_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            frm_NhanVien nhanVien = new frm_NhanVien();
            nhanVien.Show();
            this.Hide();
        }

        private void txt_EmailMoi_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_EmailMoi.Text, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"))
            {
                MessageBox.Show("Email không hợp lệ !!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
