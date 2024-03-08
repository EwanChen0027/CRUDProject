using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProjectCommon.RequestModel
{
    public class UpdatePersonInfoReq
    {
        //todo: 資料檢核

        /// <summary>
        /// 流水號
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 新的email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 新的電話號碼
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
