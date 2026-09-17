using DPM235479_NguyenVanThang_Tuan02_Template_Method_Read_NhanVien_DP.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Template_Method_Read_NhanVien_DP.ConcreteClasses
{
    public class XuatKhoThuocThuong : QuyTrinhXuatKho
    {
        protected override void TinhGiaVonVaThanhTien()
        {
            Console.WriteLine("[3] Kế toán: Tính giá xuất kho theo phương pháp thông thường (Bình quân gia quyền).[cite: 2]");
            Console.WriteLine("[4] Hóa đơn: Tổng tiền hàng đã được cộng thêm chi phí vận chuyển nếu có.[cite: 2]");
        }

        // Không cần override KiemTraGiayPhepDacBiet() vì thuốc thường không cần giấy phép đặc biệt.
    }
}
