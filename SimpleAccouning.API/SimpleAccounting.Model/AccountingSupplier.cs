using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model
{
  public  class AccountingSupplier : AuditableEntity<long>
    {
        public int SalesProductId { get; set; }
        public int SalesProductCode { get; set; }
        public string SalesProductName { get; set; }
        public int SalesProductQty { get; set; }
        public decimal SalesProductPrice { get; set; }
        public decimal SalesProductDiscount { get; set; }
    }
}
