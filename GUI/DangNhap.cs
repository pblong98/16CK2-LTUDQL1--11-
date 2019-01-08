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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        static Bus bus = new Bus();
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string passWord = txtPass.Text;
            if (Login(userName, passWord))
            {
                if(bus.PhanQuyen(userName) =="admin")
                {
                    Admin a = new Admin();
                    this.Hide();
                    a.ShowDialog();
                    this.Show();
                }
                else if(bus.PhanQuyen(userName) == "report")
                {
                    NhanVienBaoCao f = new NhanVienBaoCao();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    QLVE f = new QLVE();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }
        

        bool Login(string userName, string passWord)
        {
            return bus.Login(userName, passWord);
        }     
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
