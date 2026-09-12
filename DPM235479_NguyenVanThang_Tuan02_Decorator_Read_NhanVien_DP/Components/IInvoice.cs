namespace DPM235479_NguyenVanThang_Tuan02_Decorator_Read_NhanVien_DP.Components
{
    /// <summary>
    /// Component: Giao diện cơ sở cho Hóa Đơn.
    /// Định nghĩa các thao tác tính tiền và lấy thông tin hóa đơn.
    /// </summary>
    public interface IInvoice
    {
        double CalculateTotal();
        string GetDescription();
    }
}
