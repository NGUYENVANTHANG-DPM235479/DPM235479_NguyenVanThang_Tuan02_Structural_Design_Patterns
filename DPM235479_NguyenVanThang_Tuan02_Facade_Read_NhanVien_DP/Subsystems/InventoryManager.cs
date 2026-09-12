using System;

namespace DPM235479_NguyenVanThang_Tuan02_Facade_Read_NhanVien_DP.Subsystems
{
    /// <summary>
    /// Subsystem 1: Hệ thống Quản lý Tồn Kho (Xử lý cấu hình xuất nhập FIFO hoặc chỉ định)
    /// </summary>
    public class InventoryManager
    {
        public void ConfigureExportMethod(string method)
        {
            Console.WriteLine($"[InventoryManager] Đã cấu hình phương pháp xuất kho: {method}");
        }

        public void ExportProduct(string productId, int quantity)
        {
            Console.WriteLine($"[InventoryManager] Tiến hành xuất {quantity} sản phẩm có mã {productId} khỏi kho.");
        }
    }
}
