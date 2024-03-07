using CRUDProject.BusinessService.Interface;
using CRUDProject.DbAccess.Interface;
using CRUDProjectCommon.RequestModel;
using CRUDProjectCommon.ResponseModel;

namespace CRUDProject.BusinessService
{
    public class PersonService : IPersonService
    {
        private readonly IPersonDbAccess personDbAccess;
        public PersonService(IPersonDbAccess personDbAccess)
        {
            this.personDbAccess = personDbAccess;
        }

        public async Task<GetAllPersonInfoRes> GetAllPersonInfoAsync(GetAllPersonInfoReq req)
        {
            var query = await personDbAccess.QueryAllPersonInfo(req.PageNum, req.PageSize);
            List<PersonInfo> infoList = new List<PersonInfo>();
            foreach (var item in query)
            {
                PersonInfo info = new PersonInfo
                {
                    Id = item.BusinessEntityID,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.EmailAddress,
                    PhoneNumber = item.PhoneNumber,
                };
                infoList.Add(info);
            }
            return new GetAllPersonInfoRes { personInfoList = infoList };
        }
    }
}
