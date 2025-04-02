using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongTyABC
{
    public class NhanVienCongNhat : NhanVien
    {
        public int SoNgayCong { get; set; }
        private const decimal GiaTienMoiNgayCong = 50000;

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Số ngày công: ");
            if (int.TryParse(Console.ReadLine(), out int soNgayCong))
            {
                SoNgayCong = soNgayCong;
            }
            else
            {
                Console.WriteLine("Số ngày công không hợp lệ. Đặt mặc định là 0");
                SoNgayCong = 0;
            }
        }

        public override void XuatThongTin()
        {
            Console.WriteLine("\n===== NHÂN VIÊN CÔNG NHẬT =====");
            base.XuatThongTin();
            Console.WriteLine($"Số ngày công: {SoNgayCong}");
            Console.WriteLine($"Lương: {TinhLuong():N0}đ");
        }

        public override decimal TinhLuong()
        {
            return SoNgayCong * GiaTienMoiNgayCong;
        }
    }
}
