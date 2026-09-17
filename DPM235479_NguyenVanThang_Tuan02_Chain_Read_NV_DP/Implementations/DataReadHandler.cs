using DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Abstractions;
using DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Implementations
{
    public class DataReadHandler : AbstractHandler
    {
        public override string Handle(RequestContext request)
        {
            // Mô phỏng việc query vào cơ sở dữ liệu Access/SQL để lấy thông tin nhân viên
            return $"Success: Đã lấy thành công dữ liệu của Nhân viên có ID = {request.NhanVienId}.";
        }
    }
}
