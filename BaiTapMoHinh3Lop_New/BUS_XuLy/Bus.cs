using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO_CSDL;
using System.Data;
using System.Data.SqlClient;

namespace BUS_XuLy
{
    public class Bus
    {
        DataTable LayDanhSach()
        {
            DAO_Customers a = new DAO_Customers();
            return a.LayDanhSach();
        }
    }
}
