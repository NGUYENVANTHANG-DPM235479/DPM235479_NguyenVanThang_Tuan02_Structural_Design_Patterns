using DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Interfaces
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        string Handle(RequestContext request);
    }
}
