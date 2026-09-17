using DPM235479_NguyenVanThang_Tuan02_Mediator_Read_NhanVien_DP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235479_NguyenVanThang_Tuan02_Mediator_Read_NhanVien_DP.Components
{
    public abstract class NhanVienBase
    {
        protected IMediator _mediator;
        public string TenNV { get; set; }

        public NhanVienBase(string tenNV, IMediator mediator = null)
        {
            TenNV = tenNV;
            _mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
