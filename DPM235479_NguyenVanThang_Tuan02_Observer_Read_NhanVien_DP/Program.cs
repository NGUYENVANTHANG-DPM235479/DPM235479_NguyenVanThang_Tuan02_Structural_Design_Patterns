using DPM235479_NguyenVanThang_Tuan02_Observer_Read_NhanVien_DP.Models;
using DPM235479_NguyenVanThang_Tuan02_Observer_Read_NhanVien_DP.Observers;
using DPM235479_NguyenVanThang_Tuan02_Observer_Read_NhanVien_DP.Subjects;

namespace DPM235479_NguyenVanThang_Tuan02_Observer_Read_NhanVien_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== HỆ THỐNG CẢNH BÁO KHO NÔNG DƯỢC (OBSERVER PATTERN) ===\n");

            // 1. Khởi tạo Chủ thể phát thông báo (Subject)
            KhoNongDuoc khoHệThong = new KhoNongDuoc();

            // 2. Khởi tạo những người cần theo dõi kho (Observers)
            NhanVienBanHang nvThang = new NhanVienBanHang("Thắng");
            QuanLyCuaHang qlMai = new QuanLyCuaHang("Mai");

            // 3. Cho họ "Đăng ký" nhận thông báo từ Kho
            khoHệThong.DangKy(nvThang);
            khoHệThong.DangKy(qlMai);

            // 4. MÔ PHỎNG THỰC TẾ 1: Lô hàng sắp hết hạn (còn 20 ngày)
            LoHang loPhanBon = new LoHang
            {
                MaLo = "L-PB-001",
                TenThuoc = "Phân bón lá NPK",
                SoLuongTon = 200,
                SoNgayConLai = 20 // < 30 ngày sẽ báo động
            };
            khoHệThong.KiemTraLoHang(loPhanBon);

            // 5. MÔ PHỎNG THỰC TẾ 2: Lô hàng sắp hết số lượng (còn 15 chai)
            LoHang loTruSau = new LoHang
            {
                MaLo = "L-TS-009",
                TenThuoc = "Thuốc trừ sâu rầy sinh học",
                SoLuongTon = 15, // < 50 chai sẽ báo động
                SoNgayConLai = 180
            };
            khoHệThong.KiemTraLoHang(loTruSau);

            Console.ReadLine();
        }
    }
}
