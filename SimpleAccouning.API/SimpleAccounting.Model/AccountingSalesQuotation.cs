﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAccounting.Model
{
   public class AccountingSalesQuotation : AuditableEntity<long>
    {
        public int SalesQuotationId { get; set; }
        public int SalesQuotationno { get; set; }
        public string SalesQuotaionDate { get; set; }
        public int SalesQuotationValidFor { get; set; }
        public string SalesSalesman { get; set; }
        public string CustomerName { get; set; }
        public string CustomerBilltoLine1 { get; set; }
        public string CustomerShiptoLine1 { get; set; }
        public string CustomerTotalAmt { get; set; }
        public string SalesQuotationTandC { get; set; }
    }
}
