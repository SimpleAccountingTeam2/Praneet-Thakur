using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model
{
   public class AccountingSalesOrder : AuditableEntity<long>
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
