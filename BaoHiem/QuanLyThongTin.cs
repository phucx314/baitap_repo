using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoHiem
{
    public class QuanLyThongTin
    {
        private CongTyBaoHiem congTy;

        public QuanLyThongTin()
        {
            congTy = new CongTyBaoHiem();
        }

        public void NhapDuLieu()
        {
            Console.WriteLine("======= NHẬP THÔNG TIN NHÂN VIÊN =======");
            Console.Write("Nhập số lượng nhân viên: ");
            int soLuongNhanVien = int.Parse(Console.ReadLine());

            for (int i = 0; i < soLuongNhanVien; i++)
            {
                Console.WriteLine($"\nNhân viên thứ {i + 1}:");
                NhanVien nhanVien = new NhanVien();

                Console.Write("Tên: ");
                nhanVien.Ten = Console.ReadLine();

                Console.Write("Hệ số lương: ");
                nhanVien.HeSoLuong = decimal.Parse(Console.ReadLine());

                Console.Write("Số lượng bảo hiểm đã bán: ");
                int soLuongBaoHiem = int.Parse(Console.ReadLine());

                for (int j = 0; j < soLuongBaoHiem; j++)
                {
                    Console.WriteLine($"\nBảo hiểm thứ{j + 1}:");
                    Console.Write("Loại (1 - Ngắn hạn, 2 - Dài hạn): ");
                    int loai = int.Parse(Console.ReadLine());

                    IBaoHiem baoHiem;

                    if (loai == 1)
                    {
                        baoHiem = new BaoHiemNganHan();
                    }
                    else
                    {
                        baoHiem = new BaoHiemDaiHan();
                    }

                    Console.Write("Tên người mua: ");
                    baoHiem.TenNguoiMua = Console.ReadLine();

                    Console.Write("Thời hạn (tháng): ");
                    baoHiem.ThoiHan = int.Parse(Console.ReadLine());

                    Console.Write("Số tiền: ");
                    baoHiem.SoTien = decimal.Parse(Console.ReadLine());

                    if (baoHiem is BaoHiemDaiHan baoHiemDaiHan)
                    {
                        Console.Write("Tiền đóng hàng tháng: ");
                        baoHiemDaiHan.TienDongHangThang = decimal.Parse(Console.ReadLine());
                    }

                    nhanVien.DanhSachBaoHiem.Add(baoHiem);
                }

                congTy.ThemNhanVien(nhanVien);
            }
        }

        public void HienThiTatCaNhanVien()
        {
            Console.WriteLine("\n======= DANH SÁCH TẤT CẢ NHÂN VIÊN =======");
            List<NhanVien> danhSachNhanVien = congTy.LayTatCaNhanVien();

            if (danhSachNhanVien.Count == 0)
            {
                Console.WriteLine("Không tìm thấy nhân viên nào");
                return;
            }

            foreach (var nhanVien in danhSachNhanVien)
            {
                Console.WriteLine(nhanVien);
                Console.WriteLine("---------------------------");
            }
        }

        public void HienThiNhanVienCoHoaHongTren50()
        {
            Console.WriteLine("\n======= NHÂN VIÊN CÓ HOA HỒNG TRÊN 50 USD =======");
            List<NhanVien> danhSachNhanVien = congTy.LayNhanVienCoHoaHongTren50();

            if (danhSachNhanVien.Count == 0)
            {
                Console.WriteLine("Không tìm thấy nhân viên nào");
                return;
            }

            foreach (var nhanVien in danhSachNhanVien)
            {
                Console.WriteLine($"{nhanVien.Ten} - Hoa hồng: {nhanVien.TinhTongHoaHong():C}");
            }
        }

        public void HienThiNhanVienBiPhat()
        {
            Console.WriteLine("\n======= NHÂN VIÊN BỊ PHẠT =======");
            List<NhanVien> danhSachNhanVien = congTy.LayNhanVienBiPhat();

            if (danhSachNhanVien.Count == 0)
            {
                Console.WriteLine("Không tìm thấy nhân viên nào");
                return;
            }

            foreach (var nhanVien in danhSachNhanVien)
            {
                Console.WriteLine($"{nhanVien.Ten} - Tổng doanh số: {nhanVien.TinhTongDoanhSo():C}");
            }
        }

        public void HienThiNhanVienDuocThuong()
        {
            Console.WriteLine("\n======= NHÂN VIÊN ĐƯỢC THƯỞNG =======");
            List<NhanVien> danhSachNhanVien = congTy.LayNhanVienDuocThuong();

            if (danhSachNhanVien.Count == 0)
            {
                Console.WriteLine("Không tìm thấy nhân viên nào");
                return;
            }

            foreach (var nhanVien in danhSachNhanVien)
            {
                Console.WriteLine($"{nhanVien.Ten} - Đã bán bảo hiểm trên 10000 USD");
            }
        }

        public void ChayChuongTrinh()
        {
            NhapDuLieu();
            HienThiTatCaNhanVien();
            HienThiNhanVienCoHoaHongTren50();
            HienThiNhanVienBiPhat();
            HienThiNhanVienDuocThuong();
        }
    }
}
