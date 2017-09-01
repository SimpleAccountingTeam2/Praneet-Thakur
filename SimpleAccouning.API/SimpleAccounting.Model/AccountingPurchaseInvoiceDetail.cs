using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model
{
    class AccountingPurchaseInvoiceDetail : AuditableEntity<long>
    {
        public int PurchaseInvoiceDetailId { get; set; }
        public int PurchaseInvoiceId { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }

    }
}
