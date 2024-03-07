using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProjectCommon.ResponseModel
{
    public class GetAllPersonInfoRes
    {
        public List<PersonInfo> personInfoList { get; set; }
    }

    public class PersonInfo
    {
        /// <summary>
        /// 流水號
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 名字
        /// </summary>
        public string? FirstName { get; set; }
        /// <summary>
        /// 姓氏
        /// </summary>
        public string? LastName { get; set; }
        /// <summary>
        /// 電郵
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// 電話
        /// </summary>
        public string? PhoneNumber { get; set; }
    }
}
