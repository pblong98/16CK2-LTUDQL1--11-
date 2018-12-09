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
    public partial class QLVE : Form
    {
        public QLVE()
        {
            InitializeComponent();
        }

		private void BANVE_BTN_Click(object sender, EventArgs e)
		{
			//RELOAD LẠI GRIDVIEW ?

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
