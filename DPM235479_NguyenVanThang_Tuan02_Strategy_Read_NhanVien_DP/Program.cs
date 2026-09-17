using DPM235479_NguyenVanThang_Tuan02_Strategy_Read_NhanVien_DP.Contexts;
using DPM235479_NguyenVanThang_Tuan02_Strategy_Read_NhanVien_DP.Models;
using DPM235479_NguyenVanThang_Tuan02_Strategy_Read_NhanVien_DP.Strategies;

namespace DPM235479_NguyenVanThang_Tuan02_Strategy_Read_NhanVien_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== PHẦN MỀM TÍNH GIÁ XUẤT KHO NÔNG DƯỢC (STRATEGY PATTERN) ===");

            // 1. Chuẩn bị dữ liệu các lô thuốc trong kho hiện tại
            List<LoHangKho> khoThuoc = new List<LoHangKho>
            {
                new LoHangKho { MaLo = "LO_01 (Nhập tháng trước)", SoLuongTon = 100, DonGiaNhap = 100000 },
                new LoHangKho { MaLo = "LO_02 (Nhập tuần trước)", SoLuongTon = 150, DonGiaNhap = 120000 }
            };

            // 2. Khởi tạo Context xuất kho
            PhieuXuatKhoContext phieuXuat = new PhieuXuatKhoContext();
            int soLuongCanXuat = 180; // Khách hàng mua 180 sản phẩm

            // 3. TÌNH HUỐNG 1: Cấu hình cửa hàng chọn phương pháp "Bình quân gia quyền"
            phieuXuat.ChonChienLuoc(new TinhGiaBinhQuanGiaQuyen());
            phieuXuat.ThucHienXuatKho(khoThuoc, soLuongCanXuat);

            Console.WriteLine("\n-----------------------------------------------------------");

            // 4. TÌNH HUỐNG 2: Đổi cấu hình sang phương pháp "Nhập trước xuất trước (FIFO)"[cite: 2] ngay tại runtime
            phieuXuat.ChonChienLuoc(new TinhGiaFIFO());
            phieuXuat.ThucHienXuatKho(khoThuoc, soLuongCanXuat);

            Console.ReadLine();
        }
    }
}
