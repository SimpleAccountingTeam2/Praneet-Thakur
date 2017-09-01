using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model
{
    class AccountingSalesOrderDetail : AuditableEntity<long>
    {
        public int SalesOrderDetailId { get; set; }
        public int SalesOrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
    }
}
