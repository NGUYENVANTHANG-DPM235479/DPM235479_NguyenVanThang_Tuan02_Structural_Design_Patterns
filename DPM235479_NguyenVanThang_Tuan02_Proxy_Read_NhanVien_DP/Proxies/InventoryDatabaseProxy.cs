using System;
using DPM235479_NguyenVanThang_Tuan02_Proxy_Read_NhanVien_DP.Subjects;
using DPM235479_NguyenVanThang_Tuan02_Proxy_Read_NhanVien_DP.RealSubjects;

namespace DPM235479_NguyenVanThang_Tuan02_Proxy_Read_NhanVien_DP.Proxies
{
    // Proxy (Người bảo vệ)
    // Cùng interface với RealSubject. Đứng ra nhận request thay cho RealSubject.
    public class InventoryDatabaseProxy : IInventoryDatabase
    {
        private RealInventoryDatabase _realDatabase;
        private string _currentUserRole;

        public InventoryDatabaseProxy(RealInventoryDatabase realDatabase, string role)
        {
            this._realDatabase = realDatabase;
            this._currentUserRole = role;
        }

        public void DeleteBatch(string batchId)
        {
            // Kiểm tra quyền (Protection Proxy)
            if (this.CheckAccess())
            {
                // Truyền request cho đối tượng thật
                this._realDatabase.DeleteBatch(batchId);
                
                // Ghi Log hệ thống (Logging Proxy)
                this.LogAccess(batchId);
            }
            else
            {
                Console.WriteLine($"[Proxy] TỪ CHỐI TRUY CẬP: Chức vụ '{_currentUserRole}' không có quyền xóa lô hàng!\n");
            }
        }

        private bool CheckAccess()
        {
            Console.WriteLine("[Proxy] Đang kiểm tra quyền hạn của người dùng...");
            return _currentUserRole == "QuanLy" || _currentUserRole == "GiamDoc";
        }

        private void LogAccess(string batchId)
        {
            Console.WriteLine($"[Proxy Log] {DateTime.Now}: Tài khoản quyền '{_currentUserRole}' đã thực hiện xóa lô hàng '{batchId}'.\n");
        }
    }
}
