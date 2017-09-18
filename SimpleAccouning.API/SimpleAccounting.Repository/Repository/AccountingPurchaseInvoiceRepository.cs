﻿using SimpleAccounting.Model;
using SimpleAccounting.Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Repository
{
    class AccountingPurchaseInvoiceRepository:RepositoryBase<AccountingPurchaseInvoice>, IAccountingPurchaseInvoiceRepository
    {
        public AccountingPurchaseInvoiceRepository(IDatabaseFactory databaseFactory):base(databaseFactory)
        {

        }
    }
}
