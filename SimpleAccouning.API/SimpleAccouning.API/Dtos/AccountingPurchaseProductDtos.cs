using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAccouning.API.Dtos
{
    /// <summary> 
    /// this is for mapping of  AccountingPurchaseProduct to class named:AccountingPurchaseProductDtos
    /// </summary>
    public class AccountingPurchaseProductDtos
    {
        public int PurchaseProductId { get; set; }
        public int PurchaseProductCode { get; set; }
        public string PurchaseProductName { get; set; }
        public int PurchaseProductQty { get; set; }
        public decimal PurchaseProductPrice { get; set; }
        public decimal PurchaseProductDiscount { get; set; }
    }
}