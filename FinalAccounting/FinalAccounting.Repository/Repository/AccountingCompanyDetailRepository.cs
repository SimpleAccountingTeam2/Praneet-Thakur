using FinalAccounting.Model;
using FinalAccounting.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAccounting.Repository.Repository
{
    class AccountingCompanyDetailRepository : RepositoryBase<AccountingCompanyDetail>, IAccountingCompanyDetailRepository
    {
        public AccountingCompanyDetailRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
    public interface IAccountingCompanyDetailRepository : IRepositoryBase<AccountingCompanyDetail>
    {

    }
}
