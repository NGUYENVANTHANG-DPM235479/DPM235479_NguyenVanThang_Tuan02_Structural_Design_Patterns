using System;
using DPM235479_NguyenVanThang_Tuan02_Facade_Read_NhanVien_DP.Facades;

namespace DPM235479_NguyenVanThang_Tuan02_Facade_Read_NhanVien_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== HỆ THỐNG QUẢN LÝ BÁN HÀNG NÔNG DƯỢC ===");
            Console.WriteLine("Áp dụng Facade Pattern để đơn giản hóa giao diện xuất kho\n");

            // Client (UI) chỉ làm việc với Facade duy nhất, không cần biết các Subsystems bên dưới
            StoreFacade facade = new StoreFacade();

            Console.WriteLine("[Client / UI] Người dùng nhấn nút 'Xuất Kho Thuốc Trừ Sâu'");
            
            // UI chỉ cần truyền các tham số đơn giản
            string productId = "SP_THUOC_001";
            int quantity = 50;
            string exportMethod = "FIFO (Nhập trước xuất trước)";
            string pricingMethod = "Bình quân gia quyền";

            // Toàn bộ logic phức tạp được Facade xử lý ngầm bên dưới
            facade.ProcessProductExport(productId, quantity, exportMethod, pricingMethod);

            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
