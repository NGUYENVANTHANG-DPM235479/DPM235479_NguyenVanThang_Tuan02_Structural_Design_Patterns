using DPM235479_NguyenVanThang_Tuan02_State_Read_NhanVien_DP.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_State_Read_NhanVien_DP.Contexts
{
    public class HoaDonContext
    {
        private TrangThaiHoaDon _trangThaiHienTai = null;
        public string MaHD { get; set; }

        public HoaDonContext(string maHD, TrangThaiHoaDon trangThaiBanDau)
        {
            MaHD = maHD;
            ChuyenTrangThai(trangThaiBanDau);
        }

        // Hàm chuyển đổi trạng thái (Ví dụ: Từ Mới tạo -> Đã thanh toán)
        public void ChuyenTrangThai(TrangThaiHoaDon trangThaiMoi)
        {
            Console.WriteLine($"\n[Hệ thống] Hóa đơn {MaHD} chuyển sang trạng thái: {trangThaiMoi.GetType().Name}");
            this._trangThaiHienTai = trangThaiMoi;
            this._trangThaiHienTai.SetContext(this);
        }

        // Các hành động được gọi từ Client sẽ do State hiện tại quyết định có cho phép hay không
        public void ThemSanPham(string tenSanPham)
        {
            this._trangThaiHienTai.ThemSanPham(tenSanPham);
        }

        public void ThemChiPhiVanChuyen(decimal phiShip)
        {
            this._trangThaiHienTai.ThemChiPhiVanChuyen(phiShip);
        }

        public void ThanhToan()
        {
            this._trangThaiHienTai.ThanhToan();
        }

        public void HuyHoaDon()
        {
            this._trangThaiHienTai.HuyHoaDon();
        }
    }
}
