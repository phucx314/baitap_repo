using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoHiem
{
    public class BaoHiemNganHan : BaoHiem
    {
        public override decimal TinhHoaHong()
        {
            // Hoa hồng 5%
            return SoTien * 0.05m;
        }

        public override string ToString()
        {
            return $"Bảo hiểm ngắn hạn: {base.ToString()}, Hoa hồng: {TinhHoaHong():C}";
        }
    }
}
