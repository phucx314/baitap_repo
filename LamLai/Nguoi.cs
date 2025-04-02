using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamLai
{
    class Nguoi
    {
        public string Ten { get; set; }
        public string SoDienThoai { get; set; }
        public int Tuoi { get; set; }

        public Nguoi(string ten, string soDienThoai, int tuoi)
        {
            Ten = ten;
            SoDienThoai = soDienThoai;
            Tuoi = tuoi;
        }
    }
}
