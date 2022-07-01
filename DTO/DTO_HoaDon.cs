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
        private int gia;

        public string Tenmon { get => tenmon; set => tenmon = value; }
        public int Sl { get => sl; set => sl = value; }
        public int Gia { get => gia; set => gia = value; }

        public  DTO_HoaDon(string tenmon = null, int sl = 0, int gia = 0)
        {
            this.tenmon = tenmon;
            this.sl = sl;
            this.gia = gia;
        }

        public DTO_HoaDon()
        {
        }
    }
}
