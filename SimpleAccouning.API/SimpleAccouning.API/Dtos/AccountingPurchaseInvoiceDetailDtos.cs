using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAccouning.API.Dtos
{
    public class AccountingPurchaseInvoiceDetailDtos
    {
        public int PurchaseInvoiceDetailId { get; set; }
        public int PurchaseInvoiceId { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
    }
}