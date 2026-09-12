using System;
using DPM235479_NguyenVanThang_Tuan02_Flyweight_Read_NhanVien_DP.Models;
using DPM235479_NguyenVanThang_Tuan02_Flyweight_Read_NhanVien_DP.Flyweights;

namespace DPM235479_NguyenVanThang_Tuan02_Flyweight_Read_NhanVien_DP.Contexts
{
    // Lớp ngữ cảnh chứa trạng thái Extrinsic (Lô hàng)
    // Và tham chiếu tới trạng thái Intrinsic (Flyweight Sản phẩm)
    public class BatchContext
    {
        private readonly ProductFlyweight _flyweight;
        private readonly BatchData _batchData;

        public BatchContext(ProductFlyweight flyweight, BatchData batchData)
        {
            _flyweight = flyweight;
            _batchData = batchData;
        }

        // Gọi hàm của Flyweight để xử lý dựa trên dữ liệu hiện tại
        public void DisplayInfo()
        {
            _flyweight.DisplayBatchInfo(_batchData);
        }
    }
}
