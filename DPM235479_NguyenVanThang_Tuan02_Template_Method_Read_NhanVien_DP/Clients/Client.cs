using DPM235479_NguyenVanThang_Tuan02_Template_Method_Read_NhanVien_DP.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Template_Method_Read_NhanVien_DP.Clients
{
    public class Client
    {
        // Client gọi phương thức chung mà không cần quan tâm chi tiết bên trong thực hiện thế nào
        public static void ThucThiQuyTrinh(QuyTrinhXuatKho quyTrinh, string tenSP, int soLuong)
        {
            quyTrinh.ThucHienXuatKho(tenSP, soLuong);
        }
    }
}
