using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace asm_DangKi
{
    public partial class frm_DonHang : Form
    {
        string str = "Data Source=.;Initial Catalog=SNOWFOOD;Integrated Security=True   "; 
        SqlConnection conn = null;
        public frm_DonHang()
        {
            InitializeComponent();
            LoadDuLieuVaocbo_SanPham(); 
        }
        void LoadDuLieuVaocbo_SanPham()
        {
            using ( conn = new SqlConnection(str))
            {
                string query = "select * from SanPham";
                SqlDataAdapter _adapter = new SqlDataAdapter ( query, conn );
                DataSet _dataset = new DataSet();
                _adapter.Fill(_dataset , "SanPham");

                cbo_LuaChonSanPham.DataSource = _dataset.Tables["SanPham"];
                cbo_LuaChonSanPham.DisplayMember = "TenSanPham";
                cbo_LuaChonSanPham.ValueMember = "MaSanPham"; 
            }
        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void cbo_LuaChonSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            using ( conn = new SqlConnection (str))
            {
                conn.Open();
                string query = "select * from SanPham where MaSanPham = @ma"; 
                SqlCommand cmd = new SqlCommand(query, conn);   
                cmd.Parameters.AddWithValue("@ma" , cbo_LuaChonSanPham.SelectedValue.ToString());
                SqlDataReader reader = cmd.ExecuteReader();
                if ( reader.Read())
                {
                    txt_DonGia.Text = reader["GiaBan"].ToString();
                    txt_HangTonKho.Text = reader["SoLuong"].ToString(); 
                }
            }
        }
    }
}
