using System;

namespace DPM235479_NguyenVanThang_Tuan02_Composite_Read_NhanVien_DP.Components
{
    /// <summary>
    /// Component: Lớp cơ sở đại diện cho một phần tử trong kho hàng.
    /// Có thể là một Lô hàng (Leaf) hoặc một Danh mục/Kho chứa (Composite).
    /// </summary>
    public abstract class InventoryComponent
    {
        public string Name { get; protected set; }

        public InventoryComponent(string name)
        {
            Name = name;
        }

        // Hành động chính: Tính toán tổng số lượng tồn kho
        public abstract int CalculateTotalQuantity();
        
        // Thêm thông tin mô tả để hiển thị
        public abstract string GetDescription(int indentLevel = 0);

        // Các thao tác quản lý con (mặc định ném ngoại lệ vì Leaf không thể có con)
        public virtual void Add(InventoryComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(InventoryComponent component)
        {
            throw new NotImplementedException();
        }

        // Kiểm tra xem phần tử có thể chứa các phần tử khác không
        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
