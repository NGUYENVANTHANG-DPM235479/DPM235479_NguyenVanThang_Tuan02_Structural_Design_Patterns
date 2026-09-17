using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Template_Method_Read_NhanVien_DP.Abstractions
{
    public abstract class QuyTrinhXuatKho
    {
        // TEMPLATE METHOD: Định nghĩa bộ khung (skeleton) của thuật toán xuất kho
        // Các bước được chạy theo một trình tự cố định, lớp con không được phép thay đổi thứ tự này.
        public void ThucHienXuatKho(string tenSanPham, int soLuong)
        {
            Console.WriteLine($"\n--- BẮT ĐẦU QUY TRÌNH XUẤT KHO CHO: {tenSanPham} (SL: {soLuong}) ---");

            KiemTraThongTinDonHang();
            KiemTraTonKhoTheoLo();       // Kiểm tra FIFO hoặc lô hàng

            // Bước tùy chọn: Kiểm tra đặc biệt (Hook) dành cho hàng độc hại
            KiemTraGiayPhepDacBiet();

            TinhGiaVonVaThanhTien();     // Tính tiền (Bình quân hoặc FIFO)[cite: 2]
            InPhieuXuatKho();
            GhiNhatKyHeThong();          // Ghi log phục vụ bảo trì phần mềm[cite: 2]

            Console.WriteLine($"--- HOÀN TẤT XUẤT KHO CHO: {tenSanPham} ---");
        }

        // Các bước đã có sẵn logic chung cho mọi loại hàng hóa
        protected void KiemTraThongTinDonHang()
        {
            Console.WriteLine("[1] Hệ thống: Đã xác thực thông tin khách hàng và mã sản phẩm hợp lệ.");
        }

        protected void KiemTraTonKhoTheoLo()
        {
            Console.WriteLine("[2] Kho hàng: Đã tự động phân lô và kiểm tra ngày hết hạn (Áp dụng cấu hình kho).[cite: 2]");
        }

        // HOOK (Điểm neo mở rộng): Mặc định các mặt hàng thường không cần kiểm tra giấy phép.
        // Lớp con nào cần (như thuốc độc hại) sẽ tự động ghi đè (override) phương thức này.
        protected virtual void KiemTraGiayPhepDacBiet() { }

        // Các bước bắt buộc lớp con phải tự triển khai chi tiết vì cách tính tiền/in phiếu có thể khác nhau
        protected abstract void TinhGiaVonVaThanhTien();

        protected void InPhieuXuatKho()
        {
            Console.WriteLine("[5] In ấn: Đã phát lệnh in phiếu xuất kho ra máy in của cửa hàng.");
        }

        protected void GhiNhatKyHeThong()
        {
            Console.WriteLine("[6] Bảo trì/Log: Đã ghi nhận lịch sử thao tác vào cơ sở dữ liệu hệ thống.");
        }
    }
}
