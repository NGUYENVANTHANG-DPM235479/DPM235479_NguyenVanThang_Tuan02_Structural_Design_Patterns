using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Mediator_Read_NhanVien_DP.Models
{
    public class HoaDon
    {
        public string MaHD { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal GiamGiaKhuyenMai { get; set; } // Giảm giá
        public decimal ChiPhiVanChuyen { get; set; }  // Phí vận chuyển
    }
}
