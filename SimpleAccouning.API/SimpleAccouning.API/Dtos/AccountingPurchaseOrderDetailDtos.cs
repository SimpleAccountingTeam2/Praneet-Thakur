using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAccouning.API.Dtos
{
    public class AccountingPurchaseOrderDetailDtos
    {
        public int PurchaseOrderDetailId { get; set; }
        public int PurchaseOrderId { get; set; }
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
    }
}