using DPM235479_NguyenVanThang_Tuan02_State_DP.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_State_DP.Abstractions
{
    // The base State class declares methods that all Concrete State should
    // implement and also provides a backreference to the Context object.
    public abstract class State
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            this._context = context;
        }

        public abstract void Handle1();

        public abstract void Handle2();
    }
}
