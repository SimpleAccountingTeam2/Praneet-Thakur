using SimpleAccounting.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Repository
{
    class AccountingCompanyDetailRepository : GenericRepository<AccountingCompanyDetail>, IAccountingCompanyDetailRepository
    {
        public AccountingCompanyDetailRepository(DbContext context): base(context)
        {

        }
        public AccountingCompanyDetail GetById(int id)
        {
            return FindBy(x => x.Id == id).FirstOrDefault();
        }

      
    }
}
