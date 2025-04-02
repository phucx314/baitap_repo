using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongTyABC
{
    class QuanLyNhanSu : IQuanLyNhanSu
    {
        private List<INhanVien> danhSachNhanVien;

        public QuanLyNhanSu()
        {
            danhSachNhanVien = new List<INhanVien>();
        }

        public INhanVien NhapThongTinNhanVien()
        {
            Console.WriteLine("\n======== NHẬP THÔNG TIN NHÂN VIÊN ========");
            Console.WriteLine("Chọn loại nhân viên:");
            Console.WriteLine("1. Nhân viên sản xuất");
            Console.WriteLine("2. Nhân viên công nhật");
            Console.WriteLine("3. Nhân viên quản lý");
            Console.Write("Lựa chọn của bạn: ");

            if (int.TryParse(Console.ReadLine(), out int loaiNhanVien))
            {
                INhanVien nhanVien = null;

                switch (loaiNhanVien)
                {
                    case 1:
                        nhanVien = new NhanVienSanXuat();
                        break;
                    case 2:
                        nhanVien = new NhanVienCongNhat();
                        break;
                    case 3:
                        nhanVien = new NhanVienQuanLy();
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Tạo nhân viên sản xuất mặc định");
                        nhanVien = new NhanVienSanXuat();
                        break;
                }

                nhanVien.NhapThongTin();
                return nhanVien;
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ. Tạo nhân viên sản xuất mặc định");
                INhanVien nhanVien = new NhanVienSanXuat();
                nhanVien.NhapThongTin();
                return nhanVien;
            }
        }

        public void ThemNhanVien(INhanVien nhanVien)
        {
            danhSachNhanVien.Add(nhanVien);
            Console.WriteLine("Thêm nhân viên thành công!");
        }

        public void NhapDanhSachNhanVien()
        {
            Console.Write("Nhập số lượng nhân viên: ");
            if (int.TryParse(Console.ReadLine(), out int soLuong))
            {
                for (int i = 0; i < soLuong; i++)
                {
                    Console.WriteLine($"\nNhân viên thứ {i + 1}:");
                    INhanVien nhanVien = NhapThongTinNhanVien();
                    ThemNhanVien(nhanVien);
                }
            }
            else
            {
                Console.WriteLine("Số lượng không hợp lệ");
            }
        }

        public void XuatDanhSachNhanVien()
        {
            Console.WriteLine("\n============ DANH SÁCH NHÂN VIÊN ============");

            if (danhSachNhanVien.Count == 0)
            {
                Console.WriteLine("Danh sách nhân viên trống");
                return;
            }

            for (int i = 0; i < danhSachNhanVien.Count; i++)
            {
                Console.WriteLine($"\nNhân viên thứ {i + 1}:");
                danhSachNhanVien[i].XuatThongTin();
                Console.WriteLine("----------------------------------------");
            }
        }

        public decimal TinhTongLuong()
        {
            return danhSachNhanVien.Sum(nv => nv.TinhLuong());
        }

        public INhanVien TimNhanVienLuongCaoNhat()
        {
            if (danhSachNhanVien.Count == 0)
                return null;

            return danhSachNhanVien.OrderByDescending(nv => nv.TinhLuong()).First();
        }

        public INhanVien TimNhanVienLuongThapNhat()
        {
            if (danhSachNhanVien.Count == 0)
                return null;

            return danhSachNhanVien.OrderBy(nv => nv.TinhLuong()).First();
        }
    }
}
