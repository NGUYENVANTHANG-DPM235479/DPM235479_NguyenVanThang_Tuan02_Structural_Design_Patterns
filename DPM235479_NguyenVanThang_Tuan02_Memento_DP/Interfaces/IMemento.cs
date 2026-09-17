using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Memento_DP.Interfaces
{
    // such as creation date or name. However, it doesn't expose the Originator's state.
    public interface IMemento
    {
        string GetName();
        string GetState();
        DateTime GetDate();
    }
}
