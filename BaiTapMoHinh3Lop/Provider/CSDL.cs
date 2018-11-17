using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CSDL
{
	public class CSDL
	{
		static string ConnectionString = @"Data Source=DESKTOP-4P58K4I\SQLEXPRESS;Initial Catalog=QLHS;Integrated Security=True";

		public CSDL() { }

		SqlConnection Connection { get; set; }

		public void Connect()   //Ham mo ket noi
		{
			try
			{
				if (Connection == null)
					Connection = new SqlConnection(ConnectionString);
				if (Connection.State != ConnectionState.Closed)
					Connection.Close();
				Connection.Open();
			}
			catch (SqlException ex)
			{
				throw ex;
			}
		}

		public void Disconnect()
		{
			if (Connection != null && Connection.State == ConnectionState.Open)
				Connection.Close();
		}

		//Ham update (them, xoa, sua) du lieu (khong tham so)
		public int ExecuteNonQuery(CommandType cmdType, string strSql)
		{
			try
			{
				SqlCommand command = Connection.CreateCommand();
				command.CommandText = strSql;
				command.CommandType = cmdType;
				int nRow = command.ExecuteNonQuery();
				Console.WriteLine("Thanh cong !");
				return nRow;
			}
			catch (SqlException ex)
			{
				throw ex;
			}
		}

		//Ham update (them, xoa, sua) du lieu (co tham so)
		public int ExecuteNonQuery(CommandType cmdType, string strSql, params SqlParameter[] parameters)
		{
			try
			{
				SqlCommand command = Connection.CreateCommand();
				command.CommandText = strSql;
				command.CommandType = cmdType;
				if (parameters != null && parameters.Length > 0)
					command.Parameters.AddRange(parameters);
				int nRow = command.ExecuteNonQuery();
				Console.WriteLine("Thanh cong !");
				return nRow;
			}
			catch (SqlException ex)
			{
				throw ex;
			}
		}

		//Ham tim kiem du lieu
		public DataTable Select(CommandType cmdType, string strSql)
		{
			try
			{
				SqlCommand command = Connection.CreateCommand();
				command.CommandType = cmdType;
				command.CommandText = strSql;
				SqlDataAdapter da = new SqlDataAdapter(command);
				DataTable dt = new DataTable();
				da.Fill(dt);
				return dt;
			}
			catch (SqlException ex)
			{
				throw ex;
			}
		}
	}
}


