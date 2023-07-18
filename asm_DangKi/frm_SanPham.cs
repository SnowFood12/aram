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

        }

    
        


    }
}
