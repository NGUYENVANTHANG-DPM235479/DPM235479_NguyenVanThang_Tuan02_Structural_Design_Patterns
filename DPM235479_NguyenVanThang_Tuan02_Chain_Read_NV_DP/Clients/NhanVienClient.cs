using DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Abstractions;
using DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Clients
{
    public class NhanVienClient
    {
        public static void ExecuteReadProcess(AbstractHandler handler, RequestContext request)
        {
            Console.WriteLine($"\n[Client] Yêu cầu đọc NV ID: {request.NhanVienId} với quyền: {request.UserRole}");
            var result = handler.Handle(request);

            if (result != null)
            {
                Console.WriteLine($"   Kết quả: {result}");
            }
            else
            {
                Console.WriteLine("   Lỗi: Chuỗi xử lý không trả về kết quả.");
            }
        }
    }
}
