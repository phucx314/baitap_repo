using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoHiem
{
    class CongTyBaoHiem
    {
        private List<NhanVien> danhSachNhanVien;

        public CongTyBaoHiem()
        {
            danhSachNhanVien = new List<NhanVien>();
        }

        public void ThemNhanVien(NhanVien nhanVien)
        {
            danhSachNhanVien.Add(nhanVien);
        }

        public List<NhanVien> LayTatCaNhanVien()
        {
            return danhSachNhanVien;
        }

        public List<NhanVien> LayNhanVienCoHoaHongTren50()
        {
            return danhSachNhanVien.Where(nv => nv.TinhTongHoaHong() > 50).ToList();
        }

        public List<NhanVien> LayNhanVienBiPhat()
        {
            return danhSachNhanVien.Where(nv => nv.TongDoanhSoDuoi10000()).ToList();
        }

        public List<NhanVien> LayNhanVienDuocThuong()
        {
            return danhSachNhanVien.Where(nv => nv.DaBanBaoHiemTren10000()).ToList();
        }
    }
}
