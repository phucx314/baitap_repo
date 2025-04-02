using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongTyABC
{
    public class NhanVienQuanLy : NhanVien
    {
        public decimal LuongCoBan { get; set; }
        public decimal HeSoLuong { get; set; }

        public override void NhapThongTin()
        {
            base.NhapThongTin();

            Console.Write("Lương cơ bản: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal luongCoBan))
            {
                LuongCoBan = luongCoBan;
            }
            else
            {
                Console.WriteLine("Lương cơ bản không hợp lệ. Đặt mặc định là 0");
                LuongCoBan = 0;
            }

            Console.Write("Hệ số lương: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal heSoLuong))
            {
                HeSoLuong = heSoLuong;
            }
            else
            {
                Console.WriteLine("Hệ số lương không hợp lệ. Đặt mặc định là 1");
                HeSoLuong = 1;
            }
        }

        public override void XuatThongTin()
        {
            Console.WriteLine("\n===== NHÂN VIÊN QUẢN LÝ =====");
            base.XuatThongTin();
            Console.WriteLine($"Lương cơ bản: {LuongCoBan:N0}đ");
            Console.WriteLine($"Hệ số lương: {HeSoLuong}");
            Console.WriteLine($"Lương: {TinhLuong():N0}đ");
        }

        public override decimal TinhLuong()
        {
            return LuongCoBan * HeSoLuong;
        }
    }
}
