using FinalAccounting.Model;
using FinalAccounting.Repository.Infrastructure;
using FinalAccounting.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAccounting.Service
{
    class AccountingCompanyDetailService : IAccountingCompanyDetailService
    {
        private readonly IAccountingCompanyDetailRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;

        public AccountingCompanyDetailService(IAccountingCompanyDetailRepository customerRepository, IUnitOfWork unitOfWork)
        {
            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<AccountingCompanyDetail> GetAllCustomers()
        {
            return customerRepository.GetAll();
        }

        public void AddUser(AccountingCompanyDetail person)
        {
            customerRepository.Add(person);
            unitOfWork.Commit();
        }

    }

    public interface IAccountingCompanyDetailService
    {
        IEnumerable<AccountingCompanyDetail> GetAllCustomers();
        void AddUser(AccountingCompanyDetail person);
    }
}
