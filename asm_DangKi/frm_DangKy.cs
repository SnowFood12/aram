﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace asm_DangKi
{
    public partial class frm_DangKi : Form
    {
        public frm_DangKi()
        {
            InitializeComponent();
        }

        string str = "Data Source=.;Initial Catalog=SNOWFOOD;Integrated Security=True"; // chuỗi kết nói SQL 

        SqlConnection conn = null;  // khai báo biến kết nói 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            // khi click vào button chuyển sang form đăng nhập 
            frm_DangNhap frm_DangNhap = new frm_DangNhap(); // khởi tại biến của form đăng nhập
            frm_DangNhap.Show(); // mở form đăng nhập 
            this.Hide(); // ẩn form hiện tại
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(str); // khởi tạo biến kết nối SQL 
                conn.Open(); // mở đường dẫn SQL 

                if (string.IsNullOrEmpty(txt_TenDangNhap.Text) || txt_TenDangNhap.Text.Length < 5)
                {
                    MessageBox.Show("Tên đăng nhập không hợp lệ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(txt_MatKhau.Text) || txt_MatKhau.Text.Length < 5)
                {
                    MessageBox.Show("Mật khẩu không hợp lệ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(txt_XacNhanMK.Text) || txt_XacNhanMK.Text != txt_MatKhau.Text)
                {
                    MessageBox.Show("Xác nhận lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txt_SDT.Text.Length < 10 || txt_SDT.Text.Length > 11 || !int.TryParse(txt_SDT.Text, out int sdt))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(txt_HoTen.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrEmpty(txt_Email.Text))
                {
                    MessageBox.Show("Vui lòng nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                else
                {
                    // khai báo chuỗi câu lệnh thêm giá trị vào SQL 
                    string insertQuery = "INSERT INTO TaiKhoan (TenDangNhap, MatKhau, SoDienThoai, HoVaTen, Email) VALUES (@TenDn, @MK, @SDT, @HT, @Email)";
                    SqlCommand cmd = new SqlCommand(insertQuery, conn); // khởi tạo biến SqlCommand 

                    // gán lại các giá trị nhập từ textbox vào insertQuery
                    cmd.Parameters.AddWithValue("@TenDn", txt_TenDangNhap.Text);
                    cmd.Parameters.AddWithValue("@MK", txt_MatKhau.Text);
                    cmd.Parameters.AddWithValue("@SDT", txt_SDT.Text);
                    cmd.Parameters.AddWithValue("@HT", txt_HoTen.Text);
                    cmd.Parameters.AddWithValue("@Email", txt_Email.Text);

                    // dùng để chạy câu lệnh thêm dữ liệu vào SQL 
                    cmd.ExecuteNonQuery();
                    conn.Close(); // đóng kết nối

                    MessageBox.Show("Đăng kí thành công(Đăng nhập tại form đăng nhập)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);

                    // khi hoàn thành đăng kí sẽ mở ra form đăng nhập 
                    frm_DangNhap frm_DangNhap = new frm_DangNhap();
                    frm_DangNhap.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex); // bẫy lỗi 
                //PUSH NHÁNH SỬA CỦA TAO NÈ
            }


        }

        private void chk_HienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_HienThiMK.Checked)
            {

                txt_MatKhau.UseSystemPasswordChar = false; // để hiển thị mật khẩu nếu chk_HienThiMK.Checked = true
                txt_XacNhanMK.UseSystemPasswordChar = false;
            }
            else
            {
                txt_MatKhau.UseSystemPasswordChar = true; // để ẩn mật khẩu nếu chk_HienThiMK.Checked = false
                txt_XacNhanMK.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lab_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); // tắt form đăng kí
        }
    }
}