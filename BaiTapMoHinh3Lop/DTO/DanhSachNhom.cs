using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhSachNhom
    {
        private string _maNhom;
        private string _tenNhom;
        private string _chucNang;

        public string MaNhom { get => _maNhom; set => _maNhom = value; }
        public string TenNhom { get => _tenNhom; set => _tenNhom = value; }
        public string ChucNang { get => _chucNang; set => _chucNang = value; }
        public DanhSachNhom() { }
        public DanhSachNhom(string id,string name,string funtion)
        {
            this._maNhom = id;
            this._tenNhom = name;
            this._chucNang = funtion;
        }

    }
}
