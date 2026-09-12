namespace DPM235479_NguyenVanThang_Tuan02_Flyweight_Read_NhanVien_DP.Models
{
    // Intrinsic State (Trạng thái dùng chung)
    // Các thông tin này ít khi thay đổi và giống nhau giữa các lô hàng của cùng 1 sản phẩm.
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Manufacturer { get; set; }
        public string Unit { get; set; } // Ví dụ: Chai, Lít, Kg...
    }
}
