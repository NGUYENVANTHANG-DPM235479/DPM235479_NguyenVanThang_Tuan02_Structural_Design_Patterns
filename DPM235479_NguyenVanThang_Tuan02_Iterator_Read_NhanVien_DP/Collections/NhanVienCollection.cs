using DPM235479_NguyenVanThang_Tuan02_Iterator_Read_NhanVien_DP.Iterators;
using DPM235479_NguyenVanThang_Tuan02_Iterator_Read_NhanVien_DP.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Iterator_Read_NhanVien_DP.Collections
{
    public class NhanVienCollection : Abstractions.IteratorAggregate
    {
        List<NhanVien> _collection = new List<NhanVien>();
        bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<NhanVien> GetItems()
        {
            return _collection;
        }

        public void AddItem(NhanVien item)
        {
            this._collection.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new NhanVienIterator(this, _direction);
        }
    }
}
