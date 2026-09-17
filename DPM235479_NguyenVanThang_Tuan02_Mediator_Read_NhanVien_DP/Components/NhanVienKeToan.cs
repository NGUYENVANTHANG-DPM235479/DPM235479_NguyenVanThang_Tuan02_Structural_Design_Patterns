using DPM235479_NguyenVanThang_Tuan02_Mediator_Read_NhanVien_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Mediator_Read_NhanVien_DP.Components
{
    public class NhanVienKeToan : NhanVienBase
    {
        public NhanVienKeToan(string tenNV) : base(tenNV) { }

        public void GhiNhanDoanhThu(HoaDon hd)
        {
            decimal tongTien = (hd.SoLuong * hd.DonGia) - hd.GiamGiaKhuyenMai + hd.ChiPhiVanChuyen;
            Console.WriteLine($"[KẾ TOÁN] '{TenNV}' ghi nhận doanh thu HĐ {hd.MaHD}:");
            Console.WriteLine($"          - Tiền hàng: {hd.SoLuong * hd.DonGia:N0} VNĐ");
            Console.WriteLine($"          - Khuyến mãi: -{hd.GiamGiaKhuyenMai:N0} VNĐ");
            Console.WriteLine($"          - Phí Ship: +{hd.ChiPhiVanChuyen:N0} VNĐ");
            Console.WriteLine($"          => TỔNG THU: {tongTien:N0} VNĐ");
        }
    }
}
