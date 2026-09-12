using System;
using DPM235479_NguyenVanThang_Tuan02_Bridge_Read_NhanVien_DP.Interfaces;

namespace DPM235479_NguyenVanThang_Tuan02_Bridge_Read_NhanVien_DP.Abstractions
{
    /// <summary>
    /// Abstraction: Lớp cơ sở định nghĩa phần "điều khiển" của báo cáo.
    /// Nó duy trì một tham chiếu đến một đối tượng Implementation (IReportFormat) và
    /// ủy quyền việc định dạng thực sự cho đối tượng này.
    /// </summary>
    public abstract class Report
    {
        protected IReportFormat _reportFormat;

        public Report(IReportFormat reportFormat)
        {
            _reportFormat = reportFormat;
        }

        // Thay đổi định dạng báo cáo (Bridge) trong thời gian chạy (Runtime)
        public void SetFormat(IReportFormat reportFormat)
        {
            _reportFormat = reportFormat;
        }

        public virtual void Generate()
        {
            Console.WriteLine("Đang tạo báo cáo cơ bản...");
        }
    }
}
