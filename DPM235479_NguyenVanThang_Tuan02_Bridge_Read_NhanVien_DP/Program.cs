using System;
using DPM235479_NguyenVanThang_Tuan02_Bridge_Read_NhanVien_DP.Abstractions;
using DPM235479_NguyenVanThang_Tuan02_Bridge_Read_NhanVien_DP.Implementations;
using DPM235479_NguyenVanThang_Tuan02_Bridge_Read_NhanVien_DP.Interfaces;

namespace DPM235479_NguyenVanThang_Tuan02_Bridge_Read_NhanVien_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== HỆ THỐNG QUẢN LÝ BÁN HÀNG NÔNG DƯỢC ===");
            Console.WriteLine("Áp dụng Bridge Pattern cho Chức năng Báo Cáo / Thống Kê\n");

            // Khởi tạo các định dạng báo cáo (Implementations)
            IReportFormat pdfFormat = new PdfFormat();
            IReportFormat excelFormat = new ExcelFormat();

            // --- BÁO CÁO TỒN KHO ---
            // Tách biệt loại báo cáo (Abstraction) với định dạng (Implementation)
            Report inventoryReport = new InventoryReport(pdfFormat);
            
            // Khách hàng muốn xuất PDF
            inventoryReport.Generate();

            // Khách hàng thay đổi ý định, muốn xuất Excel trên cùng một đối tượng báo cáo
            Console.WriteLine("\n[Hệ thống] Chuyển đổi định dạng sang Excel...");
            inventoryReport.SetFormat(excelFormat);
            inventoryReport.Generate();

            Console.WriteLine(new string('-', 50));

            // --- BÁO CÁO DOANH THU ---
            // Báo cáo doanh thu xuất mặc định ra Excel
            Report salesReport = new SalesReport(excelFormat);
            salesReport.Generate();

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
