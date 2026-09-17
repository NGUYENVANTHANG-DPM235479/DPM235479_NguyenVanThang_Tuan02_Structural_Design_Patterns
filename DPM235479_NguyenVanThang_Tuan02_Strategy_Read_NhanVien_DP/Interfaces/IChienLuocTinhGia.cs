using DPM235479_NguyenVanThang_Tuan02_Strategy_Read_NhanVien_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Strategy_Read_NhanVien_DP.Interfaces
{
    public interface IChienLuocTinhGia
    {
        // Tính tổng tiền xuất kho dựa trên danh sách các lô hàng và số lượng cần xuất
        decimal TinhTienXuatKho(List<LoHangKho> danhSachLo, int soLuongXuat);
    }
}
