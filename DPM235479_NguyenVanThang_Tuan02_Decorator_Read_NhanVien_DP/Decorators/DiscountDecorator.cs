using DPM235479_NguyenVanThang_Tuan02_Decorator_Read_NhanVien_DP.Components;

namespace DPM235479_NguyenVanThang_Tuan02_Decorator_Read_NhanVien_DP.Decorators
{
    /// <summary>
    /// Concrete Decorator: Giảm giá/Chiết khấu trên hóa đơn.
    /// </summary>
    public class DiscountDecorator : InvoiceDecorator
    {
        private double _discountPercentage; // Ví dụ: 0.1 = 10%

        public DiscountDecorator(IInvoice invoice, double discountPercentage) : base(invoice)
        {
            _discountPercentage = discountPercentage;
        }

        public override double CalculateTotal()
        {
            // Trừ đi % giảm giá
            double currentTotal = base.CalculateTotal();
            return currentTotal - (currentTotal * _discountPercentage);
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} \n  - Chiết khấu/Giảm giá: {_discountPercentage * 100}%";
        }
    }
}
