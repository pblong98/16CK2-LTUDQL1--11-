using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace _16CK2_LTUDQL1__11_
{
	public partial class QLCHUYENXEcs : Form
	{
		public QLCHUYENXEcs()
		{
			InitializeComponent();
		}
        Bus bus = new Bus();
		private void TUYENXE_BTN_Click(object sender, EventArgs e)
		{
			QLTUYENXE form = new QLTUYENXE();
			form.Show();
			this.Close();
		}

		private void QLKHACH_BTN_Click(object sender, EventArgs e)
		{
			QLKHACH form = new QLKHACH();
			form.Show();
			this.Close();
		}

		private void BANVE_BTN_Click(object sender, EventArgs e)
		{
			QLVE form = new QLVE();
			form.Show();
			this.Close();
		}

		private void CLOSE_BTN_Click(object sender, EventArgs e)
		{
			this.Close();
            Application.Exit();
        }

        private void QLCHUYENXEcs_Load(object sender, EventArgs e)
        {
            reLoad();
        }
        void reLoad()
        {
            dgvChuyenXe.DataSource = bus.loadChuyen();
            cbTuyenXe.DataSource = bus.loadTenTuyen();
            cbTaiXe.DataSource = bus.loadTenTaiXe();
            cbMaXe.DataSource = bus.loadTenXe();
        }

        private void dgvChuyenXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CurrentIndex =dgvChuyenXe.CurrentCell.RowIndex;
            txtGhiChu.Text = dgvChuyenXe.Rows[CurrentIndex].Cells["GhiChu"].Value.ToString();
            txtMaChuyen.Text= dgvChuyenXe.Rows[CurrentIndex].Cells["Chuyen"].Value.ToString();
            cbTuyenXe.Text = dgvChuyenXe.Rows[CurrentIndex].Cells["Tuyen"].Value.ToString();
            cbMaXe.Text = dgvChuyenXe.Rows[CurrentIndex].Cells["MaXe"].Value.ToString();
            cbTaiXe.Text= dgvChuyenXe.Rows[CurrentIndex].Cells["TaiXe"].Value.ToString();
            DateTime a = new DateTime();
            a = Convert.ToDateTime(dgvChuyenXe.Rows[CurrentIndex].Cells["GioKhoiHanh"].Value);
            dtpThoiGian.ShowUpDown = true;
            dtpThoiGian.Value = a;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChuyenXe cx = new ChuyenXe();
            cx.ChuyenID = txtMaChuyen.Text.ToString();
            cx.Tuyen = cbTuyenXe.Text.ToString();
            cx.Xe = cbMaXe.Text.ToString();
            cx.TaiXe = cbTaiXe.Text.ToString();
            cx.GioKhoiHanh = dtpThoiGian.Text.ToString();
            cx.GhiChu = txtGhiChu.Text.ToString();
            bus.themChuyen(cx);
            reLoad();
        }
    }
}
