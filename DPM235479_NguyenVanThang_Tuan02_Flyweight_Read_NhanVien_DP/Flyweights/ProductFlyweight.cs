using System;
using System.Text.Json;
using DPM235479_NguyenVanThang_Tuan02_Flyweight_Read_NhanVien_DP.Models;

namespace DPM235479_NguyenVanThang_Tuan02_Flyweight_Read_NhanVien_DP.Flyweights
{
    // Lớp Flyweight chứa trạng thái chung (Intrinsic)
    // Cung cấp phương thức để kết hợp với trạng thái riêng (Extrinsic) để thực thi nghiệp vụ
    public class ProductFlyweight
    {
        private readonly Product _sharedState;

        public ProductFlyweight(Product product)
        {
            _sharedState = product;
        }

        // Thực hiện nghiệp vụ (như hiển thị thông tin lô hàng) bằng cách nhận vào Extrinsic state
        public void DisplayBatchInfo(BatchData uniqueState)
        {
            string productInfo = JsonSerializer.Serialize(_sharedState);
            string batchInfo = JsonSerializer.Serialize(uniqueState);

            // Rút gọn JSON string để dễ nhìn trong console
            Console.WriteLine($"[Flyweight] Sản phẩm: {productInfo} \n=> Dữ liệu Lô Hàng (Extrinsic): {batchInfo}\n");
        }

        public Product GetSharedState()
        {
            return _sharedState;
        }
    }
}
