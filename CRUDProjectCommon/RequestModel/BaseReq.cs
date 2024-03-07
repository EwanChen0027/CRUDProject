using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProjectCommon.RequestModel
{
    public abstract class BaseReq
    {
        /// <summary>
        /// 頁數
        /// </summary>
        public abstract int? PageNum { get; set; }
        /// <summary>
        /// 分頁大小
        /// </summary>
        public abstract int? PageSize { get; set; }
    }
}
