using System.Data.Common;
using System.Data;

namespace CRUDProject.Utility
{
    public class UnitOfWork : IUnitOfWork
    {
        IDbConnection _connection = null;
        IDbConnection IUnitOfWork.Connection => _connection;
        public UnitOfWork(IDbConnection connection)
        {
            _connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }

        public void Dispose()
        {
        }

    }
}
