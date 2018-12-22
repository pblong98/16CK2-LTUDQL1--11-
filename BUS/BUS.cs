using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
	public class BUS
	{
		DAO.DAO dao;
		public BUS()
		{
			dao = new DAO.DAO();
		}

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
			return dao.datve(idghe,idchuyen,tinhtrang,giatien,idkhach,ngayxuatve,ghichu);
		}

		public DataTable dsve()
		{
			return dao.dsve();
		}

		public void huyve(string idve)
		{
			dao.huyve(idve);
		}
	}
}
