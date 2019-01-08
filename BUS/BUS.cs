using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;
using DTO;

namespace BUS
{
    public class Bus
    {
        DAO.DAO dao;
        public Bus()
        {
            dao = new DAO.DAO();
           
        }
        static DAOADMIN d = new DAOADMIN();
        public Dictionary<string, string> LoadDSTuyenCBB()
        {
            return dao.LoadDanhSachTuyenXe();
        }

        public Dictionary<string, string> LoadDSChuyenCBB(string idTuyen)
        {
            return dao.LoadDanhSachChuyenXe(idTuyen);
        }

        public Dictionary<string, string> LayXeTuChuyen(string idChuyen)
        {
            return dao.LayXeTuChuyen(idChuyen);
        }


        public Dictionary<string, string> LoadDSChoNgoiCBB(string idXE)
        {
            return dao.LayDanhSachChoNgoi(idXE);
        }

        public string taoKH(string ten, string sdt)
        {
            return dao.themKhachHang(ten, sdt);
        }

        public string datve(string idghe, string idchuyen, string tinhtrang, string giatien, string idkhach, string ngayxuatve, string ghichu)
        {
            return dao.datve(idghe, idchuyen, tinhtrang, giatien, idkhach, ngayxuatve, ghichu);
        }

        public DataTable dsve()
        {
            return dao.dsve();
        }

        public void huyve(string idve)
        {
            dao.huyve(idve);
        }

        public DataTable dsKhachHang()
        {
            return dao.dsKhachHang();
        }

        public void themKhachHang2(string hoten, string dienthoai, string email, string loai)
        {
            dao.themKhachHang2(hoten, dienthoai, email, loai);
        }

        public void xoaKhachHang(string idkh)
        {
            dao.xoaKhachHang(idkh);
        }

        public void updateKhachHang(string idkh, string ten, string email, string sdt, string loai)
        {
            dao.updateKhachHang(idkh, ten, email, sdt, loai);
        }

        public DataTable timVe(string id)
        {
            return dao.timVe(id);
        }

        public DataTable timKhach(string id)
        {
            return dao.timKhach(id);
        }
        public DataTable loadTuyen()
        {
            return dao.loadTuyen();
        }
        public List<String> loadTram()
        {
            List<string> tenTram = new List<string>();
            foreach (DataRow row in dao.LoadTram().Rows)
            {
                tenTram.Add(row["tenTram"].ToString());
            }
            return tenTram;
        }
       
        public int themTuyen(TuyenXe tx)
        {
            
            foreach (DataRow row in dao.LoadTram(tx.Tram1).Rows)
            {
                tx.Tram1=row["ID_Tram"].ToString();
            }
            foreach (DataRow row2 in dao.LoadTram(tx.Tram2).Rows)
            {
                tx.Tram2 = row2["ID_Tram"].ToString();
            }
            return dao.ThemTuyen(tx);
        }
        public int suaTuyen(TuyenXe tx)
        {
            foreach (DataRow row in dao.LoadTram(tx.Tram1).Rows)
            {
                tx.Tram1 = row["ID_Tram"].ToString();
            }
            foreach (DataRow row2 in dao.LoadTram(tx.Tram2).Rows)
            {
                tx.Tram2 = row2["ID_Tram"].ToString();
            }
            return dao.SuaTuyen(tx);
        }
        public int xoaTuyen(int id)
        {
            return dao.XoaTuyen(id);
        }
        public DataTable timTuyen(string tenTuyen)
        {
            return dao.TimTenTuyen(tenTuyen);
        }
        public DataTable loadChuyen()
        {
            return dao.LoadChuyenXe();
        }
        public List<String> loadTenTuyen()
        {
            List<string> TenTuyen = new List<string>();
            foreach (DataRow row in dao.loadTenTuyen().Rows)
            {
                TenTuyen.Add(row["TenTuyen"].ToString());
            }
            return TenTuyen;
        }
        public List<String> loadTenXe()
        {
            List<string> TenXe = new List<string>();
            foreach (DataRow row in dao.loadTenXe().Rows)
            {
                TenXe.Add(row["TenXe"].ToString());
            }
            return TenXe;
        }
        public List<String> loadTenTaiXe()
        {
            List<string> TenTaiXe = new List<string>();
            foreach (DataRow row in dao.loadTenTaiXe().Rows)
            {
                TenTaiXe.Add(row["TenTaiXe"].ToString());
            }
            return TenTaiXe;
        }
        public int themChuyen(ChuyenXe cx)
        {

            foreach (DataRow row in dao.loadTenXe(cx.Xe).Rows)
            {
                cx.Xe = row["XeID"].ToString();
            }
            foreach (DataRow row2 in dao.loadTenTaiXe(cx.TaiXe).Rows)
            {
                cx.TaiXe = row2["ID_TaiXe"].ToString();
            }
            foreach (DataRow row3 in dao.loadTenTuyen(cx.Tuyen).Rows)
            {
                cx.Tuyen = row3["ID_Tuyen"].ToString();
            }
            return dao.ThemChuyen(cx);
        }
        public int xoaChuyen(int maChuyen)
        {
            return dao.XoaChuyen(maChuyen);
        }
        public int SuaChuyen(ChuyenXe cx)
        {

            foreach (DataRow row in dao.loadTenXe(cx.Xe).Rows)
            {
                cx.Xe = row["XeID"].ToString();
            }
            foreach (DataRow row2 in dao.loadTenTaiXe(cx.TaiXe).Rows)
            {
                cx.TaiXe = row2["ID_TaiXe"].ToString();
            }
            foreach (DataRow row3 in dao.loadTenTuyen(cx.Tuyen).Rows)
            {
                cx.Tuyen = row3["ID_Tuyen"].ToString();
            }
            return dao.SuaChuyen(cx);
        }
        public bool Login(string userName, string passWord)
        {
            return d.DangNhap(userName, passWord);
        }
        public string PhanQuyen(string user)
        {
            string a = "";
            foreach (DataRow row in d.TimTaiKhoan(user).Rows)
            {
                a = row["rule"].ToString();
            }
            return a;
        }
    }
}
