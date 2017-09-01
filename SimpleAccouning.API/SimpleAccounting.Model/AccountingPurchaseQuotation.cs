using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model
{
   public class AccountingPurchaseQuotation : AuditableEntity<long>
    {
        public int PurchaseQuotationId { get; set; }
        public int PurchaseQuotationNo { get; set; }
        public string PurchaseQuotationDate { get; set; }
        public int PurchaseQuatationValidFor { get; set; }
        public string PurchaseSupplierName { get; set; }
        public string PurchaseQuotationBillToLine1 { get; set; }
        public string PurchaseQuotationShipToLine1 { get; set; }
        public decimal PurchaseProductAmt { get; set; }
        public string PurchaseTandC { get; set; }
    }
}
