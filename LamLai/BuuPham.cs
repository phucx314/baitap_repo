using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamLai
{
    abstract class BuuPham
    {
        public string DiaChiNhan { get; set; }
        public NguoiNhan NguoiNhann { get; set; }
        public NguoiGui NguoiGuii { get; set; }

        public BuuPham(string diaChiNhan, NguoiNhan nguoiNhan, NguoiGui nguoiGui)
        {
            DiaChiNhan = diaChiNhan;
            NguoiNhann = nguoiNhan;
            NguoiGuii = nguoiGui;
        }

        public abstract double TinhPhiVanChuyen();
    }
}
