using System;
using DPM235479_NguyenVanThang_Tuan02_Composite_Read_NhanVien_DP.Components;

namespace DPM235479_NguyenVanThang_Tuan02_Composite_Read_NhanVien_DP.Leaves
{
    /// <summary>
    /// Leaf: Đại diện cho một Lô Hàng cụ thể trong kho.
    /// Lô hàng là đối tượng ở cuối cấu trúc cây, không chứa phần tử con nào.
    /// </summary>
    public class ProductBatch : InventoryComponent
    {
        private int _quantity;
        private DateTime _expirationDate;

        public ProductBatch(string name, int quantity, DateTime expirationDate) : base(name)
        {
            _quantity = quantity;
            _expirationDate = expirationDate;
        }

        // Với Leaf, tổng số lượng chính là số lượng của lô hàng này
        public override int CalculateTotalQuantity()
        {
            return _quantity;
        }

        public override string GetDescription(int indentLevel = 0)
        {
            string indent = new string(' ', indentLevel * 4);
            return $"{indent}- Lô hàng: {Name} | Số lượng: {_quantity} | HSD: {_expirationDate:dd/MM/yyyy}\n";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
