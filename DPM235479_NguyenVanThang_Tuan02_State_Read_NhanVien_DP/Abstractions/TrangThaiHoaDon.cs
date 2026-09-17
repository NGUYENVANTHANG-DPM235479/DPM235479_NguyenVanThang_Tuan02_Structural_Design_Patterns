using DPM235479_NguyenVanThang_Tuan02_State_Read_NhanVien_DP.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_State_Read_NhanVien_DP.Abstractions
{
    public abstract class TrangThaiHoaDon
    {
        protected HoaDonContext _hoaDon;

        public void SetContext(HoaDonContext hoaDon)
        {
            this._hoaDon = hoaDon;
        }

        // Các nghiệp vụ chính khi lập hóa đơn bán hàng
        public abstract void ThemSanPham(string tenSanPham);
        public abstract void ThemChiPhiVanChuyen(decimal phiShip);
        public abstract void ThanhToan();
        public abstract void HuyHoaDon();
    }
}
