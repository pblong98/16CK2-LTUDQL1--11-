using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_XuLy;
using DTO_DinhNghiaDL;

namespace GUI_GiaoDien
{
    public partial class Form1 : Form
    {
        Bus xuLy = new Bus();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = xuLy.LayDanhSach();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Customers cs = new Customers();
            cs.CustomerID = txtCustomerID.Text.ToString();
            cs.CompanyName = txtCompanyName.Text.ToString();
            cs.ContactName = txtContactName.Text.ToString();
            cs.ContactTitle = txtContactTitle.Text.ToString();
            cs.Address = txtAddress.Text.ToString();
            cs.City = txtCity.Text.ToString();
            cs.Region = txtRegion.Text.ToString();
            cs.PostalCode = txtPostalCode.Text.ToString();
            cs.Country = txtCountry.Text.ToString();
            cs.Phone = txtPhone.Text.ToString();
            cs.Fax = txtFax.Text.ToString();
            xuLy.Them(cs);
        }
    }
}
