using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoHiem
{
    class BaoHiemDaiHan : BaoHiem
    {
        public decimal TienDongHangThang { get; set; }

        public override decimal TinhHoaHong()
        {
            // 50% tiền đóng hàng tháng
            return TienDongHangThang * 0.5m;
        }

        public override string ToString()
        {
            return $"Bảo hiểm dài hạn: {base.ToString()}, Tiền đóng hàng tháng: {TienDongHangThang:C}, Hoa hồng: {TinhHoaHong():C}";
        }
    }
}
