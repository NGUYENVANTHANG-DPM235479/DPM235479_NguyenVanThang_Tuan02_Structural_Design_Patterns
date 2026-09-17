using DPM235479_NguyenVanThang_Tuan02_State_Read_NhanVien_DP.Contexts;
using DPM235479_NguyenVanThang_Tuan02_State_Read_NhanVien_DP.States;

namespace DPM235479_NguyenVanThang_Tuan02_State_Read_NhanVien_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== HỆ THỐNG QUẢN LÝ HÓA ĐƠN NÔNG DƯỢC (STATE PATTERN) ===\n");

            // KỊCH BẢN 1: Luồng mua hàng bình thường thành công
            Console.WriteLine(">>> KỊCH BẢN 1: Lập hóa đơn và thanh toán");
            HoaDonContext hoaDon1 = new HoaDonContext("HD-001", new TrangThaiMoiTao());

            // Đang ở trạng thái "Mới tạo", có thể thêm dịch vụ và phí vận chuyển như yêu cầu
            hoaDon1.ThemSanPham("Thuốc trừ sâu AnGiang");
            hoaDon1.ThemChiPhiVanChuyen(50000); // Thêm chi phí vận chuyển thành công

            // Tiến hành thanh toán
            hoaDon1.ThanhToan();

            // Cố tình thêm sản phẩm sau khi đã thanh toán (Hệ thống sẽ chặn lại)
            hoaDon1.ThemSanPham("Phân bón NPK");


            Console.WriteLine("\n-------------------------------------------------");


            // KỊCH BẢN 2: Khách hàng đổi ý, hủy hóa đơn
            Console.WriteLine("\n>>> KỊCH BẢN 2: Khách hàng hủy đơn");
            HoaDonContext hoaDon2 = new HoaDonContext("HD-002", new TrangThaiMoiTao());

            hoaDon2.ThemSanPham("Hạt giống lúa");

            // Khách hàng báo hủy
            hoaDon2.HuyHoaDon();

            // Cố tình ấn nút thanh toán trên hóa đơn đã hủy (Hệ thống sẽ chặn lại)
            hoaDon2.ThanhToan();

            Console.ReadLine();
        }
    }
}
