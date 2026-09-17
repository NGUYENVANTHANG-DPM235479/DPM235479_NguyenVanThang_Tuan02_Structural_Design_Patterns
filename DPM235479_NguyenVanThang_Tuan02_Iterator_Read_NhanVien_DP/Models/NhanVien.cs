using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Iterator_Read_NhanVien_DP.Models
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }

        public override string ToString()
        {
            return $"[{MaNV}] {HoTen} - {ChucVu}";
        }
    }
}
