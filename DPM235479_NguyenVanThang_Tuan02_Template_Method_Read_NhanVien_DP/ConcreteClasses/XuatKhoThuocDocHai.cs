using DPM235479_NguyenVanThang_Tuan02_Template_Method_Read_NhanVien_DP.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Template_Method_Read_NhanVien_DP.ConcreteClasses
{
    public class XuatKhoThuocDocHai : QuyTrinhXuatKho
    {
        // Ghi đè bước kiểm tra đặc biệt (Sử dụng Hook)
        protected override void KiemTraGiayPhepDacBiet()
        {
            Console.WriteLine("[ĐẶC BIỆT] Kiểm tra pháp lý: Yêu cầu đại lý xuất trình Giấy phép kinh doanh thuốc độc hại cấp độ cao!");
        }

        protected override void TinhGiaVonVaThanhTien()
        {
            Console.WriteLine("[3] Kế toán: Tính giá xuất kho theo phương pháp Nhập trước xuất trước (FIFO) kèm phụ phí bảo quản nghiêm ngặt.[cite: 2]");
            Console.WriteLine("[4] Hóa đơn: Đã áp dụng chính sách kiểm soát đặc biệt và chiết khấu theo quy định.[cite: 2]");
        }
    }   
}
