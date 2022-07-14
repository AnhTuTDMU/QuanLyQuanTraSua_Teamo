using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_Khachhang
    {
        private static DAL_Khachhang instance;

        public static DAL_Khachhang Instance
        {
            get { if (instance == null) instance = new DAL_Khachhang(); return instance; }
            private set { instance = value; }
        }

        private DAL_Khachhang() { }
        public void Them_Khachang(DTO_KhachHang KH)
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("proc_ThemKhachhang", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ten", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@sdt", SqlDbType.NVarChar, 10);
        

            command.Parameters["@ten"].Value = KH.TenkH;
            command.Parameters["@sdt"].Value = KH.Sdt;
          
       

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();

        }
        public bool XemTT_KhachHang(string sdt)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connec = ConnecData.conncetion()) // sử dụng using giải phóng bộ nhớ
            {
                connec.Open();
                SqlCommand cmd = new SqlCommand("proc_XemTTKH", connec);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sdt", sdt);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // trung gian lấy dữ liệu ra thực hiện câu truy vấn

                adapter.Fill(dt);

                connec.Close();
            }
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable Xem_Khachhang(string sdt)
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("proc_XemTTKH", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@sdt", sdt);
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public DataTable Xem_TT_TatcaKH()
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("proc_XemTT_tatcaKH", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
    }
}
