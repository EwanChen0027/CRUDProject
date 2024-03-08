using CRUDProject.DbModel;

namespace CRUDProject.DbAccess.Interface
{
    public interface IPersonDbAccess
    {
        /// <summary>
        /// 查詢所有地址類型
        /// </summary>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<List<AddressTypeDto>> QueryAllAddressType(int? pageNum, int? pageSize);
        /// <summary>
        /// 查詢所有會員資料
        /// </summary>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<List<PersonInfoDto>> QueryAllPersonInfo(int? pageNum, int? pageSize);
        /// <summary>
        /// 更新手機號碼
        /// </summary>
        /// <param name="Id">會員Id</param>
        /// <param name="newPhone">新號碼</param>
        /// <returns></returns>
        Task<int> UpdatePersonPhoneNumber(int Id, string newPhone);
        
    }
}
