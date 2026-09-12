using System;

namespace DPM235479_NguyenVanThang_Tuan02_Adapter_Read_NhanVien_DP.ExternalServices
{
    /// <summary>
    /// Adaptee 1: Dịch vụ thanh toán quốc tế từ bên thứ 3.
    /// Giao diện này không tương thích với IPaymentProcessor của hệ thống bán hàng.
    /// </summary>
    public class InternationalPaymentService
    {
        public void MakeWireTransfer(double amountInUSD, string swiftCode)
        {
            Console.WriteLine($"[Third-party] Đang xử lý chuyển khoản quốc tế: ${amountInUSD} đến mã SWIFT: {swiftCode}");
        }
    }
}
