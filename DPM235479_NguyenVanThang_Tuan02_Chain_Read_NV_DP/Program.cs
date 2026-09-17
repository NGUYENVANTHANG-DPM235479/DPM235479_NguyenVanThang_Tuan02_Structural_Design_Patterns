using DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Clients;
using DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Implementations;
using DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Models;

namespace DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // 1. Khởi tạo các mắt xích (Handlers)
            var validator = new ValidationHandler();
            var authorizer = new AuthorizationHandler();
            var dataReader = new DataReadHandler();

            // 2. Liên kết các mắt xích thành một chuỗi (Chain)
            // Luồng: Validation -> Authorization -> Đọc Data
            validator.SetNext(authorizer).SetNext(dataReader);

            Console.WriteLine("=== HỆ THỐNG XỬ LÝ YÊU CẦU ĐỌC THÔNG TIN NHÂN VIÊN ===");

            // 3. Chạy các kịch bản test
            // Kịch bản 1: Lỗi Validation (ID < 0)
            var request1 = new RequestContext { NhanVienId = -5, UserRole = "Admin" };
            NhanVienClient.ExecuteReadProcess(validator, request1);

            // Kịch bản 2: Lỗi Phân quyền (Staff không được xem)
            var request2 = new RequestContext { NhanVienId = 101, UserRole = "Staff" };
            NhanVienClient.ExecuteReadProcess(validator, request2);

            // Kịch bản 3: Hợp lệ toàn bộ chuỗi
            var request3 = new RequestContext { NhanVienId = 102, UserRole = "Manager" };
            NhanVienClient.ExecuteReadProcess(validator, request3);

            Console.ReadLine();
        }
    }
}
