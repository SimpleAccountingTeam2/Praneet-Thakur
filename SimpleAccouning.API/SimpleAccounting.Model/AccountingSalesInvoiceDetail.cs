using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model
{
    class AccountingSalesInvoiceDetail :AuditableEntity<long>
    {
        public int SalesInvoiceDetailId { get; set; }
        public int SalesInvoiceId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
    }
}
