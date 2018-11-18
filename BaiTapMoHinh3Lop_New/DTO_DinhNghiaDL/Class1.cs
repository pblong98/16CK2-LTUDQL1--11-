using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_DinhNghiaDL
{
    public class Class1
    {
        private string _maNhom;
        private string _tenNhomTruong;
        private string _chuNangNhom;

        public string MaNhom { get => _maNhom; set => _maNhom = value; }
        public string TenNhomTruong { get => _tenNhomTruong; set => _tenNhomTruong = value; }
        public string ChuNangNhom { get => _chuNangNhom; set => _chuNangNhom = value; }

        public Class1() { }
        public Class1(string Id,string LeaderName,string Function)
        {
            this._maNhom = Id;
            this._tenNhomTruong = LeaderName;
            this._chuNangNhom = Function;
        }
    }
}
