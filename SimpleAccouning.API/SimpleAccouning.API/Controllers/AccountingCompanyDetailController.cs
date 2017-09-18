using AutoMapper;
using SimpleAccounting.Model.DTOS;
using SimpleAccounting.Model;
using SimpleAccounting.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Data;

namespace SimpleAccouning.API.Controllers
{
    [EnableCors(origins:"http://localhost:4200",headers:"*",methods:"*")]
    public class AccountingCompanyDetailController : ApiController
    {
        private readonly IAccountingCompanyDetailService customerRepository;
       
        public AccountingCompanyDetailController(IAccountingCompanyDetailService userRepo)
        {
            this.customerRepository = userRepo;
        }

        /// <summary>
        /// for getting all company details
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public IHttpActionResult GetAllCustomers(AccountingCompanyDetailDtos ACOMPANY)
        {
            try
            {
                return customerRepository.GetAllCustomers(ACOMPANY).G(Mapper.Map<AccountingCompanyDetail, AccountingCompanyDetailDtos>);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// for adding new company details
        /// </summary>
        ///// <param name="person"></param>
        //[HttpPost]

        //public void post(AccountingCompanyDetail person)
        //{
        //    customerRepository.AddUser(person);
        //}


        /// <summary>
        /// To get single company details
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = customerRepository..SingleOrDefault(c => c.CompanyId == id);

            if (customer == null)
                return NotFound();

            return Ok(Mapper.Map<AccountingCompanyDetail, AccountingCompanyDetailDtos>(customer));
        }

        [HttpPost]
        public IHttpActionResult CreateCustomer(AccountingCompanyDetailDtos customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = Mapper.Map<AccountingCompanyDetailDtos, AccountingCompanyDetail>(customerDto);
            customerRepository.AddUser(customer);
       //   customerRepository.SaveChanges();

            customerDto.CompanyId = customer.Id;
            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto);
        }


        // PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, AccountingCompanyDetailDtos customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customerInDb = customerRepository.GetAllCustomers().SingleOrDefault(c => c.CompanyId == id);

            if (customerInDb == null)
                return NotFound();

            Mapper.Map(customerDto, customerInDb);

     //       customerRepository.SaveChanges();

            return Ok();
        }

        // DELETE /api/customers/1
      //  [HttpDelete]
      //  public IHttpActionResult DeleteCustomer(int id)
      //  {
      //      var customerInDb = customerRepository.GetAllCustomers().SingleOrDefault(c => c.CompanyId == id);

      //      if (customerInDb == null)
      //          return NotFound();

      //      customerRepository.GetAllCustomers().
      ////      customerRepository.GetAllCustomers();

      //      return Ok();
      //  }

    }

}

