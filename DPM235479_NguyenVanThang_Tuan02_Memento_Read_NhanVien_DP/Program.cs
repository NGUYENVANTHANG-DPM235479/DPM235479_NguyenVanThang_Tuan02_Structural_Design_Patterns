
using DPM235479_NguyenVanThang_Tuan02_Memento_Read_NhanVien_DP.Originators;
using DPM235479_NguyenVanThang_Tuan02_Memento_ThucTe_DP.Caretakers;

namespace DPM235479_NguyenVanThang_Tuan02_Memento_Read_NhanVien_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== CHỨC NĂNG CẬP NHẬT HỒ SƠ NHÂN VIÊN (CÓ UNDO) ===\n");

            // 1. Tạo hồ sơ nhân viên gốc
            NhanVienOriginator nhanVien = new NhanVienOriginator("NV01", "Nguyễn Văn Thắng", "Nhân viên Bán hàng", 8000000);

            // 2. Hệ thống Caretaker quản lý việc backup cho nhân viên này
            QuanLyNhanSuCaretaker hrCaretaker = new QuanLyNhanSuCaretaker(nhanVien);

            // 3. Kịch bản 1: Thăng chức lần 1 (Lưu lại trước khi sửa)
            hrCaretaker.Backup();
            nhanVien.CapNhatThongTin("Nguyễn Văn Thắng", "Trưởng nhóm Bán hàng", 12000000);

            // 4. Kịch bản 2: HR nhập sai dữ liệu lương (Gõ nhầm thành 120 triệu thay vì 15 triệu)
            hrCaretaker.Backup();
            nhanVien.CapNhatThongTin("Nguyễn Văn Thắng", "Quản lý Cửa hàng", 120000000); // LỖI NHẬP SAI DỮ LIỆU

            // Xem lại lịch sử các lần đổi
            hrCaretaker.HienThiLichSu();

            // 5. Phát hiện lỗi nhập sai -> Bấm Undo (Hoàn tác)
            Console.WriteLine(">>> Phát hiện nhập sai lương, tiến hành HOÀN TÁC (Undo)...");
            hrCaretaker.Undo();

            // 6. Hoàn tác thêm lần nữa về trạng thái ban đầu
            Console.WriteLine("\n>>> Trưởng phòng yêu cầu hủy quyết định thăng chức, HOÀN TÁC tiếp...");
            hrCaretaker.Undo();

            Console.ReadLine();
        }
    }
}
