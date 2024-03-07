using System;
using System.Data;

namespace CRUDProject.Utility
{
    public interface IUnitOfWork : IDisposable
    {

        IDbConnection Connection { get; }

    }
}
