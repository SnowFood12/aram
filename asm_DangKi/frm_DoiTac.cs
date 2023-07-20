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
    public partial class frm_DoiTac : Form
    {
        public frm_DoiTac()
        {
            InitializeComponent();
            load_dvg_DanhSach();
        }
        SqlConnection conn = null;
        string str = "Data Source=DESKTOP-442ME40\\YCHINHMLO;Initial Catalog=SNOWFOOD;Integrated Security=True"; // khai báo chuỗi liên kết  
        SqlDataAdapter std = null;
        int ViTri = -1;
        private bool kiemtrasodienthoai(string sodienthoai)
        {
            if (string.IsNullOrEmpty(sodienthoai))
            {
                return false;
            }

            foreach (char c in sodienthoai)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }

            if (sodienthoai.Length != 10)
            {
                return false;
            }

            return true;
        }
        public void ketnoi()
        {
            try
            {
                conn = new SqlConnection(str); // khởi tạo biến liên kết 
                conn.Open(); // mở liên kết 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex); // bẫy lỗi khi không liên kết được 
            }
        }
        public void load_dvg_DanhSach()
        {
            ketnoi();
            string strcmd = @"select*from DoiTac";
            //xuat nhieu bang
            std = new SqlDataAdapter(strcmd, conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(std);
            DataSet DS = new DataSet();
            std.Fill(DS, "DoiTac");
            dgv_DanhSach.DataSource = DS.Tables["DoiTac"];
            
        }
       
        private void btn_them_Click(object sender, EventArgs e)
        {
          
            string regex = @"^[a-zA-Z0-9.]{3,30}@gmail.com(.vn|)$";
            bool test = Regex.IsMatch(txt_Email.Text, regex);
            if (txt_MaDoiTac.Text.Trim() == ""|| txt_MaDoiTac.Text.Length>5|| txt_MaDoiTac.Text.Length<5)
            {
                MessageBox.Show("Mã không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_TenDoiTac.Text.Trim() == "")
            {
                MessageBox.Show("tên không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txt_DiaChi.Text.Trim() == "")
            {
                MessageBox.Show("địa chỉ không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!kiemtrasodienthoai(txt_SoDienThoai.Text))
            {
                MessageBox.Show("số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!test)
            {
                MessageBox.Show("email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                DataSet ds = new DataSet();
                std.Fill(ds, "DoiTac");
                DataRow _row = ds.Tables["DoiTac"].NewRow();
                _row["MaDoiTac"] = txt_MaDoiTac.Text;
                _row["TenDoiTac"] = txt_TenDoiTac.Text;
                _row["DiaChi"] = txt_DiaChi.Text;
                _row["SoDT"] = txt_SoDienThoai.Text;
                _row["Email"] = txt_Email.Text;
                ds.Tables["DoiTac"].Rows.Add(_row);
                std.Update(ds.Tables["DoiTac"]);
                load_dvg_DanhSach();
                MessageBox.Show("thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                /*conn.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không có dữ liệu được thêm vào"+ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataSet ds = new DataSet();
            std.Fill(ds, "DoiTac");
            ViTri = e.RowIndex;
            DataRow _row = ds.Tables["DoiTac"].Rows[ViTri];
            txt_MaDoiTac.Text = _row["MaDoiTac"].ToString();
            txt_TenDoiTac.Text = _row["TenDoiTac"].ToString();
            txt_DiaChi.Text = _row["DiaChi"].ToString();
            txt_SoDienThoai.Text = _row["SoDT"].ToString();
            txt_Email.Text = _row["Email"].ToString();
            txt_MaDoiTac.Enabled = false;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
           
            try
            {
                DataSet ds = new DataSet();
                std.Fill(ds, "DoiTac");
                DataRow _row = ds.Tables["DoiTac"].Rows[ViTri];
                _row.BeginEdit();
                _row["MaDoiTac"] = txt_MaDoiTac.Text;
                _row["TenDoiTac"] = txt_TenDoiTac.Text;
                _row["DiaChi"] = txt_DiaChi.Text;
                _row["SoDT"] = txt_SoDienThoai.Text;
                _row["Email"] = txt_Email.Text;
                _row.EndEdit();
                std.Update(ds.Tables["DoiTac"]);
                DialogResult result = MessageBox.Show("bạn chắc chắn muốn cập nhật", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //thực thi câu truy vấn xóa dữ liệu
                    int RowsAffected = std.Fill(ds, "DoiTac"); ;
                    if (RowsAffected >= 0)
                    {
                        load_dvg_DanhSach();
                        MessageBox.Show("sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("không có dữ liệu nào được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("hãy chọn đối tác muốn cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                std.Fill(ds, "DoiTac");
                DataRow _row = ds.Tables["DoiTac"].Rows[ViTri];
                _row.Delete();
                std.Update(ds.Tables["DoiTac"]);
                DialogResult result = MessageBox.Show("bạn chắc chắn muốn xóa", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //thực thi câu truy vấn xóa dữ liệu
                    int RowsAffected = std.Fill(ds, "DoiTac"); ;
                    if (RowsAffected >= 0)
                    {
                        load_dvg_DanhSach();
                        MessageBox.Show("xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("không có dữ liệu nào được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("hãy chọn đối tác muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    
}
