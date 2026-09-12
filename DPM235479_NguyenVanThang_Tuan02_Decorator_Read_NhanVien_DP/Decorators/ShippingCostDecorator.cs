using DPM235479_NguyenVanThang_Tuan02_Decorator_Read_NhanVien_DP.Components;

namespace DPM235479_NguyenVanThang_Tuan02_Decorator_Read_NhanVien_DP.Decorators
{
    /// <summary>
    /// Concrete Decorator: Thêm chi phí vận chuyển vào hóa đơn.
    /// </summary>
    public class ShippingCostDecorator : InvoiceDecorator
    {
        private double _shippingCost;

        public ShippingCostDecorator(IInvoice invoice, double shippingCost) : base(invoice)
        {
            _shippingCost = shippingCost;
        }

        public override double CalculateTotal()
        {
            // Cộng thêm phí vận chuyển vào tổng tiền hiện tại
            return base.CalculateTotal() + _shippingCost;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()} \n  + Phí vận chuyển: {_shippingCost:C}";
        }
    }
}
