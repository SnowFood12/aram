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
    public partial class frm_MatKhau : Form
    {
        public frm_MatKhau()
        {
            InitializeComponent();
        }
        string str = "Data Source=LAPTOP-JAKJA372\\TAIMAIKHONGDUOC;Initial Catalog=SNOWFOOD;Integrated Security=True"; // khai báo chuỗi liên kết 
        SqlConnection conn = null; // khai báo biến liên kết 

        private void chk_HienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_HienThiMK.Checked)
            {
                txt_matKhau.UseSystemPasswordChar = false; // hiển thị mật khẩu khi chk_HienThiMK.Checked = true 
            }
            else
            {
                txt_matKhau.UseSystemPasswordChar = true; // ẩn mật khẩu khi chk_HienThiMK.Checked = false 
            }
        }

        private void btn_xacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                using (conn = new SqlConnection(str))
                {
                    conn.Open();

                    string xacnhan = @"SELECT MatKhau FROM TaiKhoan WHERE MatKhau = @matKhau";
                    SqlCommand cmd = new SqlCommand(xacnhan, conn);
                    cmd.Parameters.AddWithValue("@matKhau", txt_matKhau.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Nếu có dữ liệu tức là mật khẩu hợp lệ
                        {
                            frm_SuaMatKhau suaMatKhau = new frm_SuaMatKhau();
                            suaMatKhau.Show();
                            this.Hide();
                        }
                        else 
                        {
                            MessageBox.Show("Sai mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message);
            }


        }

        private void lab_QuenMK_Click(object sender, EventArgs e)
        {
            frm_QuenMK quenMK = new frm_QuenMK();
            quenMK.Show();
            this.Hide();
        }
    }
}
