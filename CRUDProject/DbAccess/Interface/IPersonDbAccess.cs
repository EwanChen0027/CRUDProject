using CRUDProject.DbModel;

namespace CRUDProject.DbAccess.Interface
{
    public interface IPersonDbAccess
    {
        /// <summary>
        /// 取得所有會員資料
        /// </summary>
        /// <param name="pageNum"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        Task<List<PersonInfoDto>> QueryAllPersonInfo(int? pageNum, int? pageSize);
    }
}
