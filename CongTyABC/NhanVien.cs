using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongTyABC
{
    public abstract class NhanVien : INhanVien
    {
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }

        public virtual void NhapThongTin()
        {
            Console.Write("Họ tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Ngày sinh (MM/dd/yyyy): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime ngaySinh))
            {
                NgaySinh = ngaySinh;
            }
            else
            {
                Console.WriteLine("Ngày sinh không hợp lệ. Đặt mặc định là 01/01/1990");
                NgaySinh = new DateTime(1990, 1, 1);
            }

            Console.Write("Địa chỉ: ");
            DiaChi = Console.ReadLine();
        }
        public abstract decimal TinhLuong();
        public virtual void XuatThongTin()
        {
            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Ngày sinh: {NgaySinh.ToString("dd/MM/yyyy")}");
            Console.WriteLine($"Địa chỉ: {DiaChi}");
        }
    }
}
