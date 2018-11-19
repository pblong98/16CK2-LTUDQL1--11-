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
            DataTable danhsach = new DataTable();
            try
            {
                provider.Connect();
                string StrSQL = "Select * from Customers";
                danhsach = provider.Select(CommandType.Text, StrSQL);               
            }catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return danhsach;
        }
        public int Them(Customers cs)
        {
            int nRow = -1;
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string StrSQL = "sp_AddCustomers";
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, StrSQL,
                    new SqlParameter { ParameterName = "customerID",Value=cs.CustomerID},
                    new SqlParameter { ParameterName = "companyName", Value = cs.CompanyName },
                    new SqlParameter { ParameterName = "contactName", Value = cs.ContactName },                   
                    new SqlParameter { ParameterName = "contactTitle", Value = cs.ContactTitle },
                    new SqlParameter { ParameterName = "address", Value = cs.Address },
                    new SqlParameter { ParameterName = "city", Value = cs.City },
                    new SqlParameter { ParameterName = "region", Value = cs.Region },
                    new SqlParameter { ParameterName = "postalCode", Value = cs.PostalCode },
                    new SqlParameter { ParameterName = "country", Value = cs.Country },
                    new SqlParameter { ParameterName = "phone", Value = cs.Phone },
                    new SqlParameter { ParameterName = "fax", Value = cs.Fax }
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
            return nRow;
        }
        public int Xoa(string CustomerID)
        {
            int nRow = -1;
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string StrSQL = "sp_DeleteCustomers";
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, StrSQL,
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
            return nRow;
        }
        public int Sua(Customers cs)
        {
            int nRow = -1;
            Provider provider = new Provider();
            try
            {
                provider.Connect();
                string StrSQL = "sp_UpdateCustomers";
                nRow = provider.ExecuteNonQuery(CommandType.StoredProcedure, StrSQL,
                    new SqlParameter { ParameterName = "customerID", Value = cs.CustomerID },
                    new SqlParameter { ParameterName = "companyName", Value = cs.CompanyName },
                    new SqlParameter { ParameterName = "contactName", Value = cs.ContactName },
                    new SqlParameter { ParameterName = "contactTitle", Value = cs.ContactTitle },
                    new SqlParameter { ParameterName = "address", Value = cs.Address },
                    new SqlParameter { ParameterName = "city", Value = cs.City },
                    new SqlParameter { ParameterName = "region", Value = cs.Region },
                    new SqlParameter { ParameterName = "postalCode", Value = cs.PostalCode },
                    new SqlParameter { ParameterName = "country", Value = cs.Country },
                    new SqlParameter { ParameterName = "phone", Value = cs.Phone },
                    new SqlParameter { ParameterName = "fax", Value = cs.Fax }
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
            return nRow;
        }
        public DataTable TimID(string ID)
        {
            Provider provider = new Provider();
            DataTable danhsach = new DataTable();
            try
            {
                provider.Connect();
                string StrSQL = "sp_FindID";
                danhsach = provider.Select2(CommandType.StoredProcedure, StrSQL,
                   new SqlParameter{ParameterName ="customerID",Value=ID });
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return danhsach;
        }
        public DataTable TimName(string Name)
        {
            Provider provider = new Provider();
            DataTable danhsach = new DataTable();
            try
            {
                provider.Connect();
                string StrSQL = "sp_FindName";
                danhsach = provider.Select2(CommandType.StoredProcedure, StrSQL,
                   new SqlParameter { ParameterName = "companyName", Value = Name });
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                provider.DisConnect();
            }
            return danhsach;
        }

    }
}
