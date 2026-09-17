using DPM235479_NguyenVanThang_Tuan02_Template_Method_Read_NhanVien_DP.Abstractions;
using DPM235479_NguyenVanThang_Tuan02_Template_Method_Read_NhanVien_DP.ConcreteClasses;

namespace DPM235479_NguyenVanThang_Tuan02_Template_Method_Read_NhanVien_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== HỆ THỐNG QUẢN LÝ XUẤT KHO NÔNG DƯỢC (TEMPLATE METHOD PATTERN) ===");

            // 1. Xuất kho một loại phân bón thông thường
            Console.WriteLine("\n--- TÌNH HUỐNG 1: Xuất kho Phân bón thường ---");
            Client.ThucThiQuyTrinh(new XuatKhoThuocThuong(), "Phân bón lá NPK", 50);

            // 2. Xuất kho loại thuốc trừ sâu độc hại (Cần kiểm tra giấy phép pháp lý khắt khe)
            Console.WriteLine("\n--- TÌNH HUỐNG 2: Xuất kho Thuốc trừ sâu độc hại ---");
            Client.ThucThiQuvTrinhThayThe(new XuatKhoThuocDocHai(), "Thuốc trừ sâu Siêu Độc A1", 10);

            Console.ReadLine();
        }
    }

    // Mở rộng nhỏ helper cho Program gọi trực tiếp client
    public static class ExtensionHelper
    {
        public static void ThucThiQuvTrinhThayThe(QuyTrinhXuatKho quyTrinh, string sp, int sl)
        {
            Client.ThucThiQuyTrinh(quyTrinh, sp, sl);
        }
    }
}
