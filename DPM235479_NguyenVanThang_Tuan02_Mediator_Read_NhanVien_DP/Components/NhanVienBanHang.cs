using DPM235479_NguyenVanThang_Tuan02_Mediator_Read_NhanVien_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Mediator_Read_NhanVien_DP.Components
{
    public class NhanVienBanHang : NhanVienBase
    {
        public NhanVienBanHang(string tenNV) : base(tenNV) { }

        public void TaoHoaDon(HoaDon hd)
        {
            Console.WriteLine($"[BÁN HÀNG] '{TenNV}' vừa lập Hóa đơn {hd.MaHD} cho sản phẩm '{hd.TenSanPham}' (SL: {hd.SoLuong}).");

            // Bắn tín hiệu cho Mediator biết có hóa đơn mới
            _mediator.Notify(this, "XU_LY_HOA_DON_MOI", hd);
        }
    }
}
