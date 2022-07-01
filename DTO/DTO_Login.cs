using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Login
    {
        private string taikhoan;
        private string matkhau;
        private int loaitk;

        public DTO_Login(string taikhoan, string matkhau , int loaitk)
        {
            this.Taikhoan = taikhoan;
            this.Matkhau = matkhau;
            this.Loaitk = loaitk;
        }

        public string Taikhoan { get => taikhoan; set => taikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public int Loaitk { get => loaitk; set => loaitk = value; }

        public DTO_Login(DataRow row)
        {
            this.Taikhoan = row["Tên đăng nhập"].ToString();
            this.Matkhau = row["Mật khẩu"].ToString();
            this.Loaitk = (int)row["Quyền"];
           
        }
    }
}
