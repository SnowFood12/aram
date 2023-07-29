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
    public partial class frm_SanPham : Form
    {
        string str = "Data Source=.;Initial Catalog=SNOWFOOD;Integrated Security=True";
        SqlConnection conn = null;
        public frm_SanPham()
        {
            InitializeComponent();



        }
        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(str);
                conn.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            string strcmd = @"select * from SanPham";
            SqlCommand cmd = new SqlCommand(strcmd, conn);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable adt_SaPham = new DataTable();
            adt.Fill(adt_SaPham);
            dgv_dsSanPhan.DataSource = adt_SaPham;
        }





    }
}
