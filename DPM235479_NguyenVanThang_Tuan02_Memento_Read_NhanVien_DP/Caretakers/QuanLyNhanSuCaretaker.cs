using DPM235479_NguyenVanThang_Tuan02_Memento_Read_NhanVien_DP.Interfaces;
using DPM235479_NguyenVanThang_Tuan02_Memento_Read_NhanVien_DP.Originators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DPM235479_NguyenVanThang_Tuan02_Memento_ThucTe_DP.Caretakers
{
    public class QuanLyNhanSuCaretaker
    {
        private List<IMemento> _lichSuLuu = new List<IMemento>();
        private NhanVienOriginator _nhanVien;

        public QuanLyNhanSuCaretaker(NhanVienOriginator nhanVien)
        {
            this._nhanVien = nhanVien;
        }

        public void Backup()
        {
            Console.WriteLine("[Hệ thống] Đang lưu lịch sử trạng thái nhân viên...");
            this._lichSuLuu.Add(this._nhanVien.Save());
        }

        public void Undo()
        {
            if (this._lichSuLuu.Count == 0)
            {
                Console.WriteLine("[Hệ thống] Không có lịch sử nào để hoàn tác.");
                return;
            }

            // Lấy ra bản lưu gần nhất và xóa nó khỏi lịch sử
            var memento = this._lichSuLuu.Last();
            this._lichSuLuu.Remove(memento);

            Console.WriteLine($"\n[Hệ thống] Bắt đầu Hoàn tác về phiên bản: {memento.GetName()}");

            try
            {
                this._nhanVien.Restore(memento);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi hoàn tác: " + ex.Message);
            }
        }

        public void HienThiLichSu()
        {
            Console.WriteLine("\n=== LỊCH SỬ THAY ĐỔI HỒ SƠ ===");
            foreach (var memento in this._lichSuLuu)
            {
                Console.WriteLine($"- {memento.GetName()} | Chi tiết: {memento.GetNhanVienState()}");
            }
            Console.WriteLine("==============================\n");
        }
    }
}