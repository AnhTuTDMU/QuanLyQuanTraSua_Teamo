using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnecData
    { 
        public static SqlConnection conncetion()
        {
            string conlink = @"Data Source=LAPTOP-MFIH9F2J\SQLEXPRESS;Initial Catalog=QL_TS;Integrated Security=True";
            SqlConnection conn = new SqlConnection(conlink);
            return conn;
        }
    }
}
