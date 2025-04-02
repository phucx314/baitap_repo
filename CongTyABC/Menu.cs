using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongTyABC
{
    class Menu
    {
        private IQuanLyNhanSu quanLyNhanVien;

        public Menu(IQuanLyNhanSu quanLyNhanVien)
        {
            this.quanLyNhanVien = quanLyNhanVien;
        }

        public void HienThiMenu()
        {
            int luaChon;
            do
            {
                Console.WriteLine("\n=========== QUẢN LÝ NHÂN SỰ CÔNG TY ABC ===========");
                Console.WriteLine("1. Nhập thông tin một nhân viên mới");
                Console.WriteLine("2. Nhập danh sách nhân viên");
                Console.WriteLine("3. Hiển thị danh sách nhân viên");
                Console.WriteLine("4. Tính tổng lương toàn bộ nhân viên");
                Console.WriteLine("5. Tìm nhân viên có lương cao nhất");
                Console.WriteLine("6. Tìm nhân viên có lương thấp nhất");
                Console.WriteLine("0. Thoát");
                Console.Write("Lựa chọn của bạn: ");

                if (int.TryParse(Console.ReadLine(), out luaChon))
                {
                    XuLyLuaChon(luaChon);
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại");
                    luaChon = -1;
                }
            }
            while (luaChon != 0);
        }

        private void XuLyLuaChon(int luaChon)
        {
            switch (luaChon)
            {
                case 1:
                    INhanVien nhanVien = ((QuanLyNhanSu)quanLyNhanVien).NhapThongTinNhanVien();
                    quanLyNhanVien.ThemNhanVien(nhanVien);
                    break;
                case 2:
                    quanLyNhanVien.NhapDanhSachNhanVien();
                    break;
                case 3:
                    quanLyNhanVien.XuatDanhSachNhanVien();
                    break;
                case 4:
                    decimal tongLuong = quanLyNhanVien.TinhTongLuong();
                    Console.WriteLine($"\nTổng lương toàn bộ nhân viên: {tongLuong:N0} VNĐ");
                    break;
                case 5:
                    INhanVien nvLuongCaoNhat = quanLyNhanVien.TimNhanVienLuongCaoNhat();
                    if (nvLuongCaoNhat != null)
                    {
                        Console.WriteLine("\n===== NHÂN VIÊN CÓ LƯƠNG CAO NHẤT =====");
                        nvLuongCaoNhat.XuatThongTin();
                    }
                    else
                    {
                        Console.WriteLine("Danh sách nhân viên trống");
                    }
                    break;
                case 6:
                    INhanVien nvLuongThapNhat = quanLyNhanVien.TimNhanVienLuongThapNhat();
                    if (nvLuongThapNhat != null)
                    {
                        Console.WriteLine("\n===== NHÂN VIÊN CÓ LƯƠNG THẤP NHẤT =====");
                        nvLuongThapNhat.XuatThongTin();
                    }
                    else
                    {
                        Console.WriteLine("Danh sách nhân viên trống");
                    }
                    break;
                case 0:
                    Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình!");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại");
                    break;
            }
        }
    }
}
