using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAccounting.Repository.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private AccountingCompanyDetailContext dataContext;
        public AccountingCompanyDetailContext Get()
        {
            return dataContext ?? (dataContext = new AccountingCompanyDetailContext());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
