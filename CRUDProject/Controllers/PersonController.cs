using CRUDProject.BusinessService.Interface;
using CRUDProjectCommon.RequestModel;
using CRUDProjectCommon.ResponseModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUDProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        //服務注入與建構
        private readonly IPersonService personService;

        public PersonController(IPersonService personService)
        {
            this.personService = personService;
        }

        /// <summary>
        /// 取得地址類型清單
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpGet("AddressType")]
        public async Task<GetAllAddressTypeRes> GetAllAddressType([FromQuery] GetAllAddressTypeReq req)
        {
            var res = await personService.GetAllAddressTypeAsync(req);
            return res;
        }

        /// <summary>
        /// 取得所有人員聯絡資料
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<GetAllPersonInfoRes> GetAllPersonInfo([FromBody] GetAllPersonInfoReq req)
        {
            var res = await personService.GetAllPersonInfoAsync(req);
            return res;
        }

        /// <summary>
        /// 修改手機號碼
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [HttpPut("PhoneNumber")]
        public async Task<UpdatePersonInfoRes> UpdatePhoneNumber([FromBody] UpdatePersonInfoReq req)
        {
            var res = await personService.UpdatePhoneNumberAsync(req);
            return res;
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
