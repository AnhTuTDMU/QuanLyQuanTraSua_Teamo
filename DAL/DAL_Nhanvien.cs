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
    public class DAL_Nhanvien
    {
        // xem danh sách nhân viên
        private static DAL_Nhanvien instance;

        public static DAL_Nhanvien Instance
        {
            get { if (instance == null) instance = new DAL_Nhanvien(); return instance; }
            private set { instance = value; }
        }

        private DAL_Nhanvien() { }
        public DataTable DS_NV()
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("DS_NV", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }

        // thêm nhân viên
        public void InsertNV(DTO_Nhanvien Nv)
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("Them_NV", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@manv", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@tennv", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@tendangnhap", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@matkhau", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@sodt", SqlDbType.Int);
            command.Parameters.Add("@quyen", SqlDbType.Int);


            command.Parameters["@manv"].Value = Nv.Ma_NV1;
            command.Parameters["@tennv"].Value = Nv.Ten_NV1;
            command.Parameters["@tendangnhap"].Value = Nv.Ten_DN1;
            command.Parameters["@matkhau"].Value = Nv.Mat_Khau1;
            command.Parameters["@Email"].Value = Nv.Email1;
            command.Parameters["@sodt"].Value = Nv.So_DT1;
            command.Parameters["@quyen"].Value = Nv.Quyen;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();

        }
        // Sửa thông tin nhân viên
        public void UpdateNV(DTO_Nhanvien Nv)
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("Sua_NV", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@manv", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@tennv", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@tendangnhap", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@matkhau", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@Email", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@sodt", SqlDbType.Int);
            command.Parameters.Add("@quyen", SqlDbType.Int);

            command.Parameters["@manv"].Value = Nv.Ma_NV1;
            command.Parameters["@tennv"].Value = Nv.Ten_NV1;
            command.Parameters["@tendangnhap"].Value = Nv.Ten_DN1;
            command.Parameters["@matkhau"].Value = Nv.Mat_Khau1;
            command.Parameters["@Email"].Value = Nv.Email1;
            command.Parameters["@sodt"].Value = Nv.So_DT1;
            command.Parameters["@quyen"].Value = Nv.Quyen;
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();

        }
        // Xóa thông tin nhân viên
        public void DeleteNV(string maNv)
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("Xoa_NV", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@manv", SqlDbType.NVarChar, 50);
            command.Parameters["@manv"].Value = maNv;
            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();

        }
        // tìm kiếm nhân viên
        public DataTable SearchNV(string manv)
        {
            SqlConnection Conn = ConnecData.conncetion();
            SqlCommand command = new SqlCommand("Tim_Kiem", Conn);
            command.CommandType = CommandType.StoredProcedure; command.Parameters.Add("@manv", SqlDbType.NVarChar, 50);
            command.Parameters["@manv"].Value = manv;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            Conn.Close();

        }

        // xem quyền truy cập 
        public DataTable thongTinNhanVien(string tendn)
        {

            SqlConnection Conn = ConnecData.conncetion();
            Conn.Open();
            SqlCommand command = new SqlCommand("proc_XemTTNV", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ten", SqlDbType.NVarChar, 50);
            command.Parameters["@ten"].Value = tendn;
            DataTable data = new DataTable();
            data.Load(command.ExecuteReader());
            return data;
            Conn.Close();
        }
    }
}
