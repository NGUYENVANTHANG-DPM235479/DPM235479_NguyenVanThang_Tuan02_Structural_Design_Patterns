using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Visitor_Read_NhanVien_DP.Interfaces
{
    public interface ISanPham
    {
        // Cho phép một Visitor "ghé thăm" sản phẩm này
        void Accept(IBaoCaoVisitor visitor);
    }
}
