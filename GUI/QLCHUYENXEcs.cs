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
        }
    }
}
