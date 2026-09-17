using DPM235479_NguyenVanThang_Tuan02_Iterator_Read_NhanVien_DP.Abstractions;
using DPM235479_NguyenVanThang_Tuan02_Iterator_Read_NhanVien_DP.Collections;

namespace DPM235479_NguyenVanThang_Tuan02_Iterator_Read_NhanVien_DP.Iterators
{
    public class NhanVienIterator : Iterator
    {
        private NhanVienCollection _collection;
        private int _position = -1;
        private bool _reverse = false;

        public NhanVienIterator(NhanVienCollection collection, bool reverse = false)
        {
            this._collection = collection;
            this._reverse = reverse;

            if (reverse)
            {
                this._position = collection.GetItems().Count;
            }
        }

        public override object Current()
        {
            return this._collection.GetItems()[_position];
        }

        public override int Key()
        {
            return this._position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = this._position + (this._reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this._collection.GetItems().Count)
            {
                this._position = updatedPosition;
                return true;
            }
            return false;
        }

        public override void Reset()
        {
            this._position = this._reverse ? this._collection.GetItems().Count - 1 : 0;
        }
    }
}