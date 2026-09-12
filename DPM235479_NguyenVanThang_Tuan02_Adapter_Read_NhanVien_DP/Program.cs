using System;
using DPM235479_NguyenVanThang_Tuan02_Adapter_Read_NhanVien_DP.Adapters;
using DPM235479_NguyenVanThang_Tuan02_Adapter_Read_NhanVien_DP.ExternalServices;
using DPM235479_NguyenVanThang_Tuan02_Adapter_Read_NhanVien_DP.Interfaces;

namespace DPM235479_NguyenVanThang_Tuan02_Adapter_Read_NhanVien_DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hỗ trợ hiển thị tiếng Việt có dấu trên Console
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Console.WriteLine("=== HỆ THỐNG QUẢN LÝ BÁN HÀNG NÔNG DƯỢC ===");
            Console.WriteLine("Áp dụng Adapter Pattern cho các phương thức thanh toán\n");

            double amountToPay = 1500.50;

            // --- 1. Thanh toán quốc tế (Dịch vụ bên thứ 3) ---
            // Khởi tạo dịch vụ bên thứ 3 (Adaptee)
            InternationalPaymentService internationalService = new InternationalPaymentService();
            
            // Sử dụng Adapter để làm cho Adaptee tương thích với IPaymentProcessor (Target)
            IPaymentProcessor internationalAdapter = new InternationalPaymentAdapter(internationalService, "AGRI_VN_123");
            
            Console.WriteLine("--> Yêu cầu thanh toán quốc tế:");
            ProcessClientPayment(internationalAdapter, amountToPay);
            Console.WriteLine(new string('-', 50));


            // --- 2. Thanh toán trực tuyến (Ví điện tử) ---
            // Khởi tạo dịch vụ ví điện tử (Adaptee)
            OnlinePaymentService onlineService = new OnlinePaymentService();
            
            // Sử dụng Adapter tương ứng
            IPaymentProcessor onlineAdapter = new OnlinePaymentAdapter(onlineService, "ACC_888999");
            
            Console.WriteLine("--> Yêu cầu thanh toán trực tuyến qua E-Wallet:");
            ProcessClientPayment(onlineAdapter, amountToPay);
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }

        /// <summary>
        /// Client code: Chỉ cần làm việc với giao diện chuẩn (Target: IPaymentProcessor)
        /// Không cần biết chi tiết về các dịch vụ bên dưới.
        /// </summary>
        static void ProcessClientPayment(IPaymentProcessor paymentProcessor, double amount)
        {
            paymentProcessor.ProcessPayment(amount);
            Console.WriteLine("    [Hệ thống nội bộ] Thanh toán đã được xử lý và ghi nhận thành công.");
        }
    }
}
