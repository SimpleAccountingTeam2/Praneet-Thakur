using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAccouning.API.Dtos
{
    /// <summary>
    /// this is for mapping of AccountingSalesOrder to class named:AccountingSalesOrderDtos
    /// </summary>
    public class AccountingSalesOrderDtos
    {
        public int SalesOrderId { get; set; }
        public int SalesOrderNo { get; set; }
        public string SalesOrderDate { get; set; }
        public string SalesOrderDeliveryDate { get; set; }
        public string SalesCustomerName { get; set; }
        public string SalesOrderBillToLine1 { get; set; }
        public string SalesOrderShipToLine1 { get; set; }
        public decimal SalesProductAmt { get; set; }
        //public decimal SalesProductGst { get; set; }
        public string SalesTandC { get; set; }

    }
}