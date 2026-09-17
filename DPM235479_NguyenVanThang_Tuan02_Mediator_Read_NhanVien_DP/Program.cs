using DPM235479_NguyenVanThang_Tuan02_Mediator_Read_NhanVien_DP.Components;
using DPM235479_NguyenVanThang_Tuan02_Mediator_Read_NhanVien_DP.Models;
using DPM235479_NguyenVanThang_Tuan02_Mediator_ThucTe_DP.Mediators;

namespace DPM235479_NguyenVanThang_Tuan02_Mediator_Read_NhanVien_DP
{
    class Program
    {
        static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("=== PHẦN MỀM QUẢN LÝ NÔNG DƯỢC AN GIANG (MEDIATOR PATTERN) ===\n");

        // 1. Khởi tạo các nhân viên tham gia hệ thống
        var nvBanHang = new NhanVienBanHang("Thắng (Sale)");
        var nvKho = new NhanVienKho("Hải (Kho)");
        var nvKeToan = new NhanVienKeToan("Lan (Kế toán)");
        var nvVanChuyen = new NhanVienVanChuyen("Long (Giao hàng)");

        // 2. Thiết lập Hệ thống Trung gian
        var heThong = new HeThongQuanLyMediator(nvBanHang, nvKho, nvKeToan, nvVanChuyen);

        // 3. Thực tế nghiệp vụ: Lập hóa đơn với đầy đủ thông số
        HoaDon hdMoi = new HoaDon
        {
            MaHD = "HD-NONGDUOC-001",
            TenSanPham = "Thuốc trừ sâu AnGiang-X",
            SoLuong = 100,
            DonGia = 150000,           // 150.000 VNĐ/chai
            GiamGiaKhuyenMai = 500000, // Giảm 500k cho khách sỉ
            ChiPhiVanChuyen = 200000   // Thu thêm 200k tiền xe tải
        };

        // Nhân viên bán hàng chỉ cần làm 1 thao tác duy nhất: Tạo hóa đơn
        // Mọi việc còn lại Hệ thống Mediator sẽ tự động gọi các phòng ban khác!
        nvBanHang.TaoHoaDon(hdMoi);

        Console.ReadLine();
    }
}
}
