using DPM235479_NguyenVanThang_Tuan02_Memento_Read_NhanVien_DP.Interfaces;
using DPM235479_NguyenVanThang_Tuan02_Memento_Read_NhanVien_DP.Mementos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Memento_Read_NhanVien_DP.Originators
{
    public class NhanVienOriginator
    {
        public string MaNV { get; private set; }
        private string _hoTen;
        private string _chucVu;
        private decimal _luong;

        public NhanVienOriginator(string maNV, string hoTen, string chucVu, decimal luong)
        {
            MaNV = maNV;
            _hoTen = hoTen;
            _chucVu = chucVu;
            _luong = luong;
            Console.WriteLine($"[Hồ sơ Gốc] Khởi tạo nhân viên {MaNV}: {_hoTen} - {_chucVu} - Lương: {_luong:N0}");
        }

        // Nghiệp vụ: Cập nhật thông tin nhân viên (Thăng chức, tăng lương,...)
        public void CapNhatThongTin(string hoTenMoi, string chucVuMoi, decimal luongMoi)
        {
            Console.WriteLine($"\n[Originator] Đang cập nhật hồ sơ cho {MaNV}...");
            Thread.Sleep(500); // Giả lập thời gian xử lý

            _hoTen = hoTenMoi;
            _chucVu = chucVuMoi;
            _luong = luongMoi;

            Console.WriteLine($" => Hồ sơ mới: {_hoTen} | {_chucVu} | {_luong:N0} VNĐ");
        }

        // Tạo bản sao lưu (Backup)
        public IMemento Save()
        {
            return new NhanVienMemento(_hoTen, _chucVu, _luong);
        }

        // Phục hồi từ bản sao lưu (Restore)
        public void Restore(IMemento memento)
        {
            if (!(memento is NhanVienMemento nvMemento))
            {
                throw new Exception("Lớp Memento không hợp lệ!");
            }

            // Khôi phục lại trạng thái cũ
            _hoTen = nvMemento.GetHoTen();
            _chucVu = nvMemento.GetChucVu();
            _luong = nvMemento.GetLuong();

            Console.WriteLine($"\n[Originator] ĐÃ HOÀN TÁC (UNDO). Trạng thái hiện tại: {nvMemento.GetNhanVienState()}");
        }
    }
}
