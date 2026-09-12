using DPM235479_NguyenVanThang_Tuan02_Decorator_Read_NhanVien_DP.Components;

namespace DPM235479_NguyenVanThang_Tuan02_Decorator_Read_NhanVien_DP.Decorators
{
    /// <summary>
    /// Concrete Decorator: Thêm chi phí dịch vụ phát sinh (ví dụ: bốc xếp, tư vấn kỹ thuật nông nghiệp).
    /// </summary>
    public class AdditionalServiceDecorator : InvoiceDecorator
    {
        private double _serviceFee;
        private string _serviceName;

        public AdditionalServiceDecorator(IInvoice invoice, string serviceName, double serviceFee) : base(invoice)
        {
            _serviceName = serviceName;
            _serviceFee = serviceFee;
        }

        public override double CalculateTotal()
        {
            // Cộng thêm phí dịch vụ vào tổng
            return base.CalculateTotal() + _serviceFee;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} \n  + Dịch vụ ({_serviceName}): {_serviceFee:C}";
        }
    }
}
