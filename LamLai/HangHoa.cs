using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamLai
{
    class HangHoa : BuuPham
    {
        public double TrongLuong { get; set; }

        public HangHoa(string diaChiNhan, NguoiNhan nguoiNhan, NguoiGui nguoiGui, double trongLuong) : base(diaChiNhan, nguoiNhan, nguoiGui)
        {
            TrongLuong = trongLuong;
        }

        public override double TinhPhiVanChuyen()
        {
            return 10000 * TrongLuong;
        }
    }
}
