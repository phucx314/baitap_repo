using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongTyABC
{
    public class NhanVienSanXuat : NhanVien
    {
        public int SoSanPham { get; set; }
        private const decimal GiaTienMoiSanPham = 20000;

        public override void NhapThongTin()
        {
            base.NhapThongTin();
            Console.Write("Số sản phẩm: ");
            if (int.TryParse(Console.ReadLine(), out int soSanPham))
            {
                SoSanPham = soSanPham;
            }
            else
            {
                Console.WriteLine("Số sản phẩm không hợp lệ. Đặt mặc định là 0");
                SoSanPham = 0;
            }
        }

        public override void XuatThongTin()
        {
            Console.WriteLine("\n===== NHÂN VIÊN SẢN XUẤT =====");
            base.XuatThongTin();
            Console.WriteLine($"Số sản phẩm: {SoSanPham}");
            Console.WriteLine($"Lương: {TinhLuong():N0}đ");
        }

        public override decimal TinhLuong()
        {
            return SoSanPham * GiaTienMoiSanPham;
        }
    }
}
