using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoHiem
{
    interface IBaoHiem
    {
        string TenNguoiMua { get; set; }
        int ThoiHan { get; set; }
        decimal SoTien { get; set; }
        decimal TinhHoaHong();
    }
}
