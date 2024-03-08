using CRUDProjectCommon.RequestModel;
using CRUDProjectCommon.ResponseModel;

namespace CRUDProject.BusinessService.Interface
{
    public interface IPersonService
    {
        /// <summary>
        /// 取得所有地址類型
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        Task<GetAllAddressTypeRes> GetAllAddressTypeAsync(GetAllAddressTypeReq req);
        /// <summary>
        /// 取得所有會員資料
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        Task<GetAllPersonInfoRes> GetAllPersonInfoAsync(GetAllPersonInfoReq req);
        /// <summary>
        /// 更新會員資料
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        Task<UpdatePersonInfoRes> UpdatePhoneNumberAsync(UpdatePersonInfoReq req);
        
    }
}
