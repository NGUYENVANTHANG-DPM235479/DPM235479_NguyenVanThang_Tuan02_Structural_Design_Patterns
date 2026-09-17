using DPM235479_NguyenVanThang_Tuan02_Strategy_Read_NhanVien_DP.Interfaces;
using DPM235479_NguyenVanThang_Tuan02_Strategy_Read_NhanVien_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Strategy_Read_NhanVien_DP.Strategies
{
    public class TinhGiaBinhQuanGiaQuyen : IChienLuocTinhGia
    {
        public decimal TinhTienXuatKho(List<LoHangKho> danhSachLo, int soLuongXuat)
        {
            Console.WriteLine("[Thuật toán] Đang áp dụng phương pháp: BÌNH QUÂN GIA QUYỀN");

            decimal tongGiaTri = 0;
            int tongSoLuong = 0;

            foreach (var lo in danhSachLo)
            {
                tongGiaTri += lo.SoLuongTon * lo.DonGiaNhap;
                tongSoLuong += lo.SoLuongTon;
            }

            if (tongSoLuong == 0) return 0;

            // Tính đơn giá bình quân gia quyền 1 sản phẩm
            decimal donGiaBinhQuan = tongGiaTri / tongSoLuong;
            decimal thanhTien = soLuongXuat * donGiaBinhQuan;

            Console.WriteLine($" -> Đơn giá bình quân: {donGiaBinhQuan:N0} VNĐ/sản phẩm");
            return thanhTien;
        }
    }

}
