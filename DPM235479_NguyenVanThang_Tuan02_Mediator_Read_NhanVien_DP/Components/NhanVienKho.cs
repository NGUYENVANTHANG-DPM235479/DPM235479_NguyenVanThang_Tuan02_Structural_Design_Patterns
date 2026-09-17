using DPM235479_NguyenVanThang_Tuan02_Mediator_Read_NhanVien_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Mediator_Read_NhanVien_DP.Components
{
    public class NhanVienKho : NhanVienBase 
    {
        public NhanVienKho(string tenNV) : base(tenNV) { }

        public void XuatKhoTheoLo(HoaDon hd)
        {
            Console.WriteLine($"[KHO] '{TenNV}' đang xử lý: Áp dụng phương pháp Nhập trước Xuất trước (FIFO) để xuất {hd.SoLuong} SP '{hd.TenSanPham}'.");
            Console.WriteLine($"[KHO] -> Đã trừ tồn kho thành công.");
        }
    }
}
