namespace DPM235479_NguyenVanThang_Tuan02_Decorator_Read_NhanVien_DP.Components
{
    /// <summary>
    /// Concrete Component: Hóa đơn cơ bản ban đầu (chưa có phụ phí hay giảm giá).
    /// </summary>
    public class BasicInvoice : IInvoice
    {
        private double _baseAmount;

        public BasicInvoice(double baseAmount)
        {
            _baseAmount = baseAmount;
        }

        public double CalculateTotal()
        {
            return _baseAmount;
        }

        public string GetDescription()
        {
            return $"Hóa đơn bán hàng nông dược (Cơ bản) - Giá trị: {_baseAmount:C}";
        }
    }
}
