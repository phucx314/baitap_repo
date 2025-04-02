using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamLai
{
    class PostOffice
    {
        private List<BuuPham> listBuuPham;
        private Calculator calculator;

        public PostOffice()
        {
            listBuuPham = new List<BuuPham>();
            calculator = new Calculator();
        }

        public void NhapBuuPham()
        {
            Console.Write("Số bưu phẩm cần nhập: ");
            int soBuuPham = int.Parse(Console.ReadLine());

            for (int i = 0; i < soBuuPham; i++)
            {
                Console.Write($"Nhập thông tin bưu phẩm {i + 1} (1 - Thư, 2 - Hàng hoá): ");
                int loaiBuuPham;
                do
                {
                    loaiBuuPham = int.Parse(Console.ReadLine());
                } while (loaiBuuPham != 1 && loaiBuuPham != 2);

                if (loaiBuuPham == 1)
                {
                    NhapThu();
                }
                else if (loaiBuuPham == 2)
                {
                    NhapHangHoa();
                }
            }

            Console.WriteLine("\nThông tin bưu phẩm:");
            XuatDanhSach();
        }

        private void NhapThu()
        {
            Thu thu = new Thu("", null, null, LoaiThu.Thuong);
            Console.Write("Địa chỉ nhận: ");
            thu.DiaChiNhan = Console.ReadLine();
            
            // Nhập thông tin người gửi
            NguoiGui nguoiGui = new NguoiGui("", "", 0, "");
            Console.Write("Tên người gửi: ");
            nguoiGui.Ten = Console.ReadLine();
            Console.Write("Tuổi người gửi: ");
            nguoiGui.Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Số điện thoại người gửi: ");
            nguoiGui.SoDienThoai = Console.ReadLine();
            Console.Write("Địa chỉ gửi: ");
            nguoiGui.DiaChiGui = Console.ReadLine();

            // Nhập thông tin người nhận
            NguoiNhan nguoiNhan = new NguoiNhan("", "", 0, "");
            Console.Write("Tên người nhận: ");
            nguoiNhan.Ten = Console.ReadLine();
            Console.Write("Tuổi người nhận: ");
            nguoiNhan.Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Số điện thoại người nhận: ");
            nguoiNhan.SoDienThoai = Console.ReadLine();
            Console.Write("Địa chỉ người nhận: ");
            nguoiNhan.DiaChiNhan = Console.ReadLine();
            thu.NguoiNhann = nguoiNhan;
            
            Console.Write("Loại thư (1: Nhanh, 2: Thường): ");
            thu.LoaiThuu = Console.ReadLine() == "1" ? LoaiThu.Nhanh : LoaiThu.Thuong;
            listBuuPham.Add(thu);
        }

        private void NhapHangHoa()
        {
            HangHoa hangHoa = new HangHoa("", null, null, 0.0);
            Console.Write("Địa chỉ nhận: ");
            hangHoa.DiaChiNhan = Console.ReadLine();
            
            // Nhập thông tin người gửi
            NguoiGui nguoiGui = new NguoiGui("", "", 0, "");
            Console.Write("Tên người gửi: ");
            nguoiGui.Ten = Console.ReadLine();
            Console.Write("Tuổi người gửi: ");
            nguoiGui.Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Số điện thoại người gửi: ");
            nguoiGui.SoDienThoai = Console.ReadLine();
            Console.Write("Địa chỉ gửi: ");
            nguoiGui.DiaChiGui = Console.ReadLine();

            // Nhập thông tin người nhận
            NguoiNhan nguoiNhan = new NguoiNhan("", "", 0, "");
            Console.Write("Tên người nhận: ");
            nguoiNhan.Ten = Console.ReadLine();
            Console.Write("Tuổi người nhận: ");
            nguoiNhan.Tuoi = int.Parse(Console.ReadLine());
            Console.Write("Số điện thoại người nhận: ");
            nguoiNhan.SoDienThoai = Console.ReadLine();
            Console.Write("Địa chỉ người nhận: ");
            nguoiNhan.DiaChiNhan = Console.ReadLine();
            hangHoa.NguoiNhann = nguoiNhan;
            
            Console.Write("Trọng lượng: ");
            hangHoa.TrongLuong = double.Parse(Console.ReadLine());
            listBuuPham.Add(hangHoa);
        }

        public void NhapTuDong()
        {
            for (int i = 0; i < 2; i++)
            {
                Thu thu = new Thu("", null, null, LoaiThu.Thuong)
                {
                    DiaChiNhan = $"Địa chỉ thư {i + 1}",
                    NguoiNhann = new NguoiNhan("", "", 0, "")
                    {
                        Ten = $"Người nhận thư {i + 1}",
                        Tuoi = 20 + i,
                        SoDienThoai = $"012345678{i}",
                        DiaChiNhan = $"Địa chỉ người nhận thư {i + 1}"
                    },
                    LoaiThuu = i == 0 ? LoaiThu.Thuong : LoaiThu.Nhanh
                };
                listBuuPham.Add(thu);
            }

            for (int i = 0; i < 2; i++)
            {
                HangHoa hangHoa = new HangHoa("", null, null, 0.0)
                {
                    DiaChiNhan = $"Địa chỉ hàng hóa {i + 1}",
                    NguoiNhann = new NguoiNhan("", "", 0, "")
                    {
                        Ten = $"Người nhận hàng {i + 1}",
                        Tuoi = 25 + i,
                        SoDienThoai = $"098765432{i}",
                        DiaChiNhan = $"Địa chỉ người nhận hàng {i + 1}"
                    },
                    TrongLuong = 1.5 + i
                };
                listBuuPham.Add(hangHoa);
            }

            Console.WriteLine("\nDanh sách sau khi nhập tự động:");
            XuatDanhSach();
        }

        public int DemTongHangHoa()
        {
            return listBuuPham.Count(x => x is HangHoa);
        }

        public void XuatThuTheoTen(string tenCanTim)
        {
            var thuTimDuoc = listBuuPham.OfType<Thu>()
                .Where(thu => thu.NguoiNhann.Ten.Contains(tenCanTim, StringComparison.OrdinalIgnoreCase));

            if (thuTimDuoc.Any())
            {
                Console.WriteLine($"\nCác thư của người nhận {tenCanTim}:");
                foreach (var thu in thuTimDuoc)
                {
                    XuatThongTinThu(thu);
                }
            }
            else
            {
                Console.WriteLine($"\nKhông tìm thấy thư nào của người nhận {tenCanTim}");
            }
        }

        //public void SapXepBuuPham(List<BuuPham> listBuuPham)
        //{
        //    for (int i = 0; i < listBuuPham.Count - 1; i++)
        //    {
        //        for (int j = 0; j < listBuuPham.Count; j++)
        //        {
        //            if (string.Compare(listBuuPham[j].NguoiNhann.Ten, listBuuPham[i].NguoiNhann.Ten) > 0)
        //            {
        //                string temp = listBuuPham[j].NguoiNhann.Ten;
        //                listBuuPham[j].NguoiNhann.Ten = listBuuPham[i].NguoiNhann.Ten;
        //                listBuuPham[i].NguoiNhann.Ten = temp;
        //            }
        //        }
        //    }
        //}

        public void SapXepBuuPham()
        {
            listBuuPham.Sort((a, b) =>
            {
                int soSanhTen = a.NguoiNhann.Ten.CompareTo(b.NguoiNhann.Ten);
                if (soSanhTen == 0)
                {
                    return a.TinhPhiVanChuyen().CompareTo(b.TinhPhiVanChuyen());
                }
                return soSanhTen;
            });
        }

        public void XoaThuThuong()
        {
            listBuuPham.RemoveAll(x => x is Thu thu && thu.LoaiThuu == LoaiThu.Thuong);
        }

        public double TinhTongPhiVanChuyen()
        {
            return calculator.TinhTongChiPhiVanChuyen(listBuuPham);
        }

        private void XuatThongTinThu(Thu thu)
        {
            Console.WriteLine($"Thư - Địa chỉ: {thu.DiaChiNhan}, Người nhận: {thu.NguoiNhann.Ten} ({thu.NguoiNhann.Tuoi} tuổi), SĐT: {thu.NguoiNhann.SoDienThoai}, Địa chỉ: {thu.NguoiNhann.DiaChiNhan}, Loại: {thu.LoaiThuu}, Phí: {thu.TinhPhiVanChuyen():N0}đ");
        }

        private void XuatThongTinHangHoa(HangHoa hangHoa)
        {
            Console.WriteLine($"Hàng hóa - Địa chỉ: {hangHoa.DiaChiNhan}, Người nhận: {hangHoa.NguoiNhann.Ten} ({hangHoa.NguoiNhann.Tuoi} tuổi), SĐT: {hangHoa.NguoiNhann.SoDienThoai}, Địa chỉ: {hangHoa.NguoiNhann.DiaChiNhan}, Trọng lượng: {hangHoa.TrongLuong}kg, Phí: {hangHoa.TinhPhiVanChuyen():N0}đ");
        }

        public void XuatDanhSach()
        {
            foreach (var buuPham in listBuuPham)
            {
                if (buuPham is Thu thu)
                {
                    XuatThongTinThu(thu);
                }
                else if (buuPham is HangHoa hangHoa)
                {
                    XuatThongTinHangHoa(hangHoa);
                }
            }
        }
    }
}
