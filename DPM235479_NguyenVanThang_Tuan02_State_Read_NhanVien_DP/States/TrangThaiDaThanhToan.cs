using DPM235479_NguyenVanThang_Tuan02_State_Read_NhanVien_DP.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_State_Read_NhanVien_DP.States
{
    public class TrangThaiDaThanhToan : TrangThaiHoaDon
    {
        public override void ThemSanPham(string tenSanPham)
        {
            Console.WriteLine($"[LỖI] Không thể thêm '{tenSanPham}'. Hóa đơn đã thanh toán, không được phép sửa đổi!");
        }

        public override void ThemChiPhiVanChuyen(decimal phiShip)
        {
            Console.WriteLine($"[LỖI] Không thể thêm phí vận chuyển {phiShip:N0}. Hóa đơn đã chốt!");
        }

        public override void ThanhToan()
        {
            Console.WriteLine("[LỖI] Hóa đơn này đã được thanh toán rồi, không thể thanh toán 2 lần.");
        }

        public override void HuyHoaDon()
        {
            Console.WriteLine("[CẢNH BÁO] Không thể hủy hóa đơn đã thanh toán. Vui lòng làm thủ tục hoàn tiền qua bộ phận Kế toán.");
        }
    }
}
