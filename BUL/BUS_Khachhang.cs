using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_Khachhang
    {
        private static BUS_Khachhang instance;

        public static BUS_Khachhang Instance
        {
            get { if (instance == null) instance = new BUS_Khachhang(); return instance; }
            private set { instance = value; }
        }
        private BUS_Khachhang() { }
        public void Them_Khachhang(DTO_KhachHang KH) // thêm khách hàng
        {
            DAL_Khachhang.Instance.Them_Khachang(KH);
        }
        public bool XemTT_Khachhang(string sdt)
        {
            return DAL_Khachhang.Instance.XemTT_KhachHang(sdt);
        }
        public DataTable Xem_Khachhang(string sdt)
        {
            return DAL_Khachhang.Instance.Xem_Khachhang(sdt);
        }
    }
}
