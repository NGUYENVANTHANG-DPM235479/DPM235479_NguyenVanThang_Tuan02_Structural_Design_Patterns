using DPM235479_NguyenVanThang_Tuan02_Visitor_Read_NhanVien_DP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Visitor_Read_NhanVien_DP.Clients
{
    public class Client
    {
        // Duyệt qua toàn bộ danh sách sản phẩm trong kho và cho Visitor "ghé thăm" từng sản phẩm
        public static void XuatBaoCao(List<ISanPham> danhSachSanPham, IBaoCaoVisitor visitor)
        {
            foreach (var sp in danhSachSanPham)
            {
                sp.Accept(visitor);
            }
        }
    }
}
