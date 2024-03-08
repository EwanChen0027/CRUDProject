using CRUDProject.BusinessService.Interface;
using CRUDProject.DbAccess.Interface;
using CRUDProjectCommon.RequestModel;
using CRUDProjectCommon.ResponseModel;
using Microsoft.AspNetCore.Server.HttpSys;
using System.Net.Sockets;

namespace CRUDProject.BusinessService
{
    public class PersonService : IPersonService
    {
        private readonly IPersonDbAccess personDbAccess;
        public PersonService(IPersonDbAccess personDbAccess)
        {
            this.personDbAccess = personDbAccess;
        }

        public async Task<GetAllAddressTypeRes> GetAllAddressTypeAsync(GetAllAddressTypeReq req)
        {
            var query = await personDbAccess.QueryAllAddressType(req.PageNum, req.PageSize);
            List<AddressType> typeList = new List<AddressType>();
            
            //mapping
            //todo : auto map
            foreach (var item in query)
            {
                AddressType type = new AddressType
                {
                    Id = item.AddressTypeID,
                    Name = item.Name
                };
                typeList.Add(type);
            }
            return new GetAllAddressTypeRes { AddressTypeList = typeList };
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

        public async Task<UpdatePersonInfoRes> UpdatePhoneNumberAsync(UpdatePersonInfoReq req)
        {
            req.PhoneNumber = req.PhoneNumber.Trim();
            //檢核電話格式
            if (!CheckPhoneNumber(req.PhoneNumber))
            {
                return new UpdatePersonInfoRes { IsSuccess = false };
            }
            var isSuccess = await personDbAccess.UpdatePersonPhoneNumber(req.Id, req.PhoneNumber);

            return new UpdatePersonInfoRes { IsSuccess = true };
        }

        //todo : 檢核可以抽離成策略模式
        //單元測試
        private bool CheckPhoneNumber(string phone)
        {
            if (phone.Length != 12)
            {
                return false;
            }
            return true;
        }
    }
}
