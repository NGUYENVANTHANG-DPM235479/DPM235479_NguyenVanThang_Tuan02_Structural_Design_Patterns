using System;
using DPM235479_NguyenVanThang_Tuan02_Facade_Read_NhanVien_DP.Subsystems;

namespace DPM235479_NguyenVanThang_Tuan02_Facade_Read_NhanVien_DP.Facades
{
    /// <summary>
    /// Facade: Lớp Mặt tiền cung cấp một giao diện đơn giản (shortcut) để tương tác 
    /// với các hệ thống Tồn kho, Phân lô và Tính giá phức tạp bên dưới.
    /// Giấu sự phức tạp này khỏi lớp Giao diện người dùng (UI).
    /// </summary>
    public class StoreFacade
    {
        protected InventoryManager _inventoryManager;
        protected BatchManager _batchManager;
        protected PricingCalculator _pricingCalculator;

        public StoreFacade()
        {
            // Facade tự quản lý vòng đời của các hệ thống con
            _inventoryManager = new InventoryManager();
            _batchManager = new BatchManager();
            _pricingCalculator = new PricingCalculator();
        }

        /// <summary>
        /// Hàm giao tiếp duy nhất mà UI (Client) cần gọi để hoàn tất một quy trình phức tạp.
        /// </summary>
        public void ProcessProductExport(string productId, int quantity, string exportMethod, string pricingMethod)
        {
            Console.WriteLine("\n=== [FACADE] BẮT ĐẦU QUY TRÌNH XUẤT KHO NÔNG DƯỢC ===");
            
            // 1. Cấu hình hệ thống xuất nhập
            _inventoryManager.ConfigureExportMethod(exportMethod);
            _pricingCalculator.ConfigurePricingMethod(pricingMethod);

            // 2. Tìm lô hàng phù hợp nhất (dựa trên hạn sử dụng / FIFO)
            _batchManager.FindBatchesByExpirationDate(productId);
            string optimalBatch = _batchManager.GetOptimalBatch();

            // 3. Tính giá trị đơn hàng
            double totalPrice = _pricingCalculator.CalculatePrice(optimalBatch, quantity);

            // 4. Tiến hành xuất kho
            _inventoryManager.ExportProduct(productId, quantity);

            Console.WriteLine($"=== [FACADE] XUẤT KHO THÀNH CÔNG! TỔNG TIỀN: {totalPrice:C} ===\n");
        }
    }
}
