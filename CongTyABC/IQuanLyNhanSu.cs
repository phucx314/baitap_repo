using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongTyABC
{
    interface IQuanLyNhanSu
    {
        void ThemNhanVien(INhanVien nhanVien);
        void NhapDanhSachNhanVien();
        void XuatDanhSachNhanVien();
        decimal TinhTongLuong();
        INhanVien TimNhanVienLuongCaoNhat();
        INhanVien TimNhanVienLuongThapNhat();
    }
}
