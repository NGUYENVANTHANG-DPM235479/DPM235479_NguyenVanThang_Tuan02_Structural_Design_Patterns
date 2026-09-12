using DPM235479_NguyenVanThang_Tuan02_Adapter_Read_NhanVien_DP.ExternalServices;
using DPM235479_NguyenVanThang_Tuan02_Adapter_Read_NhanVien_DP.Interfaces;

namespace DPM235479_NguyenVanThang_Tuan02_Adapter_Read_NhanVien_DP.Adapters
{
    /// <summary>
    /// Adapter cho dịch vụ thanh toán qua ví điện tử trực tuyến.
    /// Giúp tích hợp OnlinePaymentService vào hệ thống sử dụng IPaymentProcessor.
    /// </summary>
    public class OnlinePaymentAdapter : IPaymentProcessor
    {
        private readonly OnlinePaymentService _onlinePaymentService;
        private readonly string _accountId;

        public OnlinePaymentAdapter(OnlinePaymentService onlinePaymentService, string accountId)
        {
            _onlinePaymentService = onlinePaymentService;
            _accountId = accountId;
        }

        public void ProcessPayment(double amount)
        {
            // Adapter dịch (chuyển đổi) phương thức từ Target sang Adaptee
            _onlinePaymentService.PayViaEWallet(_accountId, amount);
        }
    }
}
