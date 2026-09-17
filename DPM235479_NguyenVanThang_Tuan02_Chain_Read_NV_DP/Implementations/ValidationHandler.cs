using DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Abstractions;
using DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Implementations
{
    public class ValidationHandler : AbstractHandler
    {
        public override string Handle(RequestContext request)
        {
            if (request.NhanVienId <= 0)
            {
                return "Validation Failed: ID Nhân viên không hợp lệ (Phải lớn hơn 0).";
            }
            // Chuyển tiếp cho mắt xích tiếp theo nếu hợp lệ
            return base.Handle(request);
        }
    }
}
