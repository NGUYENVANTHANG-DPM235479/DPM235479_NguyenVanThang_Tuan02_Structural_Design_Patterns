using System;
using DPM235479_NguyenVanThang_Tuan02_Command_Read_NhanVien_DP.Interfaces;

namespace DPM235479_NguyenVanThang_Tuan02_Command_Read_NhanVien_DP.Invokers
{
    public class QueryInvoker
    {
        private ICommand _command;

        // Thiết lập lệnh cần chạy
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        // Thực thi lệnh truy vấn
        public void ExecuteQuery()
        {
            Console.WriteLine("\n[Hệ thống Log] Hệ thống nhận được yêu cầu truy vấn dữ liệu.");

            if (_command != null)
            {
                // Kích hoạt Command
                _command.Execute();

                Console.WriteLine("[Hệ thống Log] Đã ghi nhận lịch sử truy xuất thành công.");
            }
        }
    }
}