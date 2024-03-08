using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProjectCommon.RequestModel
{
    public class GetAllAddressTypeReq : BaseReq
    {
        public override int? PageSize { get; set; }
        public override int? PageNum { get; set; }
    }
}
