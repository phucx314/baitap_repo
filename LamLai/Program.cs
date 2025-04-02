namespace LamLai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            PostOffice postOffice = new PostOffice();
            postOffice.NhapTuDong();

            while (true)
            {
                Console.WriteLine("\n===== QUẢN LÝ BƯU PHẨM =====");
                Console.WriteLine("1. Nhập xuất thông tin các loại bưu phẩm");
                Console.WriteLine("2. Đếm tổng số hàng hóa");
                Console.WriteLine("3. Xuất Thông tin tất cả các thư liên quan đến người nhận tên X");
                Console.WriteLine("4. Sắp xếp các bưu phẩm theo thứ tự tăng tên người nhận.\n   Nếu tên người nhận trùng nhau thì sắp xếp theo phí vận chuyển");
                Console.WriteLine("5. Xóa các thông tin về thư thường");
                Console.WriteLine("6. Tính tổng phí vận chuyển các loại bưu phẩm");
                Console.WriteLine("7. In toàn bộ danh sách bưu phẩm");
                Console.WriteLine("0. Thoát chương trình");
                Console.Write("\nChọn chức năng (0-7): ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Chỉ nhập số từ 0-7");
                    continue;
                }

                Console.WriteLine();

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Đã thoát chương trình");
                        return;

                    case 1:
                        postOffice.NhapBuuPham();
                        break;

                    case 2:
                        int tongHangHoa = postOffice.DemTongHangHoa();
                        Console.WriteLine($"Tổng số hàng hóa: {tongHangHoa}");
                        break;

                    case 3:
                        Console.Write("Nhập tên người nhận cần tìm: ");
                        string tenCanTim = Console.ReadLine();
                        postOffice.XuatThuTheoTen(tenCanTim);
                        break;

                    case 4:
                        postOffice.SapXepBuuPham();
                        Console.WriteLine("Danh sách sau khi sắp xếp:");
                        postOffice.XuatDanhSach();
                        break;

                    case 5:
                        postOffice.XoaThuThuong();
                        Console.WriteLine("Danh sách sau khi xóa thư thường:");
                        postOffice.XuatDanhSach();
                        break;

                    case 6:
                        double tongChiPhi = postOffice.TinhTongPhiVanChuyen();
                        Console.WriteLine($"Tổng chi phí vận chuyển: {tongChiPhi:N0}đ");
                        break;

                    case 7:
                        Console.WriteLine("Danh sách bưu phẩm:");
                        postOffice.XuatDanhSach();
                        break;

                    default:
                        Console.WriteLine("Vui lòng chọn chức năng từ 0-7!");
                        break;
                }

                Console.WriteLine("\nNhấn Enter để tiếp tục...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
