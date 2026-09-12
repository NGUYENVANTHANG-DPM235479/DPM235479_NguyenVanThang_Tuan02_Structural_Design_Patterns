using DPM235479_NguyenVanThang_Tuan02_Adapter_Read_NhanVien_DP.ExternalServices;
using DPM235479_NguyenVanThang_Tuan02_Adapter_Read_NhanVien_DP.Interfaces;

namespace DPM235479_NguyenVanThang_Tuan02_Adapter_Read_NhanVien_DP.Adapters
{
    /// <summary>
    /// Adapter cho dịch vụ thanh toán quốc tế.
    /// Giúp tích hợp InternationalPaymentService vào hệ thống sử dụng IPaymentProcessor.
    /// </summary>
    public class InternationalPaymentAdapter : IPaymentProcessor
    {
        private readonly InternationalPaymentService _internationalPaymentService;
        private readonly string _swiftCode;

        public InternationalPaymentAdapter(InternationalPaymentService internationalPaymentService, string swiftCode)
        {
            _internationalPaymentService = internationalPaymentService;
            _swiftCode = swiftCode;
        }

        public void ProcessPayment(double amount)
        {
            // Adapter dịch (chuyển đổi) phương thức từ Target sang Adaptee
            _internationalPaymentService.MakeWireTransfer(amount, _swiftCode);
        }
    }
}
