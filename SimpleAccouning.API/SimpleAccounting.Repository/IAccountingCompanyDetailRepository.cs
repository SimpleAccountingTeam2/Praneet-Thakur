using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleAccounting.Model;

namespace SimpleAccounting.Repository
{
  public   interface IAccountingCompanyDetailRepository
    {
        AccountingCompanyDetail GetById(int Id);
    }
}
