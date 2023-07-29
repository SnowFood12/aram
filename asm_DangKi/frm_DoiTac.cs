using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
        public void load_dvg_DanhSach()
        {
            ketnoi();
            string strcmd = @"select*from DoiTac";
            std = new SqlDataAdapter(strcmd, conn);
            SqlCommandBuilder cmd = new SqlCommandBuilder(std);
            DataSet DS = new DataSet();
            std.Fill(DS, "DoiTac");
            dgv_DanhSach.DataSource = DS.Tables["DoiTac"];
            dgv_DSDTAC.DataSource = DS.Tables["DoiTac"];
            if (!rdo_ma.Checked || !rdo_ten.Checked || !rdo_sdt.Checked)
            {
                dgv_DSDTAC.DataSource = null;
            }
            conn.Close();
        }
        public void trong()
        {
            txt_MaDoiTac.Text = "";
            txt_TenDoiTac.Text = "";
            txt_DiaChi.Text = "";
            txt_SoDienThoai.Text = "";
            txt_Email.Text = "";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            ketnoi();
            txt_MaDoiTac.Enabled = true;
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
                trong();
            }
            catch (Exception)
            {
                trong();
                MessageBox.Show("Không có dữ liệu được thêm vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
        }
        private void dgv_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ketnoi();
            try
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
            catch (Exception)
            {
                MessageBox.Show("hãy chọn vào dữ liệu cần thao tác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {

            ketnoi();
            try
            {
                if (txt_MaDoiTac.Text.Trim() == "" || txt_TenDoiTac.Text.Trim() == ""|| txt_DiaChi.Text.Trim() == "" ||txt_SoDienThoai.Text.Trim() == "" ||txt_Email.Text.Trim() == "")
                {
                    MessageBox.Show("hãy nhập đây đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
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
                    DialogResult result = MessageBox.Show("bạn chắc chắn muốn cập nhật", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        //thực thi câu truy vấn xóa dữ liệu
                        int RowsAffected = std.Update(ds.Tables["DoiTac"]);
                        if (RowsAffected > 0)
                        {
                            load_dvg_DanhSach();
                            trong();
                            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("không có dữ liệu nào được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }               
            }
            catch (Exception)
            {
                MessageBox.Show("hãy chọn đối tác muốn cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            ketnoi();
            try
            {             
                DataSet ds = new DataSet();
                std.Fill(ds, "DoiTac");
                DataRow _row = ds.Tables["DoiTac"].Rows[ViTri];
                _row.Delete();
                DialogResult result = MessageBox.Show("bạn chắc chắn muốn xóa", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //thực thi câu truy vấn xóa dữ liệu
                    int RowsAffected = std.Update(ds.Tables["DoiTac"]); 
                    if (RowsAffected > 0) 
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
                MessageBox.Show("hãy chọn đối tác muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        private void frm_DoiTac_Load(object sender, EventArgs e)
        {
            load_dvg_DanhSach();
        }   
        private void txt_timDT_TextChanged(object sender, EventArgs e)
        {
            ketnoi();
            try
            {              
                string tim = txt_timDT.Text.Trim();             
                if (rdo_ma.Checked)
                {
                    string query = "SELECT * FROM DoiTac WHERE MaDoiTac LIKE @tim ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tim", tim + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgv_DSDTAC.DataSource = dt;
                    }
                    return;
                }
                if (rdo_ten.Checked)
                {
                    string query = "SELECT * FROM DoiTac WHERE TenDoiTac LIKE @tim";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tim", tim + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgv_DSDTAC.DataSource = dt;
                    }
                    return;
                } 
                if (rdo_sdt.Checked)
                {
                    string query = "SELECT * FROM DoiTac WHERE SoDT LIKE @tim";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@tim", tim + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgv_DSDTAC.DataSource = dt;
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi"+ex, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        private void rdo_ma_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void rdo_ten_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void rdo_sdt_CheckedChanged(object sender, EventArgs e)
        { 
        }
    }
    
}
