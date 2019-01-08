using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiXe
    {
        private string _ma;
        private string _tenTaiXe;
        private string _bangLai;

        public string Ma { get => _ma; set => _ma = value; }
        public string TenTaiXe { get => _tenTaiXe; set => _tenTaiXe = value; }
        public string BangLai { get => _bangLai; set => _bangLai = value; }
        public TaiXe() { }
        public TaiXe( string ma,string tenTaiXe,string bangLai)
        {
            this.BangLai = bangLai;
            this.Ma = ma;
            this.TenTaiXe = tenTaiXe;
        }
    }
}
