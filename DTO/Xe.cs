using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Xe
    {
        private string _maXe;
        private string _tenXe;
        private string _loaiXe;
        private string _soDangKy;

        public string MaXe { get => _maXe; set => _maXe = value; }
        public string TenXe { get => _tenXe; set => _tenXe = value; }
        public string LoaiXe { get => _loaiXe; set => _loaiXe = value; }
        public string SoDangKy { get => _soDangKy; set => _soDangKy = value; }
        public Xe() { }
        public Xe(string maXe, string tenXe, string loaiXe, string soDangKy)
        {
            this.MaXe = maXe;
            this.TenXe = tenXe;
            this.LoaiXe = loaiXe;
            this.SoDangKy = soDangKy;
        }
    }
}
