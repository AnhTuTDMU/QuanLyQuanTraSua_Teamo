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
    public class DAL_Danhsachmon
    {
        private static DAL_Danhsachmon instance;

        public static DAL_Danhsachmon Instance
        {
            get { if (instance == null) instance = new DAL_Danhsachmon(); return instance; }
            private set { instance = value; }
        }
      

        // thêm món ăn
        public void Them_Monan(string ten, string gia, byte[] hinh)
        { 
            SqlConnection Conn = ConnecData.conncetion();
            Conn.Open();
            SqlCommand command = new SqlCommand("proc_Them_Monan", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ten", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@gia", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@hinh", SqlDbType.VarBinary,9999999);

            command.Parameters["@ten"].Value = ten;
            command.Parameters["@gia"].Value = gia;
            command.Parameters["@hinh"].Value = hinh;

            command.ExecuteNonQuery();
            Conn.Close();
            
        }


        // thêm đồ uống

        public void Them_Thucuong(string ten, string gia, byte[] hinh)
        {
            SqlConnection Conn = ConnecData.conncetion();
            Conn.Open();
            SqlCommand command = new SqlCommand("proc_Them_Thucuong", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ten", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@gia", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@hinh", SqlDbType.VarBinary, 9999999);

            command.Parameters["@ten"].Value = ten;
            command.Parameters["@gia"].Value = gia;
            command.Parameters["@hinh"].Value = hinh;

            command.ExecuteNonQuery();
            Conn.Close();

        }

        // xem danh sách món ăn

        public static DataTable DS_Monan() 
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("proc_Xem_Monan", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        // xem danh sách đồ uống

        public static DataTable DS_Douong() 
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("proc_Xem_Thucuong", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        // xóa món ăn

        public void Xoa_Monan(string ten) 
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("proc_Xoa_Monan", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ten", SqlDbType.NVarChar, 50);
            command.Parameters["@ten"].Value = ten;
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();

        }

        // xóa đồ uống

        public void Xoa_Thucuong(string ten) 
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("proc_Xoa_Thucuong", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ten", SqlDbType.NVarChar, 50);
            command.Parameters["@ten"].Value = ten;
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();

        }

        // Sửa món ăn

       public void Sua_Monan(string ten, string gia, byte[] hinh)
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("proc_Sua_Monan", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ten", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@gia", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@hinh", SqlDbType.VarBinary, 999999);


            command.Parameters["@ten"].Value = ten;
            command.Parameters["@gia"].Value = gia;
            command.Parameters["@hinh"].Value = hinh;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();

        }
        public void Sua_Thucuong(string ten, string gia, byte[] hinh)
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("proc_Sua_Thucuong", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ten", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@gia", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@hinh", SqlDbType.VarBinary, 999999);


            command.Parameters["@ten"].Value = ten;
            command.Parameters["@gia"].Value = gia;
            command.Parameters["@hinh"].Value = hinh;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();

        }
    
    }
  
}
