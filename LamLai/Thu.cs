using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamLai
{
    class Thu : BuuPham
    {

        public LoaiThu LoaiThuu { get; set; }

        public Thu(string diaChiNhan, NguoiNhan nguoiNhan, NguoiGui nguoiGui, LoaiThu loai) : base(diaChiNhan, nguoiNhan, nguoiGui)
        {
            LoaiThuu = loai;
        }

        public override double TinhPhiVanChuyen()
        {
            return LoaiThuu == LoaiThu.Thuong ? 500 : 3000;
        }
    }
}
