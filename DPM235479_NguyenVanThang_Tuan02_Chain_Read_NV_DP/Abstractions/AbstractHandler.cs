using DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Interfaces;
using DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Chain_Read_NV_DP.Abstractions
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
            
        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }

        public virtual string Handle(RequestContext request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            return null;
        }
    }
}
