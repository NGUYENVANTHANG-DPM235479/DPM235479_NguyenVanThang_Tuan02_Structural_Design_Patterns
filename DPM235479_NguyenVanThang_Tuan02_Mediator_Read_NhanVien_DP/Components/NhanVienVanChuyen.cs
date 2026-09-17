using DPM235479_NguyenVanThang_Tuan02_Mediator_Read_NhanVien_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Mediator_Read_NhanVien_DP.Components
{
    public class NhanVienVanChuyen : NhanVienBase
    {
        public NhanVienVanChuyen(string tenNV) : base(tenNV) { }

        public void LenDonGiaoHang(HoaDon hd)
        {
            if (hd.ChiPhiVanChuyen > 0)
            {
                Console.WriteLine($"[VẬN CHUYỂN] '{TenNV}' đã tiếp nhận đơn. Đang điều phối xe tải giao lô hàng {hd.MaHD} đi các đại lý.");
            }
        }
    }
}
