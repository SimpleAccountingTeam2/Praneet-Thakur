using SimpleAccounting.Model;
using SimpleAccounting.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service
{
   public interface IAccountingCompanyDetailService: IEntityService<AccountingCompanyDetail>
    {
     

        AccountingCompanyDetail GetById(int Id);
    }
}
