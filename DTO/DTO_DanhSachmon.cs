using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DanhSachmon
    {
        private string tenmon;
        private string gia;
        private byte[] hinhanh;

        public DTO_DanhSachmon()
        {
        }
        public DTO_DanhSachmon(string tenmon,string gia,byte[] hinhanh)
        {
            this.Tenmon = tenmon;
            this.Gia = gia;
            this.Hinhanh = hinhanh;
        }
        public string Tenmon { get => tenmon; set => tenmon = value; }
        public string Gia { get => gia; set => gia = value; }
        public byte[] Hinhanh { get => hinhanh; set => hinhanh = value; }
    }
}
