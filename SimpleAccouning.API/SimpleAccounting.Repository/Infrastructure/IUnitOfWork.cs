using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Repository.Infrastructure
{
    public interface IUnitOfWork: IDisposable
    {
        void Save();
        void Commit();
        IRepositoryBase<T> GetRepositoryInstance<T>() where T : class, new();
    }

}
