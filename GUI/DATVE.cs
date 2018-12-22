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

namespace _16CK2_LTUDQL1__11_
{
    public partial class QLVE : Form
    {
		BUS.BUS bus;


        public QLVE()
        {
			bus = new BUS.BUS();
            InitializeComponent();
			LoadDanhSachTuyenCBB();
			dattructiep_radio.Checked = true;
			loadDSVE();
		}

		void loadDSVE()
		{
			dsve_gridview.DataSource = bus.dsve();
			dsve_gridview.Columns[0].HeaderText = "ID";
			dsve_gridview.Columns[1].HeaderText = "Mã ghế";
			dsve_gridview.Columns[2].HeaderText = "Mã chuyến";
			dsve_gridview.Columns[3].HeaderText = "Giá vé";
			dsve_gridview.Columns[4].HeaderText = "Mã khách";
			dsve_gridview.Columns[5].HeaderText = "Ngày đặt";
			dsve_gridview.Columns[6].HeaderText = "Ghi chú";
			dsve_gridview.Columns[7].HeaderText = "Tình trạng";
		}

		private void Tuyen_cbb_SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] idTuyen = (string[])Tuyen_cbb.Tag;
			LoadDanhSachChuyenCBB(idTuyen[Tuyen_cbb.SelectedIndex]);
		}

		void LoadDanhSachTuyenCBB()
		{
			Tuyen_cbb.Items.Clear();
			Dictionary<string, string> items = bus.LoadDSTuyenCBB();
			string[] ID_Tuyen = items.Keys.ToArray();
			string[] Ten_Tuyen = items.Values.ToArray();
			Tuyen_cbb.Items.AddRange(Ten_Tuyen);
			Tuyen_cbb.Tag = ID_Tuyen;
		}

		private void Chuyen_CBB_SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] idChuyen = (string[])Chuyen_CBB.Tag;
			Xe_TextBox.Text = bus.LayXeTuChuyen(idChuyen[Chuyen_CBB.SelectedIndex]).Values.ToArray()[0];
			LoadDanhSachChoNgoiCBB(bus.LayXeTuChuyen(idChuyen[Chuyen_CBB.SelectedIndex]).Keys.ToArray()[0]);
		}

		void LoadDanhSachChuyenCBB(string IDTuyen)
		{
			Chuyen_CBB.Items.Clear();
			Dictionary<string, string> items = bus.LoadDSChuyenCBB(IDTuyen);
			string[] ID_Chuyen = items.Keys.ToArray();
			string[] Gio_Khoi_Hanh = items.Values.ToArray();
			Chuyen_CBB.Items.AddRange(Gio_Khoi_Hanh);
			Chuyen_CBB.Tag = ID_Chuyen;
		}

		void LoadDanhSachChoNgoiCBB(string IDxe)
		{
			ChoNgoiCBB.Items.Clear();
			Dictionary<string, string> items = bus.LoadDSChoNgoiCBB(IDxe);
			string[] ID_ChoNgoi = items.Keys.ToArray();
			string[] ThongTin = items.Values.ToArray();
			ChoNgoiCBB.Items.AddRange(ThongTin);
			ChoNgoiCBB.Tag = ID_ChoNgoi;
		}

		private void Add_btn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(Chuyen_CBB.Text) || string.IsNullOrWhiteSpace(Tuyen_cbb.Text) || string.IsNullOrWhiteSpace(ChoNgoiCBB.Text) || string.IsNullOrWhiteSpace(Tenkh_txt.Text) || string.IsNullOrWhiteSpace(std_txt.Text))
			{
				MessageBox.Show("Lỗi: bạn không nhập đủ dữ liệu");
				return;
			}
			string[] chongoi = (string[])ChoNgoiCBB.Tag;
			string[] chuyenid = (string[])Chuyen_CBB.Tag;
			string ngaydat = DateTime.Now.ToString("MM/dd/yyyy H:mm");
			string tinhtrang = "Da thanh toan";
			string idkhach = "";
			if (dattructiep_radio.Checked)
				tinhtrang = "Da thanh toan";
			else
				tinhtrang = "Chua thanh toan";

			if (String.IsNullOrWhiteSpace(idKhach_txt.Text)) //Nếu có nhập id cho kahsch
			{
				idkhach = bus.taoKH(Tenkh_txt.Text, std_txt.Text);
				bus.datve(chongoi[ChoNgoiCBB.SelectedIndex], chuyenid[Chuyen_CBB.SelectedIndex], tinhtrang, "50000", idkhach, ngaydat, GhiChu_txt.Text);
			}
			else
			{
				idkhach = idKhach_txt.Text;
				bus.datve(chongoi[ChoNgoiCBB.SelectedIndex], chuyenid[Chuyen_CBB.SelectedIndex], tinhtrang, "50000", idkhach, ngaydat, GhiChu_txt.Text);
			}
			loadDSVE();
			string[] idChuyen = (string[])Chuyen_CBB.Tag;
			Xe_TextBox.Text = bus.LayXeTuChuyen(idChuyen[Chuyen_CBB.SelectedIndex]).Values.ToArray()[0];
			LoadDanhSachChoNgoiCBB(bus.LayXeTuChuyen(idChuyen[Chuyen_CBB.SelectedIndex]).Keys.ToArray()[0]);
		}

		private void Huy_Click(object sender, EventArgs e)
		{
			string mave = dsve_gridview.Rows[dsve_gridview.CurrentRow.Index].Cells[0].Value.ToString();
			bus.huyve(mave);
			loadDSVE();
		}

		private void BANVE_BTN_Click(object sender, EventArgs e)
		{
			//RELOAD LẠI GRIDVIEW ?
			loadDSVE();
		}
		private void QLKHACK_BTN_Click(object sender, EventArgs e)
		{
			//Tạo form
			QLKHACH form = new QLKHACH();
			form.Show();	
		}

		private void TUYENXE_BTN_Click(object sender, EventArgs e)
		{
			//Tạo form
			QLTUYENXE form = new QLTUYENXE();
			form.Show();
		}

		private void CHUYENXE_BTN_Click(object sender, EventArgs e)
		{
			//Tạo form
			QLCHUYENXEcs form = new QLCHUYENXEcs();
			form.Show();
		}

		private void CLOSE_BTN_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MINITRAY_BTN_Click(object sender, EventArgs e)
		{
			
		}

	}
}
