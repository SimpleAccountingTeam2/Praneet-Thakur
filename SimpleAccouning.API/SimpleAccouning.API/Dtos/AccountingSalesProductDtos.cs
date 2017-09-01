using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAccouning.API.Dtos
{

    /// <summary>
    /// this is for mapping of AccountingSalesProduct to class named:AccountingSalesProductDtos
    /// </summary>
    public class AccountingSalesProductDtos
    {
        public int SalesProductId { get; set; }
        public int SalesProductCode { get; set; }
        public string SalesProductName { get; set; }
        public int SalesProductQty { get; set; }
        public decimal SalesProductPrice { get; set; }
        public decimal SalesProductDiscount { get; set; }
    }
}