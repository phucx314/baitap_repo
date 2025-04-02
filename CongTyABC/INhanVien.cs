using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongTyABC
{
    interface INhanVien
    {
        string HoTen { get; set; }
        DateTime NgaySinh { get; set; }
        string DiaChi { get; set; }
        decimal TinhLuong();
        void NhapThongTin();
        void XuatThongTin();
    }
}
