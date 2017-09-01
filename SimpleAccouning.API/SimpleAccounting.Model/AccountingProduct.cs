using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model
{
    class AccountingProduct : AuditableEntity<long>
    {
        public int ProductId { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public int ProductQty { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductDiscount { get; set; }

    }
}
