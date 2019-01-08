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
    public partial class Admin : Form
    {
        static Bus bus = new Bus();
        public Admin()
        {
            InitializeComponent();
        }
        void reLoad()
        {
            dgvTK.DataSource = bus.loadTK();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            reLoad();
        }

        private void txtTimTK_TextChanged(object sender, EventArgs e)
        {
            string user = txtTimTK.Text.ToString();
            dgvTK.DataSource = bus.timTK(user);
        }

        private void dgvTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CurrentIndex = dgvTK.CurrentCell.RowIndex;
            txtTK.Text = dgvTK.Rows[CurrentIndex].Cells["TaiKhoan"].Value.ToString();
            txtMK.Text = dgvTK.Rows[CurrentIndex].Cells["MatKhau"].Value.ToString();
            txtPhanQuyen.Text = dgvTK.Rows[CurrentIndex].Cells["PhanQuyen"].Value.ToString();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.TenDangNhap = txtTK.Text.ToString();
            tk.MatKhau = txtMK.Text.ToString();
            tk.PhanQuyen = txtPhanQuyen.Text.ToString();
            bus.ThemTK(tk);
            reLoad();
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.TenDangNhap = txtTK.Text.ToString();
            tk.MatKhau = txtMK.Text.ToString();
            tk.PhanQuyen = txtPhanQuyen.Text.ToString();
            bus.SuaTK(tk);
            reLoad();
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            int CurrentIndex = dgvTK.CurrentCell.RowIndex;
            string user = dgvTK.Rows[CurrentIndex].Cells["TaiKhoan"].Value.ToString();
            bus.XoaTK(user);
            reLoad();
        }
    }
}
