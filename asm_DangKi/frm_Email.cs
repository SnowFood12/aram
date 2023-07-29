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

        string str = "Data Source=LAPTOP-JAKJA372\\TAIMAIKHONGDUOC;Initial Catalog=SNOWFOOD;Integrated Security=True"; // khai báo chuỗi liên kết 
        SqlConnection conn = null;

        public void LoadForm()
        {
            try
            {


                conn = new SqlConnection(str);
                conn.Open();

                string xuatSDT = @"SELECT Email  FROM TaiKhoan";

                SqlCommand cmd = new SqlCommand(xuatSDT, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_EmailCu.Text = reader["Email"].ToString();
                }
                reader.Close();

                txt_EmailMoi.Text = "";
                txt_MatKhau.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi ");
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
                    }
                    if (txt_EmailMoi.Text.Length < 8)
                    {
                        MessageBox.Show("Email không hợp lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (txt_MatKhau.Text.Length < 5)
                    {
                        MessageBox.Show("Mật khẩu phải >5 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void frm_Email_Load(object sender, EventArgs e)
        {
            try
            {
               
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

    }
}
