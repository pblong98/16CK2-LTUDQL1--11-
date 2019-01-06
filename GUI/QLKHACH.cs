using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16CK2_LTUDQL1__11_
{
	public partial class QLKHACH : Form
	{
		BUS.Bus bus;
		public QLKHACH()
		{
			InitializeComponent();
			bus = new BUS.Bus();
			LoadDSKhachHang();
		}

		void LoadDSKhachHang()
		{
			dsKhachGridView.DataSource = bus.dsKhachHang();
			dsKhachGridView.Columns[0].HeaderText = "ID";
			dsKhachGridView.Columns[1].HeaderText = "Họ tên";
			dsKhachGridView.Columns[2].HeaderText = "Điện thoại";
			dsKhachGridView.Columns[3].HeaderText = "Email";
			dsKhachGridView.Columns[4].HeaderText = "Loại";
		}

		private void QLKHACH_BTN_Click(object sender, EventArgs e)
		{
			LoadDSKhachHang();
		}

		private void BANVE_BTN_Click(object sender, EventArgs e)
		{
			QLVE form = new QLVE();
			form.Show();
			this.Close();
		}

		private void QLTUYENXE_BTN_Click(object sender, EventArgs e)
		{
			QLTUYENXE form = new QLTUYENXE();
			form.Show();
			this.Close();
		}

		private void QLCHUYENXE_BTN_Click(object sender, EventArgs e)
		{
			QLCHUYENXEcs form = new QLCHUYENXEcs();
			form.Show();
			this.Close();
		}

		private void CLOSE_BTN_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ThemKH_BTN_Click(object sender, EventArgs e)
		{
			if(!KiemTraDuLieuNhapVao())
			{
				MessageBox.Show("Bạn nhập thiếu hoặc sai dữ liệu !");
				return;
			}
			bus.themKhachHang2(hoten_txt.Text, sdt_txt.Text, email_txt.Text, loai_cbb.Text[0] + "");
			LoadDSKhachHang();
		}

		private void xoakh_btn_Click(object sender, EventArgs e)
		{
			try
			{
				bus.xoaKhachHang(dsKhachGridView.Rows[dsKhachGridView.CurrentRow.Index].Cells[0].Value.ToString());
				LoadDSKhachHang();
			}
			catch
			{
				MessageBox.Show("Không xóa được mục này. Có vẻ như bạn phải hủy vé của khách hàng này trước khi muốn xóa tài khoản của họ !"); ;
			}
		}

		private void SuaBTN_Click(object sender, EventArgs e)
		{
			if (!KiemTraDuLieuNhapVao())
			{
				MessageBox.Show("Bạn nhập thiếu hoặc sai dữ liệu !");
				return;
			}
			bus.updateKhachHang(dsKhachGridView.Rows[dsKhachGridView.CurrentRow.Index].Cells[0].Value.ToString(), hoten_txt.Text, email_txt.Text, sdt_txt.Text, loai_cbb.Text);
			LoadDSKhachHang();

		}

		public bool KiemTraDuLieuNhapVao()
		{
			if (string.IsNullOrWhiteSpace(hoten_txt.Text) || string.IsNullOrWhiteSpace(email_txt.Text) || string.IsNullOrWhiteSpace(sdt_txt.Text) || string.IsNullOrWhiteSpace(loai_cbb.Text))
			{
				return false;
			}

			if(!int.TryParse(sdt_txt.Text, out int s))
			{
				return false;
			}
			return true;
		}

		private void find_btn_Click(object sender, EventArgs e)
		{
			dsKhachGridView.DataSource = bus.timKhach(find_txt.Text);
		}
	}
}
