using System;

namespace DPM235479_NguyenVanThang_Tuan02_Flyweight_Read_NhanVien_DP.Models
{
    // Extrinsic State (Trạng thái không chia sẻ)
    // Dữ liệu này chỉ thuộc về 1 lô hàng cụ thể.
    public class BatchData
    {
        public string BatchId { get; set; }
        public DateTime ImportDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }
    }
}
