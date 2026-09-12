using DPM235479_NguyenVanThang_Tuan02_Bridge_Read_NhanVien_DP.Interfaces;

namespace DPM235479_NguyenVanThang_Tuan02_Bridge_Read_NhanVien_DP.Implementations
{
    /// <summary>
    /// Concrete Implementation: Định dạng báo cáo xuất ra Excel.
    /// </summary>
    public class ExcelFormat : IReportFormat
    {
        public string FormatHeader(string title)
        {
            return $"[Excel Sheet 1] | TITLE: {title} |";
        }

        public string FormatBody(string data)
        {
            return $"[Excel Cells] | Dữ liệu dạng bảng lưới: | \n{data}";
        }

        public string FormatFooter()
        {
            return $"[Excel Footer] | Tự động tính toán tổng số | End of Sheet |";
        }
    }
}
