using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class DAO
    {
        Provider provider;
        public DAO()
        {
            provider = new Provider();
        }

        public Dictionary<string, string> LoadDanhSachTuyenXe()
        {
            provider.Connect();
            DataTable kq = provider.Select(CommandType.Text, @"select * from Tuyen");

            Dictionary<string, string> ds = new Dictionary<string, string>(); //key chua ID tuyen, value chứa tên tuyến

            foreach (DataRow row in kq.Rows)
            {
                ds.Add(row["ID_Tuyen"].ToString(), row["TenTuyen"].ToString());
            }
            provider.DisConnect();
            return ds;
        }

        public Dictionary<string, string> LoadDanhSachChuyenXe(string idTuyen)
        {
            provider.Connect();
            DataTable kq = provider.Select(CommandType.Text, @"select * from Chuyen where ID_Chuyen = '" + idTuyen + "'");

            Dictionary<string, string> ds = new Dictionary<string, string>(); //key chua ID chuyen, value chứa tên chuyến

            foreach (DataRow row in kq.Rows)
            {
                ds.Add(row["ID_Chuyen"].ToString(), row["Gio_Khoi_Hanh"].ToString());
            }
            provider.DisConnect();
            return ds;
        }

        public Dictionary<string, string> LayXeTuChuyen(string idChuyen)
        {
            provider.Connect();
            DataTable kq = provider.Select(CommandType.Text, @"select * from Chuyen where Xe_XeID = '" + idChuyen + "'");

            Dictionary<string, string> xe = new Dictionary<string, string>();

            foreach (DataRow row in kq.Rows)
            {
                DataTable xetb = provider.Select(CommandType.Text, @"select * from Xe where XeID = '" + idChuyen + "'");
                foreach (DataRow r in xetb.Rows)
                {
                    xe.Add(r["XeID"].ToString(), r["TenXe"].ToString());
                }
            }
            provider.DisConnect();
            return xe;
        }

        public Dictionary<string, string> LayDanhSachChoNgoi(string IDxe)
        {
            provider.Connect();
            DataTable kq = provider.Select(CommandType.Text, @"select * from Ghe where Xe_XeID = '" + IDxe + "' and TinhTrang = 'Trong'");

            Dictionary<string, string> ds = new Dictionary<string, string>(); //key chua ID ghe, value chứa thông tin ghế

            foreach (DataRow row in kq.Rows)
            {
                ds.Add(row["ID_Ghe"].ToString(), "Dòng: " + row["Dong"].ToString() + " Cột: " + row["Cot"].ToString() + " Tầng: " + row["Tang"].ToString());
            }
            provider.DisConnect();
            return ds;
        }

        public string taoIDChoKhachHang()
        {
            provider.Connect();
            int id = 0;

            while (true)
            {
                Random ran = new Random();
                id = ran.Next(0, 9999);
                DataTable kq = provider.Select(CommandType.Text, @"select * from KhachHang where ID_KhachHang = '" + id + "'");
                if (kq.Rows.Count == 0)
                {
                    break;
                }
            }
            provider.DisConnect();
            return id.ToString();
        }

        public string themKhachHang(string hoten, string dienthoai)
        {
            string newid = taoIDChoKhachHang();
            provider.Connect();
            provider.ExecuteNonQuery(CommandType.Text, "insert into KhachHang values ('" + newid + "','" + hoten + "','" + dienthoai + "', 'no', 1)");
            provider.DisConnect();
            return newid;
        }

        public string taoIDVe()
        {
            provider.Connect();
            int id = 0;

            while (true)
            {
                Random ran = new Random();
                id = ran.Next(0, 9999);
                DataTable kq = provider.Select(CommandType.Text, @"select * from Ve where ID_Ve = '" + id + "'");
                if (kq.Rows.Count == 0)
                {
                    break;
                }
            }
            provider.DisConnect();
            return id.ToString();
        }

        public string datve(string idghe, string idchuyen, string tinhtrang, string giatien, string idkhach, string ngayxuatve, string ghichu)
        {
            provider.Connect();
            string sql = "insert into Ve values (" + taoIDVe() + "," + idghe + "," + idchuyen + "," + giatien + "," + idkhach + ",'" + ngayxuatve + "','" + ghichu + "','" + tinhtrang + "')";
            provider.Connect();
            provider.ExecuteNonQuery(CommandType.Text, sql);
            provider.ExecuteNonQuery(CommandType.Text, "update Ghe set TinhTrang = 'Da dat' where ID_Ghe = '" + idghe + "'");
            provider.DisConnect();
            return "";
        }

        public void huyve(string idve)
        {
            provider.Connect();
            provider.ExecuteNonQuery(CommandType.Text, "delete from Ve where ID_Ve = '" + idve + "'");
            provider.DisConnect();
        }

        public DataTable dsve()
        {
            provider.Connect();
            DataTable dt = provider.Select(CommandType.Text, "select * from Ve");
            provider.DisConnect();
            return dt;
        }

        public DataTable dsKhachHang()
        {
            provider.Connect();
            DataTable dt = provider.Select(CommandType.Text, "select * from KhachHang");
            provider.DisConnect();
            return dt;
        }

        public string themKhachHang2(string hoten, string dienthoai, string email, string loai)
        {
            string newid = taoIDChoKhachHang();
            provider.Connect();
            provider.ExecuteNonQuery(CommandType.Text, "insert into KhachHang values ('" + newid + "','" + hoten + "','" + dienthoai + "', '" + email + "', " + loai + ")");
            provider.DisConnect();
            return newid;
        }

        public void xoaKhachHang(string idkh)
        {
            provider.Connect();
            provider.ExecuteNonQuery(CommandType.Text, "delete from KhachHang where ID_KhachHang = '" + idkh + "'");
            provider.DisConnect();
        }

        public void updateKhachHang(string idkh, string ten, string email, string sdt, string loai)
        {
            provider.Connect();
            provider.ExecuteNonQuery(CommandType.Text, "update KhachHang set HoTen = '" + ten + "', DienThoai = '" + sdt + "', Email = '" + email + "' , Loai = " + loai[0] + " where ID_KhachHang = '" + idkh + "'");
            provider.DisConnect();
        }

        public DataTable timVe(string id)
        {
            provider.Connect();
            DataTable dt = provider.Select(CommandType.Text, "select * from Ve where ID_Ve = '" + id + "'");
            provider.DisConnect();
            return dt;
        }

        public DataTable timKhach(string id)
        {
            provider.Connect();
            DataTable dt = provider.Select(CommandType.Text, "select * from KhachHang where ID_KhachHang = '" + id + "'");
            provider.DisConnect();
            return dt;
        }
        public DataTable loadTuyen()
        {
            provider.Connect();
            DataTable dt = provider.Select(CommandType.Text, "select t.ID_Tuyen,t.KhoangCach,t.ThoiGianChay,t.TenTuyen,t2.TenTram as tram1,t3.TenTram as tram2 from Tuyen t,Tram t2,Tram t3 Where t.Tram_ID_Tram1=t2.ID_Tram and t.Tram_ID_Tram=t3.ID_Tram ");
            provider.DisConnect();
            return dt;
        }
        public DataTable loadTram()
        {
            provider.Connect();           
            DataTable dt = provider.Select(CommandType.Text, "select * from Tram ");
            provider.DisConnect();
            return dt;
        }
        public DataTable loadTrama(string TenTram)
        {
            provider.Connect();
            DataTable dt = provider.Select(CommandType.Text, "select ID_Tram from Tram where TenTram = N'" + TenTram + "'");
            provider.DisConnect();
            return dt;
        }
        public DataTable loadTramb(string TenTram)
        {
            provider.Connect();
            DataTable dt = provider.Select(CommandType.Text, "select ID_Tram from Tram where TenTram = N'" + TenTram + "'");
            provider.DisConnect();
            return dt;
        }

        public int ThemTuyen(TuyenXe tx)
        {
            provider.Connect();
            int t1 = Convert.ToInt32(tx.Tram1);
            int t2 = Convert.ToInt32(tx.Tram2);
            int nRow = provider.ExecuteNonQuery(CommandType.Text, "insert into Tuyen values ('" + tx.IdTuyen + "','" + tx.KhoanCach + "','" + tx.ThoiGian + "', " + t1 + "," + t2 + ",N'" + tx.TenTuyen + "')");
            provider.DisConnect();
            return nRow;
        }
    }
}
