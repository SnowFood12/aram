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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace asm_DangKi
{
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        string str = "Data Source=.;Initial Catalog=SNOWFOOD;Integrated Security=True"; // khai báo chuỗi liên kết 
        SqlConnection conn = null; // khai báo biến liên kết 

        public void LoadData()
        {
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                txt_MatKhau.UseSystemPasswordChar = true;
                string query = "SELECT TenDangNhap, SoDienThoai, HoVaTen, Email, MatKhau FROM TaiKhoan";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lbl_taiKhoan.Text = frm_DangNhap.TenDangNhap;
                    lbl_soDienThoai.Text = frm_DangNhap.SoDienThoai;
                    lbl_hoVaTen.Text = frm_DangNhap.HoVaTen;
                    lbl_Email.Text = frm_DangNhap.Email;
                    txt_MatKhau.Text = frm_DangNhap.MatKhau;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối bị lỗi: " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_SuaTenDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SuaMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void btn_suaTenDangNhap_Click(object sender, EventArgs e)
        {
            frm_TenDangNhap TenDangNhap = new frm_TenDangNhap();
            TenDangNhap.Show();
            this.Hide();


        }

        private void lbl_tenDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void btn_SuaMatKhau_Click(object sender, EventArgs e)
        {
            frm_SuaMatKhau SuaMatKhau = new frm_SuaMatKhau();
            SuaMatKhau.Show();
            this.Hide();
        }

        private void btn_SuaHoVaTen_Click(object sender, EventArgs e)
        {
            frm_HoVaTen hoVaTen = new frm_HoVaTen();
            hoVaTen.Show();
            this.Hide();
        }



        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void frm_NhanVien_Load(object sender, EventArgs e)
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

        private void btn_ThayDoiAnh_Click(object sender, EventArgs e)
        {


            try
            {

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png|All files (*.*)|*.*";
                // Kiểm tra đã chọn tập tin ảnh hay chưa
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Lấy đường dẫn =
                    string duongDanAnh = dialog.FileName;

                    // Gán hình ảnh vào PictureBox
                    pic_thongTinTaiKhoan.ImageLocation = duongDanAnh;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Thay đổi ảnh bị lỗi ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txt_MatKhau.Text != null)
            {
                txt_MatKhau.UseSystemPasswordChar = true; // hiển thị mật khẩu khi chk_HienThiMK.Checked = true 
            }
            else
            {
                txt_MatKhau.UseSystemPasswordChar = false; // ẩn mật khẩu khi chk_HienThiMK.Checked = false 
            }
        }

        private void btn_MatKhau_Click(object sender, EventArgs e)
        {
            frm_MatKhau matKhau = new frm_MatKhau();
            matKhau.Show();
            this.Hide();

        }

        private void btn_SuaSoDienThoai_Click(object sender, EventArgs e)
        {
            frm_SoDienThoai sdt = new frm_SoDienThoai();
            sdt.Show();
            this.Hide();
        }

        private void btn_SuaEmail_Click(object sender, EventArgs e)
        {
            frm_Email email = new frm_Email();
            email.Show();
            this.Hide();
        }

        private void lbl_trangChu_Click(object sender, EventArgs e)
        {
            frm_TrangChu trangChu = new frm_TrangChu();
            trangChu.Show();
            this.Hide();

        }
    }
}
