using DPM235479_NguyenVanThang_Tuan02_Bridge_Read_NhanVien_DP.Interfaces;

namespace DPM235479_NguyenVanThang_Tuan02_Bridge_Read_NhanVien_DP.Implementations
{
    /// <summary>
    /// Concrete Implementation: Định dạng báo cáo xuất ra PDF.
    /// </summary>
    public class PdfFormat : IReportFormat
    {
        public string FormatHeader(string title)
        {
            return $"[PDF Header] --- BÁO CÁO: {title.ToUpper()} ---";
        }

        public string FormatBody(string data)
        {
            return $"[PDF Body] Dữ liệu được căn lề, chia cột: \n{data}";
        }

        public string FormatFooter()
        {
            return $"[PDF Footer] Xuất bởi Hệ thống Nông Dược - Trang 1/1";
        }
    }
}
