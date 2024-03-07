using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Data;
using System.Data.SqlClient;

namespace CRUDProject.Utility.Factory
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        public UnitOfWorkFactory()
        {

        }

        public IUnitOfWork Create(string connectionName)
        {
            if (string.IsNullOrEmpty(connectionName))
            {
                //todo: error log
            }
            IDbConnection connection = new SqlConnection(connectionName);

            return new UnitOfWork(connection);
        }
    }
}
