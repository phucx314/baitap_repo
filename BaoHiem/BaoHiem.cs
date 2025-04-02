using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoHiem
{
    public abstract class BaoHiem : IBaoHiem
    {
        public string TenNguoiMua { get; set; }
        public int ThoiHan { get; set; }
        public decimal SoTien { get; set; }


        public abstract decimal TinhHoaHong();
    }
}
