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
	public partial class QLTUYENXE : Form
	{
		public QLTUYENXE()
		{
			InitializeComponent();
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
	}
}
