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

        public DataTable ThongKe_TheoNgay(DateTime ngay)
        {
            return DAL_ThongKe.Instance.Thongke_Ngay(ngay);
        }
        public DataTable Xem_Hoadonchitiet(int id)
        {
            return DAL_ThongKe.Instance.Xem_Hoadonchitiet(id);
        }
    }
}
