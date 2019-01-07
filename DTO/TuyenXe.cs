using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TuyenXe
    {
        private string _idTuyen;
        private string _tenTuyen;
        private double _khoanCach;
        private string _thoiGian;
        private string _tram1;
        private string _tram2;
        private string _tramTG;

        public string IdTuyen { get => _idTuyen; set => _idTuyen = value; }
        public string TenTuyen { get => _tenTuyen; set => _tenTuyen = value; }
        public double KhoanCach { get => _khoanCach; set => _khoanCach = value; }
        public string ThoiGian { get => _thoiGian; set => _thoiGian = value; }
        public string Tram1 { get => _tram1; set => _tram1 = value; }
        public string Tram2 { get => _tram2; set => _tram2 = value; }
        public string TramTG { get => _tramTG; set => _tramTG = value; }
        public TuyenXe()
        {

        }
        public TuyenXe(string idTuyen, string tenTuyen, double khoanCach, string thoiGian, string tram1, string tram2, string tramTG)
        {
            this.ThoiGian = thoiGian;
            this.IdTuyen = idTuyen;
            this.TenTuyen = tenTuyen;
            this.KhoanCach = khoanCach;
            this.Tram1 = tram1;
            this.Tram2 = tram2;
            this.TramTG = TramTG;
        }
    }
}
