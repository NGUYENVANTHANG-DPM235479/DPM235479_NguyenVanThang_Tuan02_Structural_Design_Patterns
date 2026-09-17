using DPM235479_NguyenVanThang_Tuan02_Visitor_Read_NhanVien_DP.Clients;
using DPM235479_NguyenVanThang_Tuan02_Visitor_Read_NhanVien_DP.Components;
using DPM235479_NguyenVanThang_Tuan02_Visitor_Read_NhanVien_DP.Interfaces;
using DPM235479_NguyenVanThang_Tuan02_Visitor_Read_NhanVien_DP.Visitors;

namespace DPM235479_NguyenVanThang_Tuan02_Visitor_Read_NhanVien_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== HỆ THỐNG THỐNG KÊ TỒN KHO & CHI PHÍ NÔNG DƯỢC (VISITOR PATTERN) ===\n");

            // 1. Khởi tạo danh sách các sản phẩm thực tế có trong kho cửa hàng
            List<ISanPham> khoHang = new List<ISanPham>
            {
                new PhanBon { TenSanPham = "Phân bón lá hữu cơ AnGiang", GiaNhap = 50000, SoLuongTon = 200, ChiPhiVanChuyenRieng = 150000 },
                new ThuocTruSau { TenSanPham = "Thuốc trừ sâu sinh học thế hệ mới", GiaNhap = 120000, SoLuongTon = 80, PhiKiemDinhDocHai = 300000 },
                new PhanBon { TenSanPham = "Phân bón NPK tổng hợp", GiaNhap = 80000, SoLuongTon = 150, ChiPhiVanChuyenRieng = 200000 }
            };

            // 2. Khởi tạo Visitor chuyên tính toán báo cáo tài chính, chi phí phụ và vận chuyển
            var baoCaoVisitor = new BaoCaoTaiChinhVisitor();

            Console.WriteLine("--- CHI TIẾT BÁO CÁO TỪNG SẢN PHẨM TRONG KHO ---");
            Client.XuatBaoCao(khoHang, baoCaoVisitor);

            // 3. In tổng kết kết quả tài chính thống kê theo yêu cầu đồ án
            Console.WriteLine("\n-----------------------------------------------------------");
            Console.WriteLine($"[TỔNG KẾT TÀI CHÍNH KHO HÀNG]");
            Console.WriteLine($" - Tổng giá trị hàng hóa tồn kho: {baoCaoVisitor.TongTienTonKho:N0} VNĐ");
            Console.WriteLine($" - Tổng chi phí vận chuyển & dịch vụ phụ: {baoCaoVisitor.TongChiPhiDichVuVaVanChuyen:N0} VNĐ[cite: 2]");
            Console.WriteLine("-----------------------------------------------------------");

            Console.ReadLine();
        }
    }
}
