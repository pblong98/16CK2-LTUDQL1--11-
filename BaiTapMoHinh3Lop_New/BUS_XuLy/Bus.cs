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

        DataTable LayDanhSach()
        {
            return a.LayDanhSach();
        }
        int Them(Customers cs)
        {
            return a.Sua(cs);
        }
        int Xoa(Customers cs)
        {
            return a.Sua(cs);
        }
        int Sua(Customers cs)
        {
            return a.Sua(cs);
        }

    }
}
