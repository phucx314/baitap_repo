using System.Text;

namespace CongTyABC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            
            IQuanLyNhanSu quanLyNhanSu = new QuanLyNhanSu();
            Menu chuongTrinh = new Menu(quanLyNhanSu);

            chuongTrinh.HienThiMenu();

            Console.WriteLine("\nNhấn phím bất kỳ để thoát");
            Console.ReadKey();
        }
    }
}
