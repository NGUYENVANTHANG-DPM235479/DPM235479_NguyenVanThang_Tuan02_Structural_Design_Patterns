using DPM235479_NguyenVanThang_Tuan02_Visitor_Read_NhanVien_DP.Components;
using DPM235479_NguyenVanThang_Tuan02_Visitor_Read_NhanVien_DP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Visitor_Read_NhanVien_DP.Visitors
{
    public class BaoCaoTaiChinhVisitor : IBaoCaoVisitor
    {
        public decimal TongTienTonKho { get; private set; } = 0;
        public decimal TongChiPhiDichVuVaVanChuyen { get; private set; } = 0;

        // Xử lý báo cáo khi ghé thăm mặt hàng Phân Bón
        public void VisitPhanBon(PhanBon phanBon)
        {
            decimal giaTriLo = phanBon.GiaNhap * phanBon.SoLuongTon;
            TongTienTonKho += giaTriLo;
            TongChiPhiDichVuVaVanChuyen += phanBon.ChiPhiVanChuyenRieng;

            Console.WriteLine($"[Báo cáo Phân Bón] {phanBon.TenSanPham} | Tồn: {phanBon.SoLuongTon} | Giá trị: {giaTriLo:N0} VNĐ | Phí ship: {phanBon.ChiPhiVanChuyenRieng:N0} VNĐ");
        }

        // Xử lý báo cáo khi ghé thăm mặt hàng Thuốc Trừ Sâu
        public void VisitThuocTruSau(ThuocTruSau thuocTruSau)
        {
            decimal giaTriLo = thuocTruSau.GiaNhap * thuocTruSau.SoLuongTon;
            TongTienTonKho += giaTriLo;
            // Tổng hợp cả chi phí vận chuyển/dịch vụ phụ theo yêu cầu đồ án[cite: 2]
            decimal chiPhiPhu = thuocTruSau.PhiKiemDinhDocHai;
            TongChiPhiDichVuVaVanChuyen += chiPhiPhu;

            Console.WriteLine($"[Báo cáo Thuốc Sâu] {thuocTruSau.TenSanPham} | Tồn: {thuocTruSau.SoLuongTon} | Giá trị: {giaTriLo:N0} VNĐ | Phí dịch vụ phụ: {chiPhiPhu:N0} VNĐ");
        }
    }
}
