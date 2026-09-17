using DPM235479_NguyenVanThang_Tuan02_Strategy_Read_NhanVien_DP.Interfaces;
using DPM235479_NguyenVanThang_Tuan02_Strategy_Read_NhanVien_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Strategy_Read_NhanVien_DP.Strategies
{
    public class TinhGiaFIFO : IChienLuocTinhGia
    {
        public decimal TinhTienXuatKho(List<LoHangKho> danhSachLo, int soLuongXuat)
        {
            Console.WriteLine("[Thuật toán] Đang áp dụng phương pháp: NHẬP TRƯỚC XUẤT TRƯỚC (FIFO)");

            int soLuongCanTru = soLuongXuat;
            decimal tongTienXuat = 0;

            // Giả định danh sách lô đã sắp xếp theo thứ tự nhập trước xuất trước
            foreach (var lo in danhSachLo)
            {
                if (soLuongCanTru <= 0) break;

                if (lo.SoLuongTon >= soLuongCanTru)
                {
                    // Lô này đủ cung cấp phần còn thiếu
                    tongTienXuat += soLuongCanTru * lo.DonGiaNhap;
                    Console.WriteLine($" -> Lấy {soLuongCanTru} sản phẩm từ {lo.MaLo} (Giá: {lo.DonGiaNhap:N0})");
                    soLuongCanTru = 0;
                }
                else
                {
                    // Lô này không đủ, vét sạch lô này và chuyển sang lô tiếp theo
                    tongTienXuat += lo.SoLuongTon * lo.DonGiaNhap;
                    Console.WriteLine($" -> Vét sạch {lo.SoLuongTon} sản phẩm từ {lo.MaLo} (Giá: {lo.DonGiaNhap:N0})");
                    soLuongCanTru -= lo.SoLuongTon;
                }
            }

            return tongTienXuat;
        }
    }
}
