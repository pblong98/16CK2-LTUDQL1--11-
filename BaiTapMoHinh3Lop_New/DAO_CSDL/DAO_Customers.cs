using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO_DinhNghiaDL;
namespace DAO_CSDL
{
    public class DAO_Customers
    {
        public DataTable LayDanhSach()
        {
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string StrSQL = "Select * from Customers";
                DataTable danhsach = provider.Select(CommandType.Text, StrSQL);
                return danhsach;
            }catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }
        public void Them(Customers cs)
        {
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string StrSQL = "sp_AddCustomers";
                int nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, StrSQL,
                    new SqlParameter { ParameterName = "CustomerID",Value=cs.CustomerID},
                    new SqlParameter { ParameterName = "CompanyName", Value = cs.CompanyName },
                    new SqlParameter { ParameterName = "ContactName", Value = cs.ContactName },                   
                    new SqlParameter { ParameterName = "ContactTitle", Value = cs.ContactTitle },
                    new SqlParameter { ParameterName = "Address", Value = cs.Address },
                    new SqlParameter { ParameterName = "City", Value = cs.City },
                    new SqlParameter { ParameterName = "Region", Value = cs.Region },
                    new SqlParameter { ParameterName = "PostalCode", Value = cs.PostalCode },
                    new SqlParameter { ParameterName = "Country", Value = cs.Country },
                    new SqlParameter { ParameterName = "Phone", Value = cs.Phone },
                    new SqlParameter { ParameterName = "Fax", Value = cs.Fax }
                    );               
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }
        public void Xoa(string CustomerID)
        {
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string StrSQL = "sp_DeleteCustomers";
                int row = provider.ExecuteNonQuery(CommandType.StoredProcedure, StrSQL,
                    new SqlParameter { ParameterName= "CustomerID",Value= CustomerID });               
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }
        public void Sua(Customers cs)
        {
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string StrSQL = "sp_UpdateCustomers";
                int nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, StrSQL,
                    new SqlParameter { ParameterName = "CustomerID", Value = cs.CustomerID },
                    new SqlParameter { ParameterName = "CompanyName", Value = cs.CompanyName },
                    new SqlParameter { ParameterName = "ContactName", Value = cs.ContactName },
                    new SqlParameter { ParameterName = "ContactTitle", Value = cs.ContactTitle },
                    new SqlParameter { ParameterName = "Address", Value = cs.Address },
                    new SqlParameter { ParameterName = "City", Value = cs.City },
                    new SqlParameter { ParameterName = "Region", Value = cs.Region },
                    new SqlParameter { ParameterName = "PostalCode", Value = cs.PostalCode },
                    new SqlParameter { ParameterName = "Country", Value = cs.Country },
                    new SqlParameter { ParameterName = "Phone", Value = cs.Phone },
                    new SqlParameter { ParameterName = "Fax", Value = cs.Fax }
                    );
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
        }

    }
}
