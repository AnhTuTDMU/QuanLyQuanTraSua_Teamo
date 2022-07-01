using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ThongKe
    {
        private static DAL_ThongKe instance;

        public static DAL_ThongKe Instance
        {
            get { if (instance == null) instance = new DAL_ThongKe(); return instance; }
            private set { instance = value; }
        }

        private DAL_ThongKe() { }

        public DataTable Thongke_Ngay(DateTime ngay)
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("proc_ThongkeNgay", Conn);
            command.CommandType = CommandType.StoredProcedure; command.Parameters.Add("@ngay", SqlDbType.DateTime2);
            command.Parameters["@ngay"].Value = ngay;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            Conn.Close();
        }
        public DataTable Xem_Hoadonchitiet(int id)
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("proc_XemHDChitiet", Conn);
            command.CommandType = CommandType.StoredProcedure; command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters["@id"].Value = id;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            Conn.Close();
        }
    }
}
