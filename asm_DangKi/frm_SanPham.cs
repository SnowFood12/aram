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
            ketNoiCSDL();
            string strcmd = @"select * from SanPham";
            SqlCommand cmd = new SqlCommand(strcmd, conn);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable adt_SaPham = new DataTable();
            adt.Fill(adt_SaPham);
            dgv_dsSanPhan.DataSource = adt_SaPham;
            //tạo 1 list để lưu các tình trạng
            List<string> list = new List<string>()
            {

                "Còn tốt",
                "Sắp hết hạn",
                "Hết hạn"
            };
            List<string> listTT = new List<string>()
            {
                "Tất cả",
                "Còn tốt",
                "Sắp hết hạn",
                "Hết hạn"
            };
            cbo_tinhTrang.Items.Clear();
            cbo_tinhTrang.DataSource = list;
            cbo_timTT.Items.Clear();
            cbo_timTT.DataSource = listTT;
            //Khi load form thì combobox sẽ hiển thị tất cả
            cbo_tinhTrang.SelectedIndex = 0;
            cbo_timTT.SelectedIndex = 0;
            btn_resetTim.Visible = false;
        }
        private void ketNoiCSDL()
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
        }
        private void tim()
        {
            btn_resetTim.Visible = true;
            string ma = txt_timMa.Text.ToLower();
            string ten = txt_timTen.Text.ToLower();
            string slMin = txt_timSLmin.Text.ToLower().ToString();
            string slMax = txt_timSLmax.Text.ToLower().ToString();
            string giaMin = txt_timGiaMin.Text.ToLower().ToString();
            string giaMax = txt_timGiaMax.Text.ToLower().ToString();
            string tinhTrang = cbo_timTT.Text.ToLower().ToString();
            string strcmd = @"select * from SanPham";
            bool kt = false;
            if (!string.IsNullOrEmpty(ma))
            {
                strcmd += $@" where MaSanPham like '%{ma}%'";
                kt = true;
            }
            if (!string.IsNullOrEmpty(ten))
            {
                if (kt)
                {
                    strcmd += " and";
                }
                else
                {
                    strcmd += " where";
                }
                strcmd += $@" TenSanPham like N'%{ten}%'";
                kt = true;
            }
            //
            if (!string.IsNullOrEmpty(slMin) && !string.IsNullOrEmpty(slMax))
            {
                if (kt)
                {
                    strcmd += " and";
                }
                else
                {
                    strcmd += " where";
                }
                strcmd += $@" SoLuong between '{slMin}' and '{slMax}'";
                kt = true;
            }
            if (!string.IsNullOrEmpty(slMin) && string.IsNullOrEmpty(slMax))
            {
                slMax = "200";
                if (kt)
                {
                    strcmd += " and";
                }
                else
                {
                    strcmd += " where";
                }
                strcmd += $@" SoLuong between '{slMin}' and '{slMax}'";
                kt = true;
            }
            if (string.IsNullOrEmpty(slMin) && !string.IsNullOrEmpty(slMax))
            {
                slMin = "0";
                if (kt)
                {
                    strcmd += " and";
                }
                else
                {
                    strcmd += " where";
                }
                strcmd += $@" SoLuong between '{slMin}' and '{slMax}'";
                kt = true;
            }
            //
            if (!string.IsNullOrEmpty(giaMin) && !string.IsNullOrEmpty(giaMax))
            {
                if (kt)
                {
                    strcmd += " and";
                }
                else
                {
                    strcmd += " where";
                }
                strcmd += $@" GiaBan between '{giaMin}' and '{giaMax}'";
                kt = true;
            }
            if (!string.IsNullOrEmpty(giaMin) && string.IsNullOrEmpty(giaMax))
            {
                giaMax = int.MaxValue.ToString();
                if (kt)
                {
                    strcmd += " and";
                }
                else
                {
                    strcmd += " where";
                }
                strcmd += $@" GiaBan between '{giaMin}' and '{giaMax}'";
                kt = true;
            }
            if (string.IsNullOrEmpty(giaMin) && !string.IsNullOrEmpty(giaMax))
            {
                giaMin = "0";
                if (kt)
                {
                    strcmd += " and";
                }
                else
                {
                    strcmd += " where";
                }
                strcmd += $@" GiaBan between '{giaMin}' and '{giaMax}'";
                kt = true;
            }
            if (cbo_timTT.SelectedIndex != 0)
            {
                if (kt)
                {
                    strcmd += " and";
                }
                else
                {
                    strcmd += " where";
                }
                strcmd += $@" TinhTrang = N'{tinhTrang}'";
            }
            dgv_dsSanPhan.DataSource = find(strcmd);
        }
        private DataTable find(string strcmd)
        {
            ketNoiCSDL();
            SqlCommand cmd = new SqlCommand(strcmd, conn);
            SqlDataAdapter adt = new SqlDataAdapter(cmd);
            DataTable dt_SaPham = new DataTable();
            adt.Fill(dt_SaPham);
            return dt_SaPham;
        }

        private void txt_timMa_TextChanged(object sender, EventArgs e)
        {
            tim();
        }

        private void txt_timTen_TextChanged(object sender, EventArgs e)
        {
            tim();
        }

        private void txt_timSLmin_TextChanged(object sender, EventArgs e)
        {
            tim();
        }

        private void txt_timSLmax_TextChanged(object sender, EventArgs e)
        {
            tim();
        }

        private void txt_timGiaMin_TextChanged(object sender, EventArgs e)
        {
            tim();
        }

        private void txt_timGiaMax_TextChanged(object sender, EventArgs e)
        {
            tim();
        }
        private void btn_resetTim_Click(object sender, EventArgs e)
        {
            //xoá toàn bộ dữ liệu trong textbox và đặt combobox về tất cả
            txt_timMa.Text = "";
            txt_timTen.Text = "";
            txt_timSLmin.Text = "";
            txt_timSLmax.Text = "";
            txt_timGiaMin.Text = "";
            txt_timGiaMax.Text = "";
            cbo_timTT.SelectedIndex = 0;
            //ẩn nút reset
            btn_resetTim.Visible = false;
        }
        int index;
        private void dgv_dsSanPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy dữ liệu từ datagridview đổ vào textbox
            index = e.RowIndex;
            if (index >= 0 && index < dgv_dsSanPhan.Rows.Count - 1)
            {
                txt_tenSP.Text = dgv_dsSanPhan.Rows[index].Cells["TenSanPham"].Value.ToString();
                txt_sl.Text = dgv_dsSanPhan.Rows[index].Cells["GiaBan"].Value.ToString();
                txt_gia.Text = dgv_dsSanPhan.Rows[index].Cells["GiaBan"].Value.ToString();
                dtm_ngayNhapKho.Value = DateTime.Parse(dgv_dsSanPhan.Rows[index].Cells["NgayNhapKho"].Value.ToString());
                dtm_ngaySanXuat.Value = DateTime.Parse(dgv_dsSanPhan.Rows[index].Cells["NgaySanXuat"].Value.ToString());
                dtm_hanSuDung.Value = DateTime.Parse(dgv_dsSanPhan.Rows[index].Cells["HanSuDung"].Value.ToString());
                cbo_tinhTrang.Text = dgv_dsSanPhan.Rows[index].Cells["TinhTrang"].Value.ToString();
                txt_ghiChu.Text = dgv_dsSanPhan.Rows[index].Cells["GhiChu"].Value.ToString();
                btn_sua.Enabled = true;
                //Hiện nút reset
                btn_resetgrp.Enabled = true;
                btn_xoa.Enabled = true;
                btn_them.Enabled = false;
            }
            else
            {
                reset_grpSP();
            }

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            ketNoiCSDL();
            string strcmd = @"select * from SanPham";
            SqlDataAdapter adt = new SqlDataAdapter(strcmd, conn);
            SqlCommandBuilder cmdB = new SqlCommandBuilder(adt);
            DataSet ds = new DataSet();
            adt.Fill(ds, "SanPham");
            dgv_dsSanPhan.DataSource = ds.Tables["SanPham"];
            DataRow _row = ds.Tables["SanPham"].NewRow();
            /*MessageBox.Show(dtm_ngayNhapKho.Text);*/
            //mã sản phẩm bằng số dòng trong datagridview + 1
            _row["MaSanPham"] = "SP" + dgv_dsSanPhan.Rows.Count.ToString("D3");
            _row["TenSanPham"] = txt_tenSP.Text;

            try
            {
                _row["SoLuong"] = txt_sl.Text;
                if (int.Parse(txt_sl.Text) < 0)
                {
                    MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Số lượng phải là số và không đươc để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _row["GiaBan"] = txt_gia.Text;
                //nếu giá bán nhỏ hơn 0 thì hiện thông báo
                if (int.Parse(txt_gia.Text) < 0)
                {
                    MessageBox.Show("Giá bán phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Giá bán phải là số và không đươc để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _row["NgayNhapKho"] = dtm_ngayNhapKho.Text;
            _row["NgaySanXuat"] = dtm_ngaySanXuat.Text;
            _row["HanSuDung"] = dtm_hanSuDung.Text;
            _row["TinhTrang"] = cbo_tinhTrang.Text;
            _row["GhiChu"] = txt_ghiChu.Text;
            ds.Tables["SanPham"].Rows.Add(_row);
            adt.Update(ds.Tables["SanPham"]);
            //thêm thành công thì hiện thông báo
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            conn.Close();
            /*reset_grpSP();*/
        }

        private void cbo_timTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            tim();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //sửa dữ liệu trong datagridview
            ketNoiCSDL();
            string strcmd = @"select * from SanPham";
            SqlDataAdapter adt = new SqlDataAdapter(strcmd, conn);
            SqlCommandBuilder cmdB = new SqlCommandBuilder(adt);
            DataSet ds = new DataSet();
            adt.Fill(ds, "SanPham");
            dgv_dsSanPhan.DataSource = ds.Tables["SanPham"];
            //sử dụng dataRow để sửa dữ liệu
            DataRow _row = ds.Tables["SanPham"].Rows[index];//lấy dòng hiện tại
            _row["TenSanPham"] = txt_tenSP.Text;
            _row["GiaBan"] = txt_gia.Text;
            _row["SoLuong"] = txt_sl.Text;
            _row["NgayNhapKho"] = dtm_ngayNhapKho.Text;
            _row["NgaySanXuat"] = dtm_ngaySanXuat.Text;
            _row["HanSuDung"] = dtm_hanSuDung.Text;
            _row["TinhTrang"] = cbo_tinhTrang.Text;
            _row["GhiChu"] = txt_ghiChu.Text;
            _row.EndEdit();//kết thúc việc chỉnh sửa
            adt.Update(ds.Tables["SanPham"]);
            //sửa thành công thì hiện thông báo
            btn_sua.Enabled = false;
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
            conn.Close();
            reset_grpSP();
        }
        private void reset_grpSP()
        {
            btn_sua.Enabled = false;
            txt_tenSP.Text = "";
            txt_gia.Text = "";
            txt_sl.Text = "";
            dtm_ngayNhapKho.Value = DateTime.Now;
            dtm_ngaySanXuat.Value = DateTime.Now;
            dtm_hanSuDung.Value = DateTime.Now;
            cbo_tinhTrang.SelectedIndex = 0;
            txt_ghiChu.Text = "";
            btn_resetgrp.Enabled = false;
            btn_xoa.Enabled = false;
            btn_them.Enabled = true;
        }

        private void btn_resetgrp_Click(object sender, EventArgs e)
        {
            reset_grpSP();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //Xoá dữ liệu trong datagridview
            ketNoiCSDL();
            string strcmd = @"select * from SanPham";
            SqlDataAdapter adt = new SqlDataAdapter(strcmd, conn);
            SqlCommandBuilder cmdB = new SqlCommandBuilder(adt);
            DataSet ds = new DataSet();
            adt.Fill(ds, "SanPham");
            dgv_dsSanPhan.DataSource = ds.Tables["SanPham"];
            //sử dụng dataRow để xoá dữ liệu
            DataRow _row = ds.Tables["SanPham"].Rows[index];//lấy dòng hiện tại
            _row.Delete();//xoá dòng hiện tại
            adt.Update(ds.Tables["SanPham"]);
            //xoá thành công thì hiện thông báo
            MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK);
            conn.Close();
            reset_grpSP();
        }

        private void txt_timSLmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ngăn không cho ký tự được nhập vào TextBox
                e.Handled = true;
            }
        }

        private void txt_timSLmax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ngăn không cho ký tự được nhập vào TextBox
                e.Handled = true;
            }
        }

        private void txt_timGiaMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ngăn không cho ký tự được nhập vào TextBox
                e.Handled = true;
            }
        }

        private void txt_timGiaMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Ngăn không cho ký tự được nhập vào TextBox
                e.Handled = true;
            }
        }
    }
}
