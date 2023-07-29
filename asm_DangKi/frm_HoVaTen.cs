using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void label3_Click(object sender, EventArgs e)
        {
            frm_NhanVien nhanVien = new frm_NhanVien();
            nhanVien.Show();
            this.Hide();
        }
    }
}
