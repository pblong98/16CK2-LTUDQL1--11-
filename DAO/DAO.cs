using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
				ds.Add(row["ID_Tuyen"].ToString() ,row["TenTuyen"].ToString());
			}
			provider.DisConnect();
			return ds;
		}

		public Dictionary<string, string> LoadDanhSachChuyenXe(string idTuyen)
		{
			provider.Connect();
			DataTable kq = provider.Select(CommandType.Text, @"select * from Chuyen where ID_Chuyen = '"+idTuyen+"'");

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
				foreach(DataRow r in xetb.Rows)
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
			provider.ExecuteNonQuery(CommandType.Text,sql);
			provider.ExecuteNonQuery(CommandType.Text, "update Ghe set TinhTrang = 'Da dat' where ID_Ghe = '"+idghe+"'");
			provider.DisConnect();
			return"";
		}

		public void huyve(string idve)
		{
			provider.Connect();
			provider.ExecuteNonQuery(CommandType.Text, "delete from Ve where ID_Ve = '"+idve+"'");
			provider.DisConnect();
		}

		public DataTable dsve()
		{
			provider.Connect();
			DataTable dt = provider.Select(CommandType.Text, "select * from Ve");
			provider.DisConnect();
			return dt;
		}
	}
}
