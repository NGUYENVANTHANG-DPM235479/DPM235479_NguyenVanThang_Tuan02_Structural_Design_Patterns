using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Mediator_Read_NhanVien_DP.Interfaces
{
    public interface IMediator
    {
        void Notify(object sender, string suKien, object duLieu);
    }
}
