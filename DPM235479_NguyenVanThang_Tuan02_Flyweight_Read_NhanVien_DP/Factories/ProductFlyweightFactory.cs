using System;
using System.Collections.Generic;
using System.Linq;
using DPM235479_NguyenVanThang_Tuan02_Flyweight_Read_NhanVien_DP.Models;
using DPM235479_NguyenVanThang_Tuan02_Flyweight_Read_NhanVien_DP.Flyweights;

namespace DPM235479_NguyenVanThang_Tuan02_Flyweight_Read_NhanVien_DP.Factories
{
    // Lớp Factory để khởi tạo và quản lý các đối tượng Flyweight
    // Đảm bảo Flyweight được chia sẻ một cách chính xác
    public class ProductFlyweightFactory
    {
        // Sử dụng Dictionary để lưu trữ cache các Flyweight
        // Key là một chuỗi băm dựa trên thông tin nhận dạng của Sản phẩm
        private Dictionary<string, ProductFlyweight> _flyweights = new Dictionary<string, ProductFlyweight>();

        public ProductFlyweightFactory(params Product[] initialProducts)
        {
            foreach (var product in initialProducts)
            {
                _flyweights.Add(GetKey(product), new ProductFlyweight(product));
            }
        }

        // Tạo ra khóa duy nhất (unique key) từ thuộc tính của Sản phẩm
        // Ở đây chúng ta sẽ dùng ProductId kết hợp các thông số khác làm key
        private string GetKey(Product key)
        {
            List<string> elements = new List<string>
            {
                key.ProductId,
                key.ProductName,
                key.Category,
                key.Manufacturer
            };
            
            // Xóa phần tử rỗng và nối lại
            return string.Join("_", elements.Where(e => !string.IsNullOrEmpty(e)));
        }

        // Trả về một Flyweight đã có hoặc tạo mới nếu chưa tồn tại
        public ProductFlyweight GetFlyweight(Product sharedState)
        {
            string key = GetKey(sharedState);

            if (!_flyweights.ContainsKey(key))
            {
                Console.WriteLine($"[Factory] Không tìm thấy Sản phẩm '{sharedState.ProductName}' trong bộ nhớ tạm. Đang tạo đối tượng Flyweight mới.");
                _flyweights.Add(key, new ProductFlyweight(sharedState));
            }
            else
            {
                Console.WriteLine($"[Factory] Tái sử dụng đối tượng Sản phẩm '{sharedState.ProductName}' từ bộ nhớ tạm.");
            }

            return _flyweights[key];
        }

        public int GetFlyweightsCount()
        {
            return _flyweights.Count;
        }

        public void ListFlyweights()
        {
            Console.WriteLine($"\n[Factory] Đang quản lý {_flyweights.Count} loại Sản phẩm trong bộ nhớ:");
            foreach (var key in _flyweights.Keys)
            {
                Console.WriteLine($" - {key}");
            }
        }
    }
}
