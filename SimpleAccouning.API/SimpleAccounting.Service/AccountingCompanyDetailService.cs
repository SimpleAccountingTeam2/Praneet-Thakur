using SimpleAccounting.Model;
using SimpleAccounting.Model.DTOS;
using SimpleAccounting.Repository;
using SimpleAccounting.Repository.Infrastructure;
using SimpleAccounting.Service.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Service
{
 public   class AccountingCompanyDetailService : IAccountingCompanyDetailService
    {
        private readonly IAccountingCompanyDetailRepository customerRepository;
        private readonly IUnitOfWork unitOfWork;

        public AccountingCompanyDetailService(IAccountingCompanyDetailRepository customerRepository, IUnitOfWork unitOfWork)
        {
            this.customerRepository = customerRepository;
            this.unitOfWork = unitOfWork;
        }

     public   bool GetAllCustomers(AccountingCompanyDetailDtos ACOMPANY)
        {
            SimpleAccountingContext context = new SimpleAccountingContext();
            try
            {
                AccountingCompanyDetail companyDetails = new AccountingCompanyDetail()
                {
                    CompanyId = ACOMPANY.CompanyId,
                    CompanyName= ACOMPANY.CompanyName,
                    CompanyEmail= ACOMPANY.CompanyEmail,
                    CompanyLogo= ACOMPANY.CompanyLogo,
                    CompanyRegno= ACOMPANY.CompanyRegno,
                    CompanyTelephone= ACOMPANY.CompanyTelephone,
                    BilltoCountry= ACOMPANY.BilltoCountry,
                    BilltoCity= ACOMPANY.BilltoCity,
                    BilltoLine1= ACOMPANY.BilltoLine1,
                    BilltoLine2= ACOMPANY.BilltoLine2,
                    BilltoPostalCode= ACOMPANY.BilltoPostalCode,
                    BilltoState= ACOMPANY.BilltoState,
                    FinancialYrStartDate= ACOMPANY.FinancialYrStartDate,
                    ShiptoCity= ACOMPANY.ShiptoCity,
                    ShiptoCountry= ACOMPANY.ShiptoCountry,
                    ShiptoLine1= ACOMPANY.ShiptoLine1,
                    ShiptoLine2= ACOMPANY.ShiptoLine2,
                    ShiptoPostalCode= ACOMPANY.ShiptoPostalCode,
                    ShiptoState= ACOMPANY.ShiptoState,
                    SoftwareSerialNo= ACOMPANY.SoftwareSerialNo,
                   


                };
                unitOfWork.GetRepositoryInstance<AccountingCompanyDetail>().Add(companyDetails);
                unitOfWork.Save();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return true;

        }
        
        

        public void AddUser(AccountingCompanyDetailDtos person)
        {
            customerRepository.Add(person);
            unitOfWork.Commit();
        }

        public void UpdateDetails(AccountingCompanyDetailDtos company)
        {
            customerRepository.Update(company);
            unitOfWork.Commit();
        }
    }
}
