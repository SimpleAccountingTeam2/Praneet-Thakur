using SimpleAccounting.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Repository
{
    class AccountingCustomerRepository : GenericRepository<AccountingCustomer>, IAccountingCustomerRepository
    {
        public AccountingCustomerRepository(DbContext context)
            : base(context)
        {

        }

        public override IEnumerable<AccountingCustomer> GetAll()
        {
            //return _entities.Set<AccountingCustomer>().Include(x => x.CustomerBilltoCountry).AsEnumerable();
            return _entities.Set<AccountingCustomer>().AsEnumerable();
        }



        public AccountingCustomer GetById(int id)
        {
            //return _dbset.Include(x => x.CustomerBilltoCountry).Where(x => x.CustomerId == id).FirstOrDefault();
            return _dbset.Where(x => x.CustomerId == id).FirstOrDefault();
        }
    }
}
