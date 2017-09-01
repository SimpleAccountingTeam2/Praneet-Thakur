﻿
using SimpleAccounting.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Repository
{
   public interface IAccountingCustomerRepository : IGenericRepository<AccountingCustomer>
    {
        AccountingCustomer GetById(int id);
    }

}
