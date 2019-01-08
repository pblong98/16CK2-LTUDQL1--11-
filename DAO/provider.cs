using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DAO
{
	class Provider
	{
		static string SqlConnectionstring = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
		public SqlConnection Connection { get; set; }
        
        public void Connect()
		{
			try
			{
				if (Connection == null)
					Connection = new SqlConnection(SqlConnectionstring);
				if (Connection.State != ConnectionState.Closed)
				{ Connection.Close(); }

				Connection.Open();
			}
			catch (SqlException ex)
			{
				throw ex;
			}

		}
		public void DisConnect()
		{
			try
			{
				if (Connection != null && Connection.State == ConnectionState.Open)
					Connection.Close();
			}
			catch (SqlException ex)
			{
				throw ex;
			}

		}

		public int ExecuteNonQuery(CommandType cmdType, string Strsql, params SqlParameter[] parameters)/*Them xoa sua*/
		{
			try
			{

				SqlCommand command = Connection.CreateCommand();
				command.CommandText = Strsql;
				command.CommandType = cmdType;
				if (parameters != null && parameters.Length > 0)
					command.Parameters.AddRange(parameters);
				int row = command.ExecuteNonQuery();
				return row;
			}
			catch (SqlException ex)
			{
				throw ex;
			}
		}
		public DataTable Select(CommandType cmdType, string Strsql, params SqlParameter[] parameters)/*khong tham so truyen vao*/
		{
			try
			{
				SqlCommand command = Connection.CreateCommand();
				command.CommandText = Strsql;
				command.CommandType = cmdType;
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
		public DataTable Select2(CommandType cmdType, string Strsql, params SqlParameter[] parameters)/*co tham so truyen vao*/
		{
			try
			{
				SqlCommand command = Connection.CreateCommand();
				command.CommandText = Strsql;
				command.CommandType = cmdType;
				if (parameters != null && parameters.Length > 0)
					command.Parameters.AddRange(parameters);
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
