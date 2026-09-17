using System;
using DPM235479_NguyenVanThang_Tuan02_Command_Read_NhanVien_DP.Commands;
using DPM235479_NguyenVanThang_Tuan02_Command_Read_NhanVien_DP.Interfaces;
using DPM235479_NguyenVanThang_Tuan02_Command_Read_NhanVien_DP.Invokers;
using DPM235479_NguyenVanThang_Tuan02_Command_Read_NhanVien_DP.Receivers;

namespace DPM235479_NguyenVanThang_Tuan02_Command_Read_NhanVien_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hỗ trợ hiển thị tiếng Việt có dấu trên Console
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHỨC NĂNG ĐỌC THÔNG TIN NHÂN VIÊN (COMMAND PATTERN) ===");

            // 1. Khởi tạo đối tượng xử lý CSDL (Receiver)
            NhanVienReadReceiver dbReceiver = new NhanVienReadReceiver();

            // 2. Khởi tạo bộ điều khiển trung tâm (Invoker)
            QueryInvoker appInvoker = new QueryInvoker();

            // --- KỊCH BẢN 1: Đọc nhân viên ID = 1 ---
            ICommand docNV1 = new ReadNhanVienCommand(dbReceiver, 1);
            appInvoker.SetCommand(docNV1);
            appInvoker.ExecuteQuery();

            // --- KỊCH BẢN 2: Đọc nhân viên ID = 99 (Không tồn tại) ---
            ICommand docNV99 = new ReadNhanVienCommand(dbReceiver, 99);
            appInvoker.SetCommand(docNV99);
            appInvoker.ExecuteQuery();

            Console.ReadLine();
        }
    }
}