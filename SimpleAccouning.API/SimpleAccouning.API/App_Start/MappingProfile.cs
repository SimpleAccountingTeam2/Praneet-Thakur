using AutoMapper;
using SimpleAccounting.Model;
using SimpleAccounting.Model.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAccouning.API.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<AccountingCompanyDetail, AccountingCompanyDetailDtos>();
            Mapper.CreateMap<AccountingCompanyDetailDtos, AccountingCompanyDetail>(); 
        }
    }
}