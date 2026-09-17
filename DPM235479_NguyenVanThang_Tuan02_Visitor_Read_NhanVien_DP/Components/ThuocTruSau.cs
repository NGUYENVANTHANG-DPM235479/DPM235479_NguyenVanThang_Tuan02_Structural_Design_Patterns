using DPM235479_NguyenVanThang_Tuan02_Visitor_Read_NhanVien_DP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Visitor_Read_NhanVien_DP.Components
{
    public class ThuocTruSau : ISanPham
    {
        public string TenSanPham { get; set; }
        public decimal GiaNhap { get; set; }
        public int SoLuongTon { get; set; }
        public decimal PhiKiemDinhDocHai { get; set; } // Phí dịch vụ phụ đặc thù

        public void Accept(IBaoCaoVisitor visitor)
        {
            // Chuyển hướng Visitor đến đúng hàm xử lý dành riêng cho Thuốc Trừ Sâu
            visitor.VisitThuocTruSau(this);
        }
    }
}
