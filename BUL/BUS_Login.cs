using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_Login
    {
        private static BUS_Login instance;

        public static BUS_Login Instance
        {
            get { if (instance == null) instance = new BUS_Login(); return instance; }
            private set { instance = value; }
        }

        private BUS_Login() { }
        // kiểm tra đăng nhập
        public bool Check_Login(string tk, string mk)
        {
            return DAL_Login.Instance.Login(tk, mk);
        }
       
    }
}
