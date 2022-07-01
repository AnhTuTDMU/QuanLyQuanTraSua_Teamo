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
    public class DAL_Login : ConnecData
    {
       
        private static DAL_Login instance;

        public static DAL_Login Instance
        {
            get { if (instance == null) instance = new DAL_Login(); return instance; }
            private set { instance = value; }
        }

        private DAL_Login() { }

        // kiểm tra đăng nhập

        public bool Login(string tk, string mk)
        {
            
            DataTable dt = new DataTable();
            using (SqlConnection connec = ConnecData.conncetion()) // sử dụng using giải phóng bộ nhớ
            {
                connec.Open();
                SqlCommand cmd = new SqlCommand("proc_login", connec);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Taikhoan", tk);
                cmd.Parameters.AddWithValue("@Matkhau", mk);
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
     


    }
}
