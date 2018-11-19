using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_CSDL;
using System.Data;
using System.Data.SqlClient;
using DTO_DinhNghiaDL;

namespace BUS_XuLy
{
    public class Bus
    {
        DAO_Customers a = new DAO_Customers();

        public DataTable LayDanhSach()
        {
            return a.LayDanhSach();
        }
        public DataTable TimName(string Name)
        {
            return a.TimName(Name);
        }
        public DataTable TimID(string ID)
        {
            return a.TimID(ID);
        }
        public int Them(Customers cs)
        {
            return a.Them(cs);
        }
        public int Xoa(string CustomerID)
        {
            return a.Xoa(
                CustomerID);
        }
        public int Sua(Customers cs)
        {
            return a.Sua(cs);
        }

    }
}
