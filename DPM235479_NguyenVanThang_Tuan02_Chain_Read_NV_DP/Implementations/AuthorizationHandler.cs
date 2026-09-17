using DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Abstractions;
using DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Implementations
{
    public class AuthorizationHandler : AbstractHandler
    {
        public override string Handle(RequestContext request)
        {
            if (request.UserRole != "Admin" && request.UserRole != "Manager")
            {
                return "Authorization Failed: Bạn không có quyền xem thông tin nhân viên này.";
            }
            // Chuyển tiếp cho mắt xích tiếp theo nếu có quyền
            return base.Handle(request);
        }
    }
}
