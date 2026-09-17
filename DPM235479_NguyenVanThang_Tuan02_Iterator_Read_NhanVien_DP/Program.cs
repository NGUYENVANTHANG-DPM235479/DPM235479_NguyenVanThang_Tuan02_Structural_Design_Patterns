using System;
using DPM235479_NguyenVanThang_Tuan02_Iterator_Read_NhanVien_DP.Collections;
using DPM235479_NguyenVanThang_Tuan02_Iterator_Read_NhanVien_DP.Models;

namespace DPM235479_NguyenVanThang_Tuan02_Iterator_Read_NhanVien_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== HỆ THỐNG ĐỌC VÀ DUYỆT DANH SÁCH NHÂN VIÊN ===");

            // 1. Tạo bộ sưu tập (Collection) danh sách nhân viên
            var nhanVienCollection = new NhanVienCollection();

            // 2. Thêm dữ liệu (Mô phỏng lấy từ CSDL Access)
            nhanVienCollection.AddItem(new NhanVien { MaNV = "NV01", HoTen = "Nguyễn Văn Thắng", ChucVu = "Nhân viên Bán hàng" });
            nhanVienCollection.AddItem(new NhanVien { MaNV = "NV02", HoTen = "Trần Thị B", ChucVu = "Nhân viên Bán hàng" });
            nhanVienCollection.AddItem(new NhanVien { MaNV = "NV03", HoTen = "Lê Văn C", ChucVu = "Quản lý kho" });

            // 3. Duyệt danh sách từ đầu đến cuối (Straight traversal)
            Console.WriteLine("\n--- Danh sách Nhân viên (Từ cũ đến mới) ---");
            foreach (var nv in nhanVienCollection)
            {
                Console.WriteLine(nv.ToString());
            }

            // 4. Duyệt danh sách đảo ngược (Reverse traversal)
            Console.WriteLine("\n--- Danh sách Nhân viên (Từ mới đến cũ) ---");
            nhanVienCollection.ReverseDirection();
            foreach (var nv in nhanVienCollection)
            {
                Console.WriteLine(nv.ToString());
            }

            Console.ReadLine();
        }
    }
}