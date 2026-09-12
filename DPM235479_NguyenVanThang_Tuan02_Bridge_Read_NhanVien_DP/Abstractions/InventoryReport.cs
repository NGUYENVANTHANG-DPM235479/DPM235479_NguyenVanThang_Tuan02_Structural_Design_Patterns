using System;
using DPM235479_NguyenVanThang_Tuan02_Bridge_Read_NhanVien_DP.Interfaces;

namespace DPM235479_NguyenVanThang_Tuan02_Bridge_Read_NhanVien_DP.Abstractions
{
    /// <summary>
    /// Refined Abstraction: Báo cáo tồn kho hàng hóa nông dược.
    /// Kế thừa từ Abstraction và mở rộng chi tiết cụ thể cho báo cáo tồn kho.
    /// </summary>
    public class InventoryReport : Report
    {
        public InventoryReport(IReportFormat reportFormat) : base(reportFormat)
        {
        }

        public override void Generate()
        {
            Console.WriteLine("\n--- TIẾN HÀNH XUẤT BÁO CÁO TỒN KHO ---");
            Console.WriteLine(_reportFormat.FormatHeader("Báo Cáo Tồn Kho Nông Dược"));
            Console.WriteLine(_reportFormat.FormatBody("- Thuốc trừ sâu X: 150 chai\n- Phân bón Y: 200 bao\n- Hạt giống Z: 50 gói"));
            Console.WriteLine(_reportFormat.FormatFooter());
        }
    }
}
