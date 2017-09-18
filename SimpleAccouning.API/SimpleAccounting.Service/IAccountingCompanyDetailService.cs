using SimpleAccounting.Model;
using SimpleAccounting.Model.DTOS;
using SimpleAccounting.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service
{
    public interface IAccountingCompanyDetailService
    {
 bool GetAllCustomers(AccountingCompanyDetailDtos ACOMPANY);
        bool AddUser(AccountingCompanyDetailDtos person);

        bool UpdateDetails(AccountingCompanyDetailDtos company);


    }
}
