using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Nhanvien
    {
        private static DTO_Nhanvien instance;

        public static DTO_Nhanvien Instance
        {
            get { if (instance == null) instance = new DTO_Nhanvien(); return instance; }
            private set { instance = value; }
        }

        private DTO_Nhanvien() { }

        private string Ma_NV;
        private string Ten_NV;
        private string Ten_DN;
        private string Mat_Khau;
        private string Email;
        private int So_DT;
        private int quyen;
        public DTO_Nhanvien(string ma_NV, string ten_NV, string ten_DN, string mat_Khau, string email, int so_DT, int quyen)
        {
            Ma_NV1 = ma_NV;
            Ten_NV1 = ten_NV;
            Ten_DN1 = ten_DN;
            Mat_Khau1 = mat_Khau;
            Email1 = email;
            So_DT1 = so_DT;
            Quyen = quyen;
        }


        public string Ma_NV1 { get => Ma_NV; set => Ma_NV = value; }
        public string Ten_NV1 { get => Ten_NV; set => Ten_NV = value; }
        public string Ten_DN1 { get => Ten_DN; set => Ten_DN = value; }
        public string Mat_Khau1 { get => Mat_Khau; set => Mat_Khau = value; }
        public string Email1 { get => Email; set => Email = value; }
        public int So_DT1 { get => So_DT; set => So_DT = value; }
        public int Quyen { get => quyen; set => quyen = value; }

        public DTO_Nhanvien(string ma_NV)
        {
            Ma_NV1 = ma_NV;

        }
    }
}
