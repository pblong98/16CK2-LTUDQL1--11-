using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
namespace DAO
{
    public class DAOADMIN
    {
        static Provider provider = new Provider();
        public bool DangNhap(string tenDangNhap, string matKhau)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(matKhau);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            
            string sql = "sp_Login";
            provider.Connect();
            DataTable result = provider.Select2(CommandType.StoredProcedure,sql,
                new SqlParameter { ParameterName="user",Value=tenDangNhap},
                new SqlParameter { ParameterName="pass",Value=hasPass});
            provider.DisConnect();
            return result.Rows.Count > 0;

        }
        public DataTable LoadTaiKhoan()
        {
            provider.Connect();
            DataTable data = provider.Select(CommandType.Text, "select * from DangNhap_");
            provider.DisConnect();
            return data;
        }
        public int ThemTaiKhoan(TaiKhoan tk)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(tk.MatKhau);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            provider.Connect();
            string sql = "sp_ThemTK";
            int nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, sql,
                new SqlParameter { ParameterName = "user", Value = tk.TenDangNhap },
                new SqlParameter { ParameterName = "pass", Value = hasPass },
                new SqlParameter { ParameterName = "rule", Value = tk.PhanQuyen }
                );
            provider.DisConnect();
            return nRow;
        }
        public int XoaTaiKhoan(string user)
        {
            provider.Connect();
            string sql = "sp_XoaTK";
            int nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, sql,
                new SqlParameter { ParameterName="user",Value=user});
            provider.DisConnect();
            return nRow;
        }
        public int SuaTaiKhoan(TaiKhoan tk)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(tk.MatKhau);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            provider.Connect();
            string sql = "sp_SuaTK";
            int nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, sql,
                new SqlParameter { ParameterName = "user", Value = tk.TenDangNhap },
                new SqlParameter { ParameterName = "pass", Value = hasPass },
                new SqlParameter { ParameterName = "rule", Value = tk.PhanQuyen }
                );
            provider.DisConnect();
            return nRow;
        }
        public DataTable TimTaiKhoan(string user)
        {
            provider.Connect();
            DataTable data = provider.Select(CommandType.Text, "select * from DangNhap_ where userr='"+ user + "'");
            provider.DisConnect();
            return data;
        }
        public DataTable TimTaiKhoangd(string user)
        {
            provider.Connect();
            DataTable data = provider.Select(CommandType.Text, "select * from DangNhap_ where userr like '%" + user + "%'");
            provider.DisConnect();
            return data;
        }

    }
}
