using AutoMapper;
using SimpleAccouning.API.Dtos;
using SimpleAccounting.Model;
using SimpleAccounting.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleAccouning.API.Controllers
{
    public class AccountingCompanyDetailController : ApiController
    {
        IAccountingCompanyDetailService _AccountingCompanyDetailService;

        public AccountingCompanyDetailController()
        {

        }
        public AccountingCompanyDetailController(IAccountingCompanyDetailService AccountingCompanyDetailService)
        {
            _AccountingCompanyDetailService = AccountingCompanyDetailService;
        }
        [HttpGet]
        public IHttpActionResult GetCompany(string query = null)
        {
            var customersQuery = _AccountingCompanyDetailService.GetAll();


            if (!String.IsNullOrWhiteSpace(query))
                customersQuery = customersQuery.Where(c => c.CompanyName.Contains(query));

            var customerDtos = customersQuery
                .ToList()
                .Select(Mapper.Map<AccountingCompanyDetail, AccountingCompanyDetailDtos>);

            return Ok(customerDtos);
        }


    }
}
