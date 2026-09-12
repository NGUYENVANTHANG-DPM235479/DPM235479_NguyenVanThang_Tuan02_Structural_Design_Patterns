using System;

namespace DPM235479_NguyenVanThang_Tuan02_Facade_Read_NhanVien_DP.Subsystems
{
    /// <summary>
    /// Subsystem 2: Hệ thống Phân Lô và Quản lý Hạn Sử Dụng
    /// </summary>
    public class BatchManager
    {
        public void FindBatchesByExpirationDate(string productId)
        {
            Console.WriteLine($"[BatchManager] Đang tự động tìm kiếm và phân lô sản phẩm {productId} theo ngày hết hạn gần nhất...");
        }

        public string GetOptimalBatch()
        {
            return "Lô hàng Nông Dược #BATCH_999 (Sắp hết hạn, cần xuất trước)";
        }
    }
}
