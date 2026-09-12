using System;
using DPM235479_NguyenVanThang_Tuan02_Decorator_Read_NhanVien_DP.Components;
using DPM235479_NguyenVanThang_Tuan02_Decorator_Read_NhanVien_DP.Decorators;

namespace DPM235479_NguyenVanThang_Tuan02_Decorator_Read_NhanVien_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== HỆ THỐNG QUẢN LÝ BÁN HÀNG NÔNG DƯỢC ===");
            Console.WriteLine("Áp dụng Decorator Pattern cho việc tính tổng Hóa đơn\n");

            // 1. Tạo hóa đơn cơ bản (Ví dụ: khách mua lượng hàng trị giá 1,000,000)
            IInvoice myInvoice = new BasicInvoice(1000000);
            
            Console.WriteLine("--- HÓA ĐƠN GỐC ---");
            PrintInvoice(myInvoice);

            // 2. Thêm phụ phí vận chuyển (Ví dụ 50,000) bằng Decorator
            myInvoice = new ShippingCostDecorator(myInvoice, 50000);
            
            Console.WriteLine("\n--- HÓA ĐƠN ĐÃ CỘNG PHÍ VẬN CHUYỂN ---");
            PrintInvoice(myInvoice);

            // 3. Khách hàng thuê thêm dịch vụ bốc vác (Ví dụ 100,000)
            myInvoice = new AdditionalServiceDecorator(myInvoice, "Bốc xếp hàng hóa lên xe tải", 100000);

            Console.WriteLine("\n--- HÓA ĐƠN KÈM DỊCH VỤ PHÁT SINH ---");
            PrintInvoice(myInvoice);

            // 4. Giảm giá 10% (Chạy đợt khuyến mãi)
            myInvoice = new DiscountDecorator(myInvoice, 0.10);

            Console.WriteLine("\n--- HÓA ĐƠN CUỐI CÙNG SAU KHI ÁP DỤNG MỌI DECORATOR ---");
            PrintInvoice(myInvoice);

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }

        // Client Code: Chỉ cần làm việc thông qua interface IInvoice
        static void PrintInvoice(IInvoice invoice)
        {
            Console.WriteLine(invoice.GetDescription());
            Console.WriteLine($"=> TỔNG TIỀN PHẢI THANH TOÁN: {invoice.CalculateTotal():C}");
        }
    }
}
