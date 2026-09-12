using System;
using DPM235479_NguyenVanThang_Tuan02_Composite_Read_NhanVien_DP.Components;
using DPM235479_NguyenVanThang_Tuan02_Composite_Read_NhanVien_DP.Composites;
using DPM235479_NguyenVanThang_Tuan02_Composite_Read_NhanVien_DP.Leaves;

namespace DPM235479_NguyenVanThang_Tuan02_Composite_Read_NhanVien_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== HỆ THỐNG QUẢN LÝ BÁN HÀNG NÔNG DƯỢC ===");
            Console.WriteLine("Áp dụng Composite Pattern cho Quản lý Lô Hàng & Tồn Kho\n");

            // 1. Tạo các Lô Hàng (Leaves) nhập vào từ các đợt khác nhau
            InventoryComponent batch1 = new ProductBatch("Lô Thuốc Trừ Sâu A - Đợt 1", 50, new DateTime(2026, 12, 01));
            InventoryComponent batch2 = new ProductBatch("Lô Thuốc Trừ Sâu A - Đợt 2", 100, new DateTime(2027, 05, 15));
            
            InventoryComponent batch3 = new ProductBatch("Lô Phân Bón NPK - Đợt 1", 200, new DateTime(2028, 01, 20));

            // 2. Tạo các Danh mục hàng (Composites)
            ProductCategory categoryThuocTruSau = new ProductCategory("Thuốc Trừ Sâu");
            categoryThuocTruSau.Add(batch1);
            categoryThuocTruSau.Add(batch2);

            ProductCategory categoryPhanBon = new ProductCategory("Phân Bón Nông Nghiệp");
            categoryPhanBon.Add(batch3);

            // 3. Tạo Cây Kho Tổng (Root Composite)
            ProductCategory mainWarehouse = new ProductCategory("KHO TỔNG CÔNG TY AN GIANG");
            mainWarehouse.Add(categoryThuocTruSau);
            mainWarehouse.Add(categoryPhanBon);

            // 4. In thông tin Tồn kho
            Console.WriteLine("--- KIỂM TRA MỘT LÔ HÀNG ĐƠN LẺ ---");
            ClientCheckInventory(batch1);

            Console.WriteLine("--- KIỂM TRA DANH MỤC THUỐC TRỪ SÂU ---");
            ClientCheckInventory(categoryThuocTruSau);

            Console.WriteLine("--- KIỂM TRA TOÀN BỘ KHO TỔNG ---");
            ClientCheckInventory(mainWarehouse);

            Console.WriteLine("Nhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }

        // Client code chỉ cần làm việc với giao diện cơ sở InventoryComponent
        // Client không cần phân biệt đang tính tổng của 1 lô hàng hay cả một nhà kho khổng lồ.
        static void ClientCheckInventory(InventoryComponent component)
        {
            Console.WriteLine(component.GetDescription());
        }
    }
}
