using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAccouning.API.Dtos
{
    public class AccountingSalesOrderDetailDtos
    {
        public int SalesOrderDetailId { get; set; }
        public int SalesOrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
    }
}