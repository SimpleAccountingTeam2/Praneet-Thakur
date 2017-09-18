using FinalAccounting.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAccounting.Repository
{
 public   class AccountingCompanyDetailContext : System.Data.Entity.DbContext

    {
        public AccountingCompanyDetailContext():base("name=MyConnectionString")
        {
                
        }
        public DbSet<AccountingCompanyDetail> AccountingCompanyDetails { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }
    }
}
