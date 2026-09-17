using DPM235479_NguyenVanThang_Tuan02_Memento_Read_NhanVien_DP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Memento_Read_NhanVien_DP.Mementos
{
    public class NhanVienMemento : IMemento
    {
        // Các trạng thái cần lưu trữ (Không cho phép sửa đổi từ bên ngoài sau khi đã lưu)
        private readonly string _hoTen;
        private readonly string _chucVu;
        private readonly decimal _luong;
        private readonly DateTime _date;

        public NhanVienMemento(string hoTen, string chucVu, decimal luong)
        {
            this._hoTen = hoTen;
            this._chucVu = chucVu;
            this._luong = luong;
            this._date = DateTime.Now;
        }

        // Originator sẽ dùng các hàm này để phục hồi dữ liệu
        public string GetHoTen() => _hoTen;
        public string GetChucVu() => _chucVu;
        public decimal GetLuong() => _luong;

        public string GetNhanVienState()
        {
            return $"[{_chucVu}] {_hoTen} - Lương: {_luong:N0} VNĐ";
        }

        public string GetName()
        {
            return $"{_date:HH:mm:ss} | {_hoTen} ({_chucVu})";
        }

        public DateTime GetDate()
        {
            return _date;
        }
    }
}
