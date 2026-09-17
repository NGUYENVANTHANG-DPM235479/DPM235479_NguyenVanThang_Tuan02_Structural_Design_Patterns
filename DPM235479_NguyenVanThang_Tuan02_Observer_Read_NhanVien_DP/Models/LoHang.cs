using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Observer_Read_NhanVien_DP.Models
{
    public class LoHang
    {
        public string MaLo { get; set; }
        public string TenThuoc { get; set; }
        public int SoLuongTon { get; set; }
        public int SoNgayConLai { get; set; } // Số ngày trước khi hết hạn
    }
}
