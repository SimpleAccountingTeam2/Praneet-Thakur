using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAccounting.Repository.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        AccountingCompanyDetailContext Get();
    }
}
