using System;

namespace DPM235479_NguyenVanThang_Tuan02_Adapter_Read_NhanVien_DP.ExternalServices
{
    /// <summary>
    /// Adaptee 2: Dịch vụ thanh toán trực tuyến qua ví điện tử (Ví dụ: Momo, VNPay).
    /// Giao diện này cũng không tương thích với hệ thống bán hàng hiện tại.
    /// </summary>
    public class OnlinePaymentService
    {
        public void PayViaEWallet(string accountId, double amount)
        {
            Console.WriteLine($"[E-Wallet] Đang xử lý thanh toán ví điện tử cho tài khoản {accountId} với số tiền: ${amount}");
        }
    }
}
