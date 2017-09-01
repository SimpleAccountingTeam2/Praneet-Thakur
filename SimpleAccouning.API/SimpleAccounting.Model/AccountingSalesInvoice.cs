using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model
{
   public class AccountingSalesInvoice : AuditableEntity<long>
    {
        public int SalesInvoiceId { get; set; }
        public int SalesInvoiceNo { get; set; }
        public string SalesInvoiceDate { get; set; }
        public int SalesInvoicePOno { get; set; }
        public string SalesCustomerName { get; set; }
        public string SalesInvoiceBillToLine1 { get; set; }
        public string SalesInvoiceShipToLine1 { get; set; }
        public decimal SalesProductAmt { get; set; }
        public string SalesTandC { get; set; }
    }
}
