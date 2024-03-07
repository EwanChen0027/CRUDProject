using CRUDProjectCommon.RequestModel;
using CRUDProjectCommon.ResponseModel;

namespace CRUDProject.BusinessService.Interface
{
    public interface IPersonService
    {
        Task<GetAllPersonInfoRes> GetAllPersonInfoAsync(GetAllPersonInfoReq req);
    }
}
