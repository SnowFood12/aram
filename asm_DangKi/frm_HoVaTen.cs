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
    public partial class frm_HoVaTen : Form
    {
        public frm_HoVaTen()
        {
            InitializeComponent();
        }

        string str = "Data Source=.;Initial Catalog=SNOWFOOD;Integrated Security=True"; // khai báo chuỗi liên kết 
        SqlConnection conn = null;

        public static string TenDangNhapHoVaTen { get; set; }


        public void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();

                    txt_MatKhau.UseSystemPasswordChar = true;

                    string query = "SELECT HoVaTen  FROM TaiKhoan WHERE TenDangNhap = @TenDangNHap";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenDangNHap", TenDangNhapHoVaTen);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                txt_HoVaTen.Text = reader["HoVaTen"].ToString();

                            }
                        }
                    }

                    txt_MatKhau.Text = "";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối bị lỗi: " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frm_NhanVien nhanVien = new frm_NhanVien();
            nhanVien.Show();
            this.Hide();
        }

        private void btn_SuaHoVaTen_Click(object sender, EventArgs e)
        {
            try
            {
                // Khởi tạo đối tượng SqlConnection và mở kết nối
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();


                    if (string.IsNullOrWhiteSpace(txt_MatKhau.Text) || string.IsNullOrWhiteSpace(txt_HoVaTen.Text))
                    {
                        MessageBox.Show("Không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (txt_HoVaTen.Text.Length < 7 || txt_HoVaTen.Text.Length > 40)
                    {
                        MessageBox.Show("Họ va tên không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (txt_MatKhau.Text.Length < 5 || txt_MatKhau.Text.Length > 20)
                    {
                        MessageBox.Show("Mật khẩu Không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        string soMoi = "UPDATE TaiKhoan SET HoVaTen = @hoVaTen WHERE MatKhau = @matKhau";


                        SqlCommand cmd = new SqlCommand(soMoi, conn);
                        cmd.Parameters.AddWithValue("@hoVaTen", txt_HoVaTen.Text);
                        cmd.Parameters.AddWithValue("@matKhau", txt_MatKhau.Text);


                        int kt = cmd.ExecuteNonQuery();

                        if (kt > 0)
                        {
                            MessageBox.Show("Lưu thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Thay đổi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_HoVaTen_Load(object sender, EventArgs e)
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
