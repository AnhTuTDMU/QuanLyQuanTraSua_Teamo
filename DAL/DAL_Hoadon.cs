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
    public class DAL_Hoadon
    {
        private static DAL_Hoadon instance;

        public static DAL_Hoadon Instance
        {
            get { if (instance == null) instance = new DAL_Hoadon(); return instance; }
            private set { instance = value; }
        }
        // lưu bill xuống bảng Hoadonchitiet
        public void luu_Bill(int id,string ten,int sl, int gia,int giamgia, int thanhtien)
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("proc_insertData_test", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters.Add("@ten", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@sl", SqlDbType.Int);
            command.Parameters.Add("@gia", SqlDbType.Int);
            command.Parameters.Add("@giamgia", SqlDbType.Int);
            command.Parameters.Add("@thanhtien", SqlDbType.Int);


            command.Parameters["@id"].Value = id;
            command.Parameters["@ten"].Value = ten;
            command.Parameters["@sl"].Value = sl;
            command.Parameters["@gia"].Value = gia;
            command.Parameters["@giamgia"].Value = giamgia;
            command.Parameters["@thanhtien"].Value = thanhtien;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        // xem Bill theo id
        public DataTable Xem_Bill(int id)
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("proc_idHD", Conn);
            command.CommandType = CommandType.StoredProcedure; command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters["@id"].Value = id;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
            
        }
        // lưu id bill vào bảng hoadon
        public void Luu_idBill(DateTime Ngaylapbill,int giamgia,int TT,string ten_nv,string ten_KH)
        {

            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("proc_luuid", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ngaylapbill", SqlDbType.DateTime);
            command.Parameters.Add("@giamgia", SqlDbType.Int);
            command.Parameters.Add("@TT", SqlDbType.Int);
            command.Parameters.Add("@Ten_nv", SqlDbType.NVarChar);
            command.Parameters.Add("@Ten_KH", SqlDbType.NVarChar);

            command.Parameters["@ngaylapbill"].Value = Ngaylapbill;
            command.Parameters["@giamgia"].Value = giamgia;
            command.Parameters["@TT"].Value = TT;
            command.Parameters["@Ten_nv"].Value = ten_nv;
            command.Parameters["@Ten_KH"].Value = ten_KH;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        //lay ID bill từ bảng hoadon
        public DataTable LayIDBill()
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("proc_Showidbill", Conn);
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
            
        }
        // capnhat Tổng tiền xuống bảng Hoadon
        public void Capnhat_TT(int id,int TT)
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("proc_Capnhat_TongTien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@id", SqlDbType.Int);
            command.Parameters.Add("@TongTien", SqlDbType.Int);

            command.Parameters["@id"].Value = id;
            command.Parameters["@TongTien"].Value = TT;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
