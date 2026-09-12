using System;
using DPM235479_NguyenVanThang_Tuan02_Proxy_Read_NhanVien_DP.Subjects;

namespace DPM235479_NguyenVanThang_Tuan02_Proxy_Read_NhanVien_DP.RealSubjects
{
    // Đối tượng thật (Real Subject) thực hiện logic cốt lõi
    // Chứa thao tác cực kỳ nhạy cảm và nguy hiểm
    public class RealInventoryDatabase : IInventoryDatabase
    {
        public void DeleteBatch(string batchId)
        {
            Console.WriteLine($"[Real Database] CẢNH BÁO: Đang xóa vĩnh viễn lô hàng '{batchId}' khỏi hệ thống cơ sở dữ liệu!");
            Console.WriteLine($"[Real Database] Đã xóa thành công lô hàng '{batchId}'.\n");
        }
    }
}
