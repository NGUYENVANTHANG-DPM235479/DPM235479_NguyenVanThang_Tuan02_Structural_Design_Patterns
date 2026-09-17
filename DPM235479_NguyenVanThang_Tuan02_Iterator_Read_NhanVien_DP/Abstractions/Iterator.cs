using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Iterator_Read_NhanVien_DP.Abstractions
{
    public abstract class Iterator : IEnumerator
    {
        // Fix lỗi hiển thị của IEnumerator
        object IEnumerator.Current
        {
            get { return Current(); }
        }

        public abstract int Key();
        public abstract object Current();
        public abstract bool MoveNext();
        public abstract void Reset();
    }
}
