using DPM235479_NguyenVanThang_Tuan02_Observer_Read_NhanVien_DP.Interfaces;
using DPM235479_NguyenVanThang_Tuan02_Observer_Read_NhanVien_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Observer_Read_NhanVien_DP.Observers
{
    public class QuanLyCuaHang : IQuanSatVien
    {
        public string Ten { get; set; }

        public QuanLyCuaHang(string ten)
        {
            Ten = ten;
        }

        // Phản ứng của Quản lý khi nhận được thông báo
        public void CapNhatThongBao(LoHang loHang, string thongDiep)
        {
            Console.WriteLine($" -> [Quản Lý - {Ten}] Đã nhận tin: '{thongDiep}'");

            if (loHang.SoLuongTon < 50)
            {
                Console.WriteLine($"    => {Ten} đang gọi điện cho nhà cung cấp để lập phiếu Nhập hàng theo lô mới cho sản phẩm {loHang.TenThuoc}.");
            }
        }
    }
}
