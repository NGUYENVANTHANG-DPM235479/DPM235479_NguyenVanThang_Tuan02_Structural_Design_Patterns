using System;
using System.Collections.Generic;
using System.Linq;
using DPM235479_NguyenVanThang_Tuan02_Command_Read_NhanVien_DP.Models;

namespace DPM235479_NguyenVanThang_Tuan02_Command_Read_NhanVien_DP.Receivers
{
    public class NhanVienReadReceiver
    {
        // Mô phỏng cơ sở dữ liệu (Database Access) chứa danh sách nhân viên
        private List<NhanVien> _database = new List<NhanVien>
        {
            new NhanVien { MaNV = 1, HoTen = "Nguyễn Văn Thắng", ChucVu = "Nhân viên bán hàng" },
            new NhanVien { MaNV = 2, HoTen = "Trần Thị B", ChucVu = "Quản lý cửa hàng" }
        };

        // Logic thực sự của việc Đọc thông tin
        public void DocThongTinNhanVien(int maNV)
        {
            Console.WriteLine($"[Database Access] Đang truy vấn CSDL cho Nhân viên ID = {maNV}...");

            var nv = _database.FirstOrDefault(n => n.MaNV == maNV);
            if (nv != null)
            {
                Console.WriteLine($"   => Dữ liệu trả về: [ID: {nv.MaNV}] - {nv.HoTen} - {nv.ChucVu}");
            }
            else
            {
                Console.WriteLine($"   => Lỗi: Không tìm thấy nhân viên với ID = {maNV} trong hệ thống.");
            }
        }
    }
}