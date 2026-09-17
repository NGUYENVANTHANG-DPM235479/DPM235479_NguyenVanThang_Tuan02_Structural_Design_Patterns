using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Memento_Read_NhanVien_DP.Interfaces
{
    public interface IMemento
    {
        string GetName();
        DateTime GetDate();
        // Lấy dữ liệu chi tiết của nhân viên tại thời điểm lưu
        string GetNhanVienState();
    }
}
