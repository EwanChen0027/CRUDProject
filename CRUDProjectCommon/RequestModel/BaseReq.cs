using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProjectCommon.RequestModel
{
    public abstract class BaseReq
    {
        public abstract int? PageNum { get; set; }
        public abstract int? PageSize { get; set; }
    }
}
