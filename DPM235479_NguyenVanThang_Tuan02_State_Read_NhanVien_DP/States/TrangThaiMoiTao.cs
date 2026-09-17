using DPM235479_NguyenVanThang_Tuan02_State_Read_NhanVien_DP.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_State_Read_NhanVien_DP.States
{
    public class TrangThaiMoiTao : TrangThaiHoaDon
    {
        public override void ThemSanPham(string tenSanPham)
        {
            Console.WriteLine($"- Đã thêm sản phẩm '{tenSanPham}' vào hóa đơn.");
        }

        public override void ThemChiPhiVanChuyen(decimal phiShip)
        {
            Console.WriteLine($"- Đã cập nhật chi phí vận chuyển: {phiShip:N0} VNĐ vào hóa đơn.");
        }

        public override void ThanhToan()
        {
            Console.WriteLine("- Khách hàng đã thanh toán đủ. Đang chốt sổ...");
            // Đổi trạng thái Hóa đơn sang Đã Thanh Toán
            this._hoaDon.ChuyenTrangThai(new TrangThaiDaThanhToan());
        }

        public override void HuyHoaDon()
        {
            Console.WriteLine("- Hóa đơn đã bị hủy bởi nhân viên.");
            // Đổi trạng thái Hóa đơn sang Đã Hủy
            this._hoaDon.ChuyenTrangThai(new TrangThaiDaHuy());
        }
    }
}
