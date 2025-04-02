﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoHiem
{
    class NhanVien
    {
        public string Ten { get; set; }
        public decimal HeSoLuong { get; set; }
        public List<IBaoHiem> DanhSachBaoHiem { get; set; }

        public NhanVien()
        {
            DanhSachBaoHiem = new List<IBaoHiem>();
        }

        // Tính tổng hoa hồng
        public decimal TinhTongHoaHong()
        {
            return DanhSachBaoHiem.Sum(baoHiem => baoHiem.TinhHoaHong());
        }

        // Tính tổng số tiền bán được
        public decimal TinhTongDoanhSo()
        {
            return DanhSachBaoHiem.Sum(baoHiem => baoHiem.SoTien);
        }

        // Kiểm tra xem nhân viên có bán được bảo hiểm trên 10000USD không
        public bool DaBanBaoHiemTren10000()
        {
            return DanhSachBaoHiem.Any(baoHiem => baoHiem.SoTien > 10000);
        }

        // Kiểm tra xem tổng doanh số có dưới 10000USD không
        public bool TongDoanhSoDuoi10000()
        {
            return TinhTongDoanhSo() < 10000;
        }

        // Tính lương nhân viên
        public decimal TinhLuong()
        {
            decimal luongCoBan = 40 * HeSoLuong;
            decimal tongDoanhSo = TinhTongDoanhSo();
            decimal hoaHong = TinhTongHoaHong();
            decimal phanThuong = 0.01m * (tongDoanhSo - hoaHong);

            decimal luong = luongCoBan + phanThuong;

            // Thêm thưởng 100USD nếu bán được bảo hiểm trên 10000USD
            if (DaBanBaoHiemTren10000())
            {
                luong += 100;
            }

            // Trừ phạt 30USD nếu tổng doanh số dưới 10000USD
            if (TongDoanhSoDuoi10000())
            {
                luong -= 30;
            }

            return luong;
        }

        public override string ToString()
        {
            string ketQua = $"Nhân viên: {Ten}, Hệ số lương: {HeSoLuong}, Lương: {TinhLuong():C}\n";
            ketQua += $"Tổng doanh số: {TinhTongDoanhSo():C}, Tổng hoa hồng: {TinhTongHoaHong():C}\n";

            if (DaBanBaoHiemTren10000())
            {
                ketQua += "Thưởng: 100 USD\n";
            }

            if (TongDoanhSoDuoi10000())
            {
                ketQua += "Phạt: 30 USD\n";
            }

            ketQua += "Danh sách bảo hiểm đã bán:\n";

            foreach (var baoHiem in DanhSachBaoHiem)
            {
                ketQua += $"  - {baoHiem}\n";
            }

            return ketQua;
        }
    }
}
