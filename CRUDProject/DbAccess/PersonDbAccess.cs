﻿using CRUDProject.DbAccess.Interface;
using CRUDProject.DbModel;
using CRUDProject.Utility.Factory;
using CRUDProject.Utility.Models;
using Dapper;
using Microsoft.Extensions.Options;
using System.Data;

namespace CRUDProject.DbAccess
{
    public class PersonDbAccess : IPersonDbAccess
    {
        private readonly IUnitOfWorkFactory unitOfWorkFactory;
        private readonly ConnectionStrings dbconnection;
        public PersonDbAccess(IUnitOfWorkFactory unitOfWorkFactory, IOptions<ConnectionStrings> connection) 
        {
            this.unitOfWorkFactory = unitOfWorkFactory;
            this.dbconnection = connection.Value;
        }

        public async Task<List<PersonInfoDto>> QueryAllPersonInfo(int? pageSize, int? pageNum = 20)
        {
            using (var unitOfWork = unitOfWorkFactory.Create(dbconnection.DbAdventureWorks2019))
            {
                var param = new DynamicParameters();
                
                //有帶參數就做分頁
                var sqlpage = "";
                if (pageNum is not null )
                {
                    sqlpage = @" OFFSET (@pageNum - 1)*@pageSize ROWS 
                                 FETCH NEXT @pageSize ROWS ONLY
                               ";
                    param.Add("@pageNum", pageNum, DbType.Int32, ParameterDirection.Input);
                    param.Add("@pageSize", pageSize, DbType.Int32, ParameterDirection.Input);
                }

                var sql = $@"
                            SELECT 
                            	PP.BusinessEntityID
                            	,PP.FirstName
                            	,PP.LastName
                            	,PE.EmailAddress
                            	,PH.PhoneNumber
                            FROM Person.Person AS PP WITH(NOLOCK)
                            LEFT JOIN Person.EmailAddress AS PE WITH(NOLOCK) ON PP.BusinessEntityID = PE.BusinessEntityID
                            LEFT JOIN Person.PersonPhone AS PH WITH(NOLOCK) ON PP.BusinessEntityID = PH.BusinessEntityID
                            {sqlpage}
                            ";

                var res = await unitOfWork.Connection.QueryAsync<PersonInfoDto>(sql, param);
                return res.ToList();

            }
        }
    }
}