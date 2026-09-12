using System;
using System.Collections.Generic;
using DPM235479_NguyenVanThang_Tuan02_Flyweight_Read_NhanVien_DP.Models;
using DPM235479_NguyenVanThang_Tuan02_Flyweight_Read_NhanVien_DP.Factories;
using DPM235479_NguyenVanThang_Tuan02_Flyweight_Read_NhanVien_DP.Contexts;

namespace DPM235479_NguyenVanThang_Tuan02_Flyweight_Read_NhanVien_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== FLYWEIGHT PATTERN: QUẢN LÝ LÔ HÀNG NÔNG DƯỢC ===\n");

            // 1. Khởi tạo Factory với một vài sản phẩm có sẵn (Intrinsic state)
            var factory = new ProductFlyweightFactory(
                new Product { ProductId = "SP001", ProductName = "Thuốc Trừ Sâu X", Category = "Thuốc trừ sâu", Manufacturer = "Công ty A", Unit = "Chai 500ml" },
                new Product { ProductId = "SP002", ProductName = "Phân Bón Hữu Cơ Y", Category = "Phân bón", Manufacturer = "Công ty B", Unit = "Bao 50kg" },
                new Product { ProductId = "SP003", ProductName = "Thuốc Diệt Cỏ Z", Category = "Thuốc diệt cỏ", Manufacturer = "Công ty C", Unit = "Gói 100g" }
            );

            factory.ListFlyweights();

            // 2. Tạo danh sách các lô hàng (Contexts)
            List<BatchContext> batches = new List<BatchContext>();
            Random rnd = new Random();

            Console.WriteLine("\nĐang tạo 10,000 lô hàng ngẫu nhiên (chỉ tốn RAM cho 3 đối tượng Sản phẩm)...\n");

            for (int i = 0; i < 10000; i++)
            {
                // Chọn ngẫu nhiên 1 sản phẩm
                Product selectedProduct = i % 3 == 0 ? 
                    new Product { ProductId = "SP001", ProductName = "Thuốc Trừ Sâu X", Category = "Thuốc trừ sâu", Manufacturer = "Công ty A", Unit = "Chai 500ml" } :
                    i % 3 == 1 ? 
                    new Product { ProductId = "SP002", ProductName = "Phân Bón Hữu Cơ Y", Category = "Phân bón", Manufacturer = "Công ty B", Unit = "Bao 50kg" } :
                    new Product { ProductId = "SP003", ProductName = "Thuốc Diệt Cỏ Z", Category = "Thuốc diệt cỏ", Manufacturer = "Công ty C", Unit = "Gói 100g" };

                // Get Flyweight
                var flyweight = factory.GetFlyweight(selectedProduct);

                // Dữ liệu lô hàng ngẫu nhiên
                var batchData = new BatchData
                {
                    BatchId = $"LOHANG_{i + 1:D5}",
                    Quantity = rnd.Next(10, 500),
                    ImportDate = DateTime.Now.AddDays(-rnd.Next(1, 100)),
                    ExpiryDate = DateTime.Now.AddDays(rnd.Next(100, 500))
                };

                // Lưu lô hàng
                batches.Add(new BatchContext(flyweight, batchData));
            }

            Console.WriteLine($"\nĐã tạo xong {batches.Count:N0} lô hàng!");
            Console.WriteLine($"Số lượng đối tượng Sản phẩm thực tế trong RAM (Flyweight): {factory.GetFlyweightsCount()}");

            // 3. Hiển thị thông tin 3 lô hàng đầu tiên để kiểm tra
            Console.WriteLine("\n=== Thông tin 3 lô hàng đầu tiên ===");
            for (int i = 0; i < 3; i++)
            {
                batches[i].DisplayInfo();
            }

            Console.WriteLine("Nhấn phím bất kỳ để kết thúc...");
            // Console.ReadKey();
        }
    }
}
