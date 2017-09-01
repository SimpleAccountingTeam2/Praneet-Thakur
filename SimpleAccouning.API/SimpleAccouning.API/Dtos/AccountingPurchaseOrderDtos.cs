using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAccouning.API.Dtos
{
    /// <summary>
    /// this call is for mapping of AccountingPurchaseOrder to this call named:AccountingPurchaseOrderDtos 
    /// </summary>
    public class AccountingPurchaseOrderDtos
    {
        public int PurchaseOrderId { get; set; }
        public int PurchaseOrderNo { get; set; }
        public string PurchaseOrderDate { get; set; }
        public string PurchaseOrderDeliveryDate { get; set; }
        public string PurchaseSupplierName { get; set; }
        public string PurchaseOrderBillToLine1 { get; set; }
        public string PurchaseOrderShipToLine1 { get; set; }
        public decimal PurchaseProductAmt { get; set; }
        public string PurchaseTandC { get; set; }
    }
}