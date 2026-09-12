namespace DPM235479_NguyenVanThang_Tuan02_Bridge_Read_NhanVien_DP.Interfaces
{
    /// <summary>
    /// Implementation: Giao diện định nghĩa các thao tác nguyên thủy cho các định dạng báo cáo.
    /// Nó không cần phải giống với giao diện của Abstraction.
    /// </summary>
    public interface IReportFormat
    {
        string FormatHeader(string title);
        string FormatBody(string data);
        string FormatFooter();
    }
}
