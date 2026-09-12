using System.Collections.Generic;
using DPM235479_NguyenVanThang_Tuan02_Composite_Read_NhanVien_DP.Components;

namespace DPM235479_NguyenVanThang_Tuan02_Composite_Read_NhanVien_DP.Composites
{
    /// <summary>
    /// Composite: Đại diện cho một Danh mục hàng hoặc một Kho hàng phức tạp.
    /// Nó có thể chứa các Lô hàng (Leaves) hoặc chứa các Danh mục con khác (Composites).
    /// </summary>
    public class ProductCategory : InventoryComponent
    {
        protected List<InventoryComponent> _children = new List<InventoryComponent>();

        public ProductCategory(string name) : base(name)
        {
        }

        public override void Add(InventoryComponent component)
        {
            this._children.Add(component);
        }

        public override void Remove(InventoryComponent component)
        {
            this._children.Remove(component);
        }

        // Composite ủy quyền công việc tính tổng số lượng cho các thành phần con của nó.
        // Nó đệ quy qua toàn bộ cây để lấy tổng.
        public override int CalculateTotalQuantity()
        {
            int total = 0;
            foreach (InventoryComponent component in this._children)
            {
                total += component.CalculateTotalQuantity();
            }
            return total;
        }

        public override string GetDescription(int indentLevel = 0)
        {
            string indent = new string(' ', indentLevel * 4);
            string result = $"{indent}[+] Danh Mục / Kho: {Name} (Tổng tồn kho: {CalculateTotalQuantity()})\n";

            foreach (InventoryComponent component in this._children)
            {
                result += component.GetDescription(indentLevel + 1);
            }
            return result;
        }
    }
}
