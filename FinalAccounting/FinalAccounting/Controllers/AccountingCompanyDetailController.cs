using FinalAccounting.Model;
using FinalAccounting.Repository;
using FinalAccounting.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FinalAccounting.Controllers
{
    public class AccountingCompanyDetailController : ApiController
    {
        public AccountingCompanyDetailContext _context;
        private readonly IAccountingCompanyDetailService customerRepository;
        public AccountingCompanyDetailController()
        {
            _context = new AccountingCompanyDetailContext();
        }
        public AccountingCompanyDetailController(IAccountingCompanyDetailService userRepo)
        {
            this.customerRepository = userRepo;
        }

        [HttpGet]
        public IEnumerable<AccountingCompanyDetail> Get()
        {
            try
            {
                return customerRepository.GetAllCustomers();
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPost]

        public void post(AccountingCompanyDetail person)
        {
            customerRepository.AddUser(person);
        }

    }
}

