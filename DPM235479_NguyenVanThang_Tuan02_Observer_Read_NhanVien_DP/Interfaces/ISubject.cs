using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Observer_Read_NhanVien_DP.Interfaces
{
    public interface ISubject
    {
        void DangKy(IQuanSatVien quanSatVien);     // Thêm người nhận thông báo
        void HuyDangKy(IQuanSatVien quanSatVien);  // Bỏ nhận thông báo
        void ThongBao(Models.LoHang loHang, string thongDiep); // Gửi thông báo đến tất cả
    }
}
