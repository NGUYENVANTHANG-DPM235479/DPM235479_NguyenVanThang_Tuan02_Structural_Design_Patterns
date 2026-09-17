using DPM235479_NguyenVanThang_Tuan02_Observer_Read_NhanVien_DP.Interfaces;
using DPM235479_NguyenVanThang_Tuan02_Observer_Read_NhanVien_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Observer_Read_NhanVien_DP.Observers
{
    public class NhanVienBanHang : IQuanSatVien
    {
        public string Ten { get; set; }

        public NhanVienBanHang(string ten)
        {
            Ten = ten;
        }

        // Phản ứng của Nhân viên bán hàng khi nhận được thông báo từ Kho
        public void CapNhatThongBao(LoHang loHang, string thongDiep)
        {
            Console.WriteLine($" -> [NV Bán Hàng - {Ten}] Đã nhận tin: '{thongDiep}'");

            if (loHang.SoNgayConLai <= 30)
            {
                // Áp dụng nghiệp vụ giảm giá khuyến mãi theo yêu cầu đề bài đồ án
                Console.WriteLine($"    => {Ten} sẽ đẩy mạnh quảng cáo, set Giảm giá Khuyến mãi 20% để xả nhanh lô {loHang.MaLo} theo chuẩn FIFO.");
            }
        }
    }
}
