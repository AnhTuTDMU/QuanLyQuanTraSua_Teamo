using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_Danhsachmon
    {
        private static BUS_Danhsachmon instance;

        public static BUS_Danhsachmon Instance
        {
            get { if (instance == null) instance = new BUS_Danhsachmon(); return instance; }
            private set { instance = value; }
        }
      
        private BUS_Danhsachmon() { }

        public void Them_Mon_an(string ten, string gia,byte[] hinh) // thêm món ăn
           {
               DAL_Danhsachmon.Instance.Them_Monan(ten, gia,hinh);
           }
   
        public void Them_Thuc_uong(string ten, string gia, byte[]hinh) // thêm đồ uống
        {
            DAL_Danhsachmon.Instance.Them_Thucuong(ten, gia, hinh);
        }

        public DataTable DS_Monan() // xem danh sách món ăn
        {
            return DAL_Danhsachmon.DS_Monan();
        }

        public DataTable DS_Douong() // xem danh sách đồ uống
        {
            return DAL_Danhsachmon.DS_Douong();
        }

        public void Xoa_Mon_an(string ten)  // xóa món ăn
        {
            DAL_Danhsachmon.Instance.Xoa_Monan(ten);
        }

        public void Xoa_Thuc_uong(string ten) // xóa đồ uống
        {
            DAL_Danhsachmon.Instance.Xoa_Thucuong(ten);
        }
        public void Sua_Mon_an(string ten,string gia, byte[] hinh)  // sửa món ăn
        {
            DAL_Danhsachmon.Instance.Sua_Monan(ten,gia,hinh);
        }
        public void Sua_Thuc_uong(string ten, string gia, byte[] hinh)  // sửa thức uống
        {
            DAL_Danhsachmon.Instance.Sua_Thucuong(ten, gia, hinh);
        }
    }
}
