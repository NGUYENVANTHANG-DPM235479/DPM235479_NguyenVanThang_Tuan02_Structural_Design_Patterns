using DPM235479_NguyenVanThang_Tuan02_Observer_Read_NhanVien_DP.Interfaces;
using DPM235479_NguyenVanThang_Tuan02_Observer_Read_NhanVien_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Observer_Read_NhanVien_DP.Subjects
{
    public class KhoNongDuoc : ISubject
    {
        // Danh sách những người đã đăng ký nhận cảnh báo từ Kho
        private List<IQuanSatVien> _danhSachNguoiQuanSat = new List<IQuanSatVien>();

        public void DangKy(IQuanSatVien quanSatVien)
        {
            _danhSachNguoiQuanSat.Add(quanSatVien);
            Console.WriteLine("[Hệ thống] Một người dùng vừa đăng ký nhận cảnh báo kho.");
        }

        public void HuyDangKy(IQuanSatVien quanSatVien)
        {
            _danhSachNguoiQuanSat.Remove(quanSatVien);
            Console.WriteLine("[Hệ thống] Một người dùng đã hủy nhận cảnh báo.");
        }

        public void ThongBao(LoHang loHang, string thongDiep)
        {
            Console.WriteLine("\n[KHO HÀNG PHÁT CẢNH BÁO] Đang gửi thông báo đến các bộ phận...");

            // Duyệt qua tất cả những người đã đăng ký và gọi hàm CapNhatThongBao của họ
            foreach (var nguoiQuanSat in _danhSachNguoiQuanSat)
            {
                nguoiQuanSat.CapNhatThongBao(loHang, thongDiep);
            }
        }

        // NGHIỆP VỤ THỰC TẾ: Kiểm tra tình trạng lô hàng sau mỗi ngày
        public void KiemTraLoHang(LoHang loHang)
        {
            Console.WriteLine($"\n--- Đang kiểm tra {loHang.MaLo} ({loHang.TenThuoc}) ---");

            // Nếu lô hàng còn dưới 30 ngày là hết hạn
            if (loHang.SoNgayConLai <= 30)
            {
                string msg = $"CẢNH BÁO HẾT HẠN: Lô {loHang.MaLo} chỉ còn {loHang.SoNgayConLai} ngày nữa là hết hạn!";
                ThongBao(loHang, msg);
            }
            // Nếu tồn kho dưới 50 chai
            else if (loHang.SoLuongTon < 50)
            {
                string msg = $"CẢNH BÁO HẾT HÀNG: Lô {loHang.MaLo} sắp hết, chỉ còn {loHang.SoLuongTon} sản phẩm trong kho.";
                ThongBao(loHang, msg);
            }
            else
            {
                Console.WriteLine("Trạng thái lô hàng bình thường. Không cần cảnh báo.");
            }
        }
    }
}
