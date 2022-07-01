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
    public class BUS_Nhanvien
    {
        private static BUS_Nhanvien instance;

        public static BUS_Nhanvien Instance
        {
            get { if (instance == null) instance = new BUS_Nhanvien(); return instance; }
            private set { instance = value; }
        }

        public DataTable DS_NV() // xem danh sách nhân viên
        {
            return DAL_Nhanvien.Instance.DS_NV();
        }

        public void InsertNhanVien(DTO_Nhanvien Nv) // thêm nhân viên
        {
            DAL_Nhanvien.Instance.InsertNV(Nv);
        }

        public void UpdateNhanvien(DTO_Nhanvien Nv)  // sửa nhân viên
        {
            DAL_Nhanvien.Instance.UpdateNV(Nv);
        }

        public void DeleteNhanvien(string maNv) // xóa nhân viên
        {
            DAL_Nhanvien.Instance.DeleteNV(maNv);
        }

        public  DataTable search(string manv) // tìm kiếm nhân viên
        {

            return DAL_Nhanvien.Instance.SearchNV(manv);
        }
        public DataTable Xem_TTNV(string tendn)
        {
            return DAL_Nhanvien.Instance.thongTinNhanVien(tendn);
        }
    }
}
