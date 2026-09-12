using System;

namespace DPM235479_NguyenVanThang_Tuan02_Facade_Read_NhanVien_DP.Subsystems
{
    /// <summary>
    /// Subsystem 3: Hệ thống tính giá (Giá xuất được tính theo Bình quân gia quyền hoặc FIFO)
    /// </summary>
    public class PricingCalculator
    {
        public void ConfigurePricingMethod(string method)
        {
            Console.WriteLine($"[PricingCalculator] Đã cấu hình phương pháp tính giá xuất kho: {method}");
        }

        public double CalculatePrice(string batchId, int quantity)
        {
            Console.WriteLine($"[PricingCalculator] Đang tính giá xuất cho {quantity} sản phẩm từ lô {batchId}...");
            return quantity * 150000; // Giả sử giá xuất là 150k/sp
        }
    }
}
