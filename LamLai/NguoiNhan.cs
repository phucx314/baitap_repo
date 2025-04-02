using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamLai
{
    class NguoiNhan : Nguoi
    {
        public string DiaChiNhan { get; set; }

        public NguoiNhan(string ten, string soDienThoai, int tuoi, string diaChiNhan) : base(ten, soDienThoai, tuoi)
        {
            DiaChiNhan = diaChiNhan;
        }
    }
}
