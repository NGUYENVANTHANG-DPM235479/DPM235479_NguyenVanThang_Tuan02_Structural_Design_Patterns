using DPM235479_NguyenVanThang_Tuan02_Decorator_Read_NhanVien_DP.Components;

namespace DPM235479_NguyenVanThang_Tuan02_Decorator_Read_NhanVien_DP.Decorators
{
    /// <summary>
    /// Base Decorator: Lớp trang trí cơ sở, tuân thủ theo giao diện IInvoice.
    /// Nó giữ một tham chiếu đến một đối tượng IInvoice và ủy quyền tính toán cho đối tượng đó.
    /// </summary>
    public abstract class InvoiceDecorator : IInvoice
    {
        protected IInvoice _invoice;

        public InvoiceDecorator(IInvoice invoice)
        {
            _invoice = invoice;
        }

        public virtual double CalculateTotal()
        {
            if (_invoice != null)
                return _invoice.CalculateTotal();
            return 0;
        }

        public virtual string GetDescription()
        {
            if (_invoice != null)
                return _invoice.GetDescription();
            return string.Empty;
        }
    }
}
