using DPM235479_NguyenVanThang_Tuan02_Mediator_Read_NhanVien_DP.Components;
using DPM235479_NguyenVanThang_Tuan02_Mediator_Read_NhanVien_DP.Interfaces;
using DPM235479_NguyenVanThang_Tuan02_Mediator_Read_NhanVien_DP.Models;

using System;

namespace DPM235479_NguyenVanThang_Tuan02_Mediator_ThucTe_DP.Mediators
{
    public class HeThongQuanLyMediator : IMediator
    {
        private NhanVienBanHang _banHang;
        private NhanVienKho _kho;
        private NhanVienKeToan _keToan;
        private NhanVienVanChuyen _vanChuyen;

        public HeThongQuanLyMediator(NhanVienBanHang banHang, NhanVienKho kho, NhanVienKeToan keToan, NhanVienVanChuyen vanChuyen)
        {
            _banHang = banHang; _banHang.SetMediator(this);
            _kho = kho; _kho.SetMediator(this);
            _keToan = keToan; _keToan.SetMediator(this);
            _vanChuyen = vanChuyen; _vanChuyen.SetMediator(this);
        }

        public void Notify(object sender, string suKien, object duLieu)
        {
            if (suKien == "XU_LY_HOA_DON_MOI" && duLieu is HoaDon hd)
            {
                Console.WriteLine("\n[HỆ THỐNG] ---> Nhận tín hiệu Hóa Đơn mới. Bắt đầu luồng xử lý tự động:");

                // 1. Báo Kho xử lý trừ tồn theo lô
                _kho.XuatKhoTheoLo(hd);

                // 2. Báo Vận chuyển lên đơn (nếu có phí ship)
                _vanChuyen.LenDonGiaoHang(hd);

                // 3. Báo Kế toán chốt sổ sách doanh thu
                _keToan.GhiNhanDoanhThu(hd);
            }
        }
    }
}