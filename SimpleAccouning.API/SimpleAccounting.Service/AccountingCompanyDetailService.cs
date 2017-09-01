using SimpleAccounting.Model;
using SimpleAccounting.Repository;
using SimpleAccounting.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service
{
    class AccountingCompanyDetailService : EntityService<AccountingCompanyDetail>, IAccountingCompanyDetailService

    {
        IUnitOfWork _unitOfWork;

        IAccountingCompanyDetailRepository _countryRepository;



        public AccountingCompanyDetailService(IUnitOfWork unitOfWork,IAccountingCompanyDetailRepository countryRepository)
            : base(unitOfWork, countryRepository)
        {
            _unitOfWork = unitOfWork;

            _countryRepository = countryRepository;
        }


        public AccountingCompanyDetail GetById(int Id)
        {
            return _countryRepository.GetById(Id);
        }
    }
}
