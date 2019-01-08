using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private string _tenDangNhap;
        private string _matKhau;
        private string _phanQuyen;

        public string TenDangNhap { get => _tenDangNhap; set => _tenDangNhap = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
        public string PhanQuyen { get => _phanQuyen; set => _phanQuyen = value; }
        public TaiKhoan() { }
        public TaiKhoan(string tenDangNhap,string matKhau,string phanQuuen)
        {
            this.TenDangNhap = tenDangNhap;
            this.PhanQuyen = phanQuuen;
            this.MatKhau = matKhau;
        }
    }
}
