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
    public partial class frm_KiemKho : Form
    {
        public string HoVaTen { get; set; }
        public frm_KiemKho()
        {
            InitializeComponent();
            lbl_ThoiGianKiem.Text = DateTime.Now.ToString();
            lbl_HienTen.Text = HoVaTen;
            Load_dgv_DanhSachSanPham();

        }
        SqlConnection conn = null;
        string strconn = "Data Source=.;Initial Catalog=SNOWFOOD;Integrated Security=True";
        private SqlDataAdapter dataAdapter;
        private DataTable table;
        public void Load_dgv_DanhSachSanPham()
        {
            try
            {
                conn = new SqlConnection(strconn);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi rồi mau fix đê");
                MessageBox.Show(ex.Message);
            }
            string strcmd = @"Select * from SanPham";
            SqlCommand cmd = new SqlCommand(strcmd, conn);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adt.Fill(ds, "SanPham");
            dgv_DanhSachSanPham.DataSource = ds.Tables["SanPham"];
            conn.Close();
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            Load_dgv_DanhSachSanPham();
        }

        private void frm_KiemKho_Load(object sender, EventArgs e)
        {

            Load_dgv_DanhSachSanPham();
        }

        private void btn_LoaiBo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn loại bỏ những sản phẩm hết hạn này không này không? ", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                // Lấy danh sách các sản phẩm còn tốt nhưng thời gian sử dụng đã hết
                string query = "SELECT * FROM SanPham WHERE TinhTrang = N'Còn tốt' AND HanSuDung < GETDATE()";
                using (SqlConnection conn = new SqlConnection(strconn))
                {
                    dataAdapter = new SqlDataAdapter(query, conn);
                    table = new DataTable();
                    dataAdapter.Fill(table);
                }

                // Hiển thị danh sách sản phẩm lên DataGridView
                dgv_DanhSachSanPham.DataSource = table;

                // Cho phép chỉnh sửa tình trạng của các sản phẩm có thời gian sử dụng đã hết
                dgv_DanhSachSanPham.Columns["TinhTrang"].ReadOnly = false;
            }
        }
    }
}
