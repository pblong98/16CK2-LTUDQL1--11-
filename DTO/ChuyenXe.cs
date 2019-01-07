using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class ChuyenXe
    {
        private string _chuyenID;
        private string _tuyen;
        private DateTime _gioKhoiHanh;
        private string _ghiChu;
        private string _xe;
        private string _taiXe;

        public string ChuyenID { get => _chuyenID; set => _chuyenID = value; }
        public string Tuyen { get => _tuyen; set => _tuyen = value; }
        public DateTime GioKhoiHanh { get => _gioKhoiHanh; set => _gioKhoiHanh = value; }
        public string GhiChu { get => _ghiChu; set => _ghiChu = value; }
        public string Xe { get => _xe; set => _xe = value; }
        public string TaiXe { get => _taiXe; set => _taiXe = value; }

        public ChuyenXe() { }

        public ChuyenXe(string chuyenID, string tuyen, DateTime gioKhoiHanh, string ghiChu, string xe, string taiXe)
        {
            this.ChuyenID = chuyenID;
            this.Tuyen = tuyen;
            this.GioKhoiHanh = gioKhoiHanh;
            this.GhiChu = ghiChu;
            this.Xe = xe;
            this.TaiXe = taiXe;
        }
    }
}
