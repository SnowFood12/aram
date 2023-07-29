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
    public partial class frm_SoDienThoai : Form
    {
        public frm_SoDienThoai()
        {
            InitializeComponent();
        }
        string str = "Data Source=LAPTOP-JAKJA372\\TAIMAIKHONGDUOC;Initial Catalog=SNOWFOOD;Integrated Security=True"; // khai báo chuỗi liên kết 
        SqlConnection conn = null;

        public void LoadForm()
        {
            try
            {
                

                conn = new SqlConnection(str);
                conn.Open();

                string xuatSDT = @"SELECT SoDienThoai  FROM TaiKhoan";

                SqlCommand cmd = new SqlCommand(xuatSDT, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_SoDienThoaiCu.Text = reader["SoDienThoai"].ToString();
                }
                reader.Close();

                txt_soDienThoaiMoi.Text = "";
                txt_MatKhau.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi ");
                MessageBox.Show(ex.Message);
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


                    if (string.IsNullOrWhiteSpace(txt_MatKhau.Text) || txt_MatKhau.Text.Length < 5)
                    {
                        MessageBox.Show("Mật khẩu phải >5 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrWhiteSpace(txt_soDienThoaiMoi.Text) || txt_soDienThoaiMoi.Text.Length != 10)
                    {
                        MessageBox.Show("Số điện Thoại không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        string soMoi = "UPDATE TaiKhoan SET SoDienThoai = @soDienThoai WHERE MatKhau = @matKhau";

                      
                        SqlCommand cmd = new SqlCommand(soMoi, conn);
                        cmd.Parameters.AddWithValue("@soDienThoai", txt_soDienThoaiMoi.Text);
                        cmd.Parameters.AddWithValue("@matKhau", txt_MatKhau.Text);

                       
                        int kt =  cmd.ExecuteNonQuery();

                        if (kt > 0)
                        {
                            MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadForm();
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

        private void frm_SoDienThoai_Load(object sender, EventArgs e)
        {

            try
            {
                txt_SoDienThoaiCu.Enabled = false;
                conn = new SqlConnection(str);
                conn.Open();
                LoadForm();




            }
            catch (Exception ex)
            {
                MessageBox.Show("Bị lỗi: " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frm_NhanVien nhanVien = new frm_NhanVien();
            nhanVien.Show();
            this.Hide();
        }

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
    }
}
