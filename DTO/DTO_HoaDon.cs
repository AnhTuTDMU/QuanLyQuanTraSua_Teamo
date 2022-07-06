using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HoaDon
    {
        private string tenmon;
        private int sl;
        private int giamgia;
        private int gia;
        private int ThanhTien;
        public string Tenmon { get => tenmon; set => tenmon = value; }
        public int Sl { get => sl; set => sl = value; }
       
        public int Gia { get => gia; set => gia = value; }
        public int Giamgia { get => giamgia; set => giamgia = value; }
        public int ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }

        public  DTO_HoaDon(string tenmon = null, int sl = 0,int gia = 0, int giamgia = 0,int Thanhtien = 0)
        {
            this.tenmon = tenmon;
            this.sl = sl;
            this.Gia = gia;
            this.Giamgia = giamgia;
            this.ThanhTien1 = Thanhtien;
        }

        public DTO_HoaDon()
        {
        }
    }
}
