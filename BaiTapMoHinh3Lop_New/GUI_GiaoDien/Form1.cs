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
            Reload();
        }
        void Reload()
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
            Reload();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int CurrentIndex = dgvDanhSach.CurrentCell.RowIndex;
            string CustomerID = Convert.ToString(dgvDanhSach.Rows[CurrentIndex].Cells["CustomerID"].Value.ToString());
            xuLy.Xoa(CustomerID);
            Reload();
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int CurrentIndex = dgvDanhSach.CurrentCell.RowIndex;
            txtCustomerID.Text = dgvDanhSach.Rows[CurrentIndex].Cells["CustomerID"].Value.ToString();
            txtCompanyName.Text = dgvDanhSach.Rows[CurrentIndex].Cells["CompanyName"].Value.ToString();
            txtContactName.Text = dgvDanhSach.Rows[CurrentIndex].Cells["ContactName"].Value.ToString();
            txtContactTitle.Text = dgvDanhSach.Rows[CurrentIndex].Cells["ContactTitle"].Value.ToString();
            txtAddress.Text = dgvDanhSach.Rows[CurrentIndex].Cells["Address"].Value.ToString();
            txtCity.Text = dgvDanhSach.Rows[CurrentIndex].Cells["City"].Value.ToString();
            txtRegion.Text = dgvDanhSach.Rows[CurrentIndex].Cells["Region"].Value.ToString();
            txtPostalCode.Text = dgvDanhSach.Rows[CurrentIndex].Cells["PostalCode"].Value.ToString();
            txtCountry.Text = dgvDanhSach.Rows[CurrentIndex].Cells["Country"].Value.ToString();
            txtPhone.Text = dgvDanhSach.Rows[CurrentIndex].Cells["Phone"].Value.ToString();
            txtFax.Text = dgvDanhSach.Rows[CurrentIndex].Cells["Fax"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
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
            xuLy.Sua(cs);
            Reload();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn thật sự muốn thoát chương trình","Thông báo",MessageBoxButtons.OKCancel)!= DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            string ID = txtID.Text.ToString();
            dgvDanhSach.DataSource = xuLy.TimID(ID);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string Name = txtName.Text.ToString();
            dgvDanhSach.DataSource = xuLy.TimID(Name);
        }
    }
}
