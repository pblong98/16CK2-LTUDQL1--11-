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
    public partial class NhanVienBaoCao : Form
    {
        public NhanVienBaoCao()
        {
            InitializeComponent();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVeXe_Click(object sender, EventArgs e)
        {
            BaoVe f = new BaoVe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaoCao f = new BaoCao();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BaoTuyen f = new BaoTuyen();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BaoKhach f = new BaoKhach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
