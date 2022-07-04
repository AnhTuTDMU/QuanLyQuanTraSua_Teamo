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
        public DataTable Thongke_NhieuNgay(DateTime ngay1, DateTime ngay2)
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("proc_ThongKe_Nhieungay", Conn);
            command.CommandType = CommandType.StoredProcedure; 
            command.Parameters.Add("@ngay1", SqlDbType.DateTime2);
            command.Parameters.Add("@ngay2", SqlDbType.DateTime2);

            command.Parameters["@ngay1"].Value = ngay1;
            command.Parameters["@ngay2"].Value = ngay2;
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
