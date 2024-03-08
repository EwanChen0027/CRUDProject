using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDProjectCommon.ResponseModel
{
    public class GetAllAddressTypeRes
    {
        public List<AddressType> AddressTypeList { get; set; }
    }
    public class AddressType
    {
        /// <summary>
        /// 流水號
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 地址類型(住家,辦公室....)
        /// </summary>
        public string Name { get; set; }
    }
}
