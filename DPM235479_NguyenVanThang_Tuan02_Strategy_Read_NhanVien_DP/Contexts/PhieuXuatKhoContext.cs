using DPM235479_NguyenVanThang_Tuan02_Strategy_Read_NhanVien_DP.Interfaces;
using DPM235479_NguyenVanThang_Tuan02_Strategy_Read_NhanVien_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Strategy_Read_NhanVien_DP.Contexts
{
    public class PhieuXuatKhoContext
    {
        private IChienLuocTinhGia _chienLuoc;

        // Cho phép truyền chiến lược vào thông qua Constructor hoặc hàm Set
        public void ChonChienLuoc(IChienLuocTinhGia chienLuoc)
        {
            this._chienLuoc = chienLuoc;
        }

        public decimal ThucHienXuatKho(List<LoHangKho> danhSachLo, int soLuongXuat)
        {
            if (_chienLuoc == null)
            {
                throw new InvalidOperationException("Vui lòng chọn phương pháp tính giá xuất kho trước!");
            }

            Console.WriteLine($"\n--- LẬP PHIẾU XUẤT KHO CHO {soLuongXuat} SẢN PHẨM ---");
            // Ủy quyền việc tính toán cho Strategy đã chọn
            decimal tongTien = _chienLuoc.TinhTienXuatKho(danhSachLo, soLuongXuat);

            Console.WriteLine($"=> TỔNG GIÁ TRỊ XUẤT KHO: {tongTien:N0} VNĐ");
            return tongTien;
        }
    }
}
