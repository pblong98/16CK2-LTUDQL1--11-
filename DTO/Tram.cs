using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Tram
    {
        private string _maTram;
        private string _tenTram;
        private string _diaDiem;
        private string _thuTu;

        public string MaTram { get => _maTram; set => _maTram = value; }
        public string TenTram { get => _tenTram; set => _tenTram = value; }
        public string DiaDiem { get => _diaDiem; set => _diaDiem = value; }
        public string ThuTu { get => _thuTu; set => _thuTu = value; }

        public Tram() { }

        public Tram(string maTram,string tenTram,string diaDiem,string thuTu)
        {
            this.MaTram = maTram;
            this.TenTram = tenTram;
            this.ThuTu = thuTu;
            this.DiaDiem = diaDiem;
        }
    }
}