using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_Thongke
    {
        private static BUS_Thongke instance;

        public static BUS_Thongke Instance
        {
            get { if (instance == null) instance = new BUS_Thongke(); return instance; }
            private set { instance = value; }
        }

        private BUS_Thongke() { }
        public DataTable Xem_Hoadonchitiet(int id)
        {
            return DAL_ThongKe.Instance.Xem_Hoadonchitiet(id);
        }
        public DataTable ThongKe_NhieuNgay(DateTime ngay1,DateTime ngay2)
        {
            return DAL_ThongKe.Instance.Thongke_NhieuNgay(ngay1, ngay2);
        }
    }
}
