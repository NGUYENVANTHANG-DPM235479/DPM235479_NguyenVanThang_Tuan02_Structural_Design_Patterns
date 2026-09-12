using System;
using DPM235479_NguyenVanThang_Tuan02_Proxy_Read_NhanVien_DP.Subjects;
using DPM235479_NguyenVanThang_Tuan02_Proxy_Read_NhanVien_DP.RealSubjects;
using DPM235479_NguyenVanThang_Tuan02_Proxy_Read_NhanVien_DP.Proxies;

namespace DPM235479_NguyenVanThang_Tuan02_Proxy_Read_NhanVien_DP
{
    // Client gọi các tác vụ
    public class Client
    {
        public void ExecuteDeleteAction(IInventoryDatabase database, string batchId)
        {
            database.DeleteBatch(batchId);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PROXY PATTERN: QUẢN LÝ QUYỀN HỦY LÔ HÀNG NÔNG DƯỢC ===\n");

            Client client = new Client();
            RealInventoryDatabase realDatabase = new RealInventoryDatabase();

            // Nếu không dùng Proxy (Nguy hiểm - Ai cũng xóa được)
            // Console.WriteLine("--- TRƯỜNG HỢP 1: GỌI TRỰC TIẾP DATABASE (RẤT NGUY HIỂM) ---");
            // client.ExecuteDeleteAction(realDatabase, "LOHANG_001");

            // Trường hợp 2: Dùng Proxy với nhân viên thường (Thủ kho)
            Console.WriteLine("--- TRƯỜNG HỢP 1: THỦ KHO CỐ GẮNG XÓA LÔ HÀNG ---");
            InventoryDatabaseProxy thuKhoProxy = new InventoryDatabaseProxy(realDatabase, "ThuKho");
            client.ExecuteDeleteAction(thuKhoProxy, "LOHANG_001");

            // Trường hợp 3: Dùng Proxy với người quản lý
            Console.WriteLine("--- TRƯỜNG HỢP 2: QUẢN LÝ THỰC HIỆN XÓA LÔ HÀNG ---");
            InventoryDatabaseProxy quanLyProxy = new InventoryDatabaseProxy(realDatabase, "QuanLy");
            client.ExecuteDeleteAction(quanLyProxy, "LOHANG_002");
        }
    }
}
