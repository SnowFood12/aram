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
    public partial class frm_SoDienThoai : Form
    {
        public frm_SoDienThoai()
        {
            InitializeComponent();


        }
        string str = "Data Source=.;Initial Catalog=SNOWFOOD;Integrated Security=True"; // khai báo chuỗi liên kết 
        SqlConnection conn = null;

        public static string TenDangNhaps { get; set; }



        public void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();

                    txt_MatKhau.UseSystemPasswordChar = true;

                    string query = "SELECT SoDienThoai  FROM TaiKhoan WHERE TenDangNhap = @TenDangNHap";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenDangNHap", TenDangNhaps);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                txt_soDienThoai.Text = reader["SoDienThoai"].ToString();

                            }
                        }
                    }


                }
                txt_MatKhau.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối bị lỗi: " + ex.Message);
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
                        MessageBox.Show("Mật khẩu Không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrWhiteSpace(txt_soDienThoai.Text) || txt_soDienThoai.Text.Length != 10)
                    {
                        MessageBox.Show("Số điện Thoại không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (!Regex.IsMatch(txt_soDienThoai.Text, @"^0\d{9,10}$"))
                    {
                        MessageBox.Show("Số điện Thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {

                        string soMoi = "UPDATE TaiKhoan SET SoDienThoai = @soDienThoai WHERE MatKhau = @matKhau";


                        SqlCommand cmd = new SqlCommand(soMoi, conn);
                        cmd.Parameters.AddWithValue("@soDienThoai", txt_soDienThoai.Text);
                        cmd.Parameters.AddWithValue("@matKhau", txt_MatKhau.Text);


                        int kt = cmd.ExecuteNonQuery();

                        if (kt > 0)
                        {
                            MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
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
                conn = new SqlConnection(str);
                conn.Open();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối bị lỗi: " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frm_NhanVien frmNhanVien = new frm_NhanVien();
            // frmNhanVien.MdiParent = this;
            frmNhanVien.Show();
            frmNhanVien.Dock = DockStyle.Fill;

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
