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

        
    }
}
