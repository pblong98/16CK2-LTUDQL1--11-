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
	public partial class QLTUYENXE : Form

	{
        Bus bus =new Bus();
		public QLTUYENXE()
		{
			InitializeComponent();
		}
        public void reLoad()
        {
            dgvTuyenXe.DataSource = bus.loadTuyen();
            cbTram1.DataSource = bus.loadTram();
            cbTram2.DataSource = bus.loadTram();
            cbTramTrungGian.DataSource = bus.loadTramTG();
        }
		private void BANVE_BTN_Click(object sender, EventArgs e)
		{
			QLVE form = new QLVE();
			form.Show();
			this.Close();
		}

		private void QLKHACH_BTN_Click(object sender, EventArgs e)
		{
			QLKHACH form = new QLKHACH();
			form.Show();
			this.Close();
		}

		private void CHUYENXE_BTN_Click(object sender, EventArgs e)
		{
			QLCHUYENXEcs form = new QLCHUYENXEcs();
			form.Show();
			this.Close();
		}

		private void CLOSE_BTN_Click(object sender, EventArgs e)
		{
			this.Close();
            Application.Exit();
        }

        private void QLTUYENXE_Load(object sender, EventArgs e)
        {
            reLoad();
        }

        private void dgvTuyenXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CurrentIndex =dgvTuyenXe.CurrentCell.RowIndex;
            txtID.Text = dgvTuyenXe.Rows[CurrentIndex].Cells["ID"].Value.ToString();
            txtKhoanCach.Text = dgvTuyenXe.Rows[CurrentIndex].Cells["KhoanCach"].Value.ToString();
            txtThoiGian.Text= dgvTuyenXe.Rows[CurrentIndex].Cells["ThoiGianChay"].Value.ToString();
            txtTenTuyen.Text = dgvTuyenXe.Rows[CurrentIndex].Cells["TenTuyen"].Value.ToString();
            cbTram1.Text = dgvTuyenXe.Rows[CurrentIndex].Cells["Tram1"].Value.ToString();
            cbTram2.Text = dgvTuyenXe.Rows[CurrentIndex].Cells["Tram2"].Value.ToString();         
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TuyenXe tx = new TuyenXe();
            tx.IdTuyen = txtID.Text;
            tx.KhoanCach =Convert.ToDouble( txtKhoanCach.Text.ToString());
            tx.ThoiGian = txtThoiGian.Text;
            tx.TenTuyen = txtTenTuyen.Text;
            tx.Tram1=cbTram1.Text;
            tx.Tram2 = cbTram2.Text;
            bus.themTuyen(tx);
            reLoad();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int CurrentIndex = dgvTuyenXe.CurrentCell.RowIndex;
            int ID = Convert.ToInt32(dgvTuyenXe.Rows[CurrentIndex].Cells["ID"].Value.ToString());
            bus.xoaTuyen(ID);
            reLoad();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TuyenXe tx = new TuyenXe();          
            tx.IdTuyen = txtID.Text;
            tx.KhoanCach= Convert.ToDouble(txtKhoanCach.Text.ToString());
            tx.ThoiGian = txtThoiGian.Text;
            tx.Tram1 = cbTram1.Text;
            tx.Tram2 = cbTram2.Text;
            tx.TenTuyen= txtTenTuyen.Text;
            bus.suaTuyen(tx);
            reLoad();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số");
            }
        }

        private void txtKhoanCach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng nhập số");
            }
        }

        private void txtTimTen_TextChanged(object sender, EventArgs e)
        {
            string ten = txtTimTen.Text.ToString();
           dgvTuyenXe.DataSource= bus.timTuyen(ten);
        }
    }
}
