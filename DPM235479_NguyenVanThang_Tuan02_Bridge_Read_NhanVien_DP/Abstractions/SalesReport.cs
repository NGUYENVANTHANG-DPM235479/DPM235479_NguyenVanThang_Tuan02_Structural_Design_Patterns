using System;
using DPM235479_NguyenVanThang_Tuan02_Bridge_Read_NhanVien_DP.Interfaces;

namespace DPM235479_NguyenVanThang_Tuan02_Bridge_Read_NhanVien_DP.Abstractions
{
    /// <summary>
    /// Refined Abstraction: Báo cáo doanh thu bán hàng.
    /// Kế thừa từ Abstraction và mở rộng chi tiết cụ thể cho báo cáo bán hàng.
    /// </summary>
    public class SalesReport : Report
    {
        public SalesReport(IReportFormat reportFormat) : base(reportFormat)
        {
        }

        public override void Generate()
        {
            Console.WriteLine("\n--- TIẾN HÀNH XUẤT BÁO CÁO DOANH THU ---");
            Console.WriteLine(_reportFormat.FormatHeader("Báo Cáo Doanh Thu Bán Hàng"));
            Console.WriteLine(_reportFormat.FormatBody("- Tổng doanh thu: 150,000,000 VND\n- Chiết khấu đã cấp: 5,000,000 VND\n- Lợi nhuận ròng: 145,000,000 VND"));
            Console.WriteLine(_reportFormat.FormatFooter());
        }
    }
}
