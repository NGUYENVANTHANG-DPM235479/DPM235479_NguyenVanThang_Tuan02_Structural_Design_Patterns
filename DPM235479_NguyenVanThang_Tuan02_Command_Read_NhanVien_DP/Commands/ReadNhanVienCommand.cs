using DPM235479_NguyenVanThang_Tuan02_Command_Read_NhanVien_DP.Interfaces;
using DPM235479_NguyenVanThang_Tuan02_Command_Read_NhanVien_DP.Receivers;

namespace DPM235479_NguyenVanThang_Tuan02_Command_Read_NhanVien_DP.Commands
{
    public class ReadNhanVienCommand : ICommand
    {
        private NhanVienReadReceiver _receiver;
        private int _maNhanVienCanDoc;

        // Constructor nhận vào Receiver và ID nhân viên cần truy vấn
        public ReadNhanVienCommand(NhanVienReadReceiver receiver, int maNV)
        {
            _receiver = receiver;
            _maNhanVienCanDoc = maNV;
        }

        // Thực thi việc chuyển tiếp yêu cầu đến Receiver
        public void Execute()
        {
            _receiver.DocThongTinNhanVien(_maNhanVienCanDoc);
        }
    }
}