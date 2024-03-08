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

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
