using DPM235479_NguyenVanThang_Tuan02_State_Read_NhanVien_DP.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_State_Read_NhanVien_DP.States
{
    public class TrangThaiDaHuy : TrangThaiHoaDon
    {
        public override void ThemSanPham(string tenSanPham)
        {
            Console.WriteLine($"[LỖI] Hóa đơn đã hủy, không thể thêm sản phẩm.");
        }

        public override void ThemChiPhiVanChuyen(decimal phiShip)
        {
            Console.WriteLine($"[LỖI] Hóa đơn đã hủy, không thể thêm phí vận chuyển.");
        }

        public override void ThanhToan()
        {
            Console.WriteLine($"[LỖI] Không thể thu tiền trên một hóa đơn đã hủy.");
        }

        public override void HuyHoaDon()
        {
            Console.WriteLine("- Hóa đơn này vốn đã ở trạng thái Hủy.");
        }
    }
}
