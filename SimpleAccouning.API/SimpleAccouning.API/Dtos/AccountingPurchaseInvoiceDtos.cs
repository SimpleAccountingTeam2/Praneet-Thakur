using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAccouning.API.Dtos
{

    /// <summary>
    /// this class is for mapping of AccountingPurchaseInvoice to this calls named:AccountingPurchaseInvoiceDtos
    /// </summary>
    public class AccountingPurchaseInvoiceDtos
    {

        public int PurchaseInvoiceId { get; set; }
        public int PurchaseInvoiceNo { get; set; }
        public string PurchaseInvoiceDate { get; set; }
        public int PurchaseInvoicePOno { get; set; }
        public string PurchaseSupplierName { get; set; }
        public string PurchaseInvoiceBillToLine1 { get; set; }
        public string PurchaseInvoiceShipToLine1 { get; set; }
        public decimal PurchaseProductAmt { get; set; }
        public string PurchaseTandC { get; set; }
    }
}