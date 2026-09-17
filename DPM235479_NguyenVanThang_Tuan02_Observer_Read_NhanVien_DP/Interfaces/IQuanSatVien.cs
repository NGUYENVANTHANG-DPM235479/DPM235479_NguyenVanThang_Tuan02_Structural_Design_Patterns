using DPM235479_NguyenVanThang_Tuan02_Observer_Read_NhanVien_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Observer_Read_NhanVien_DP.Interfaces
{
    public interface IQuanSatVien
    {
        // Hàm này sẽ được gọi tự động khi Kho có thông báo
        void CapNhatThongBao(LoHang loHang, string thongDiep);
    }
}
