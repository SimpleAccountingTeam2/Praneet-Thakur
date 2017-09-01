namespace SimpleAccounting.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class praneet : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountingCompanyDetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyId = c.Int(nullable: false),
                        CompanyName = c.String(),
                        CompanyRegno = c.Int(nullable: false),
                        CompanyTelephone = c.String(),
                        CompanyEmail = c.String(),
                        FinancialYrStartDate = c.String(),
                        CompanyLogo = c.Binary(),
                        SoftwareSerialNo = c.String(),
                        BilltoLine1 = c.String(),
                        BilltoLine2 = c.String(),
                        BilltoCity = c.String(),
                        BilltoState = c.String(),
                        BilltoCountry = c.String(),
                        BilltoPostalCode = c.String(),
                        ShiptoLine1 = c.String(),
                        ShiptoLine2 = c.String(),
                        ShiptoCity = c.String(),
                        ShiptoState = c.String(),
                        ShiptoCountry = c.String(),
                        ShiptoPostalCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccountingCustomer",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        CustomerName = c.String(),
                        CustomerInActive = c.Boolean(nullable: false),
                        CustomerCompanyRegno = c.Int(nullable: false),
                        CustomerBalanceAmt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CustomerType = c.String(),
                        Salesman = c.String(),
                        CustomerTelephone = c.String(),
                        CustomerFax = c.String(),
                        CustomerEmail = c.String(),
                        CustomerContactPerson = c.String(),
                        CustomerRemarks = c.String(),
                        CustomerBilltoLine1 = c.String(),
                        CustomerBilltoLine2 = c.String(),
                        CustomerBilltoCity = c.String(),
                        CustomerBilltoState = c.String(),
                        CustomerBilltoCountry = c.String(),
                        CustomerBilltoPostalCode = c.String(),
                        CustomerShiptoLine1 = c.String(),
                        CustomerShiptoLine2 = c.String(),
                        CustomerShiptoCity = c.String(),
                        CustomerShiptoState = c.String(),
                        CustomerShiptoCountry = c.String(),
                        CustomerShiptoPostalCode = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccountingOption",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OptionId = c.Int(nullable: false),
                        OptionDate = c.String(),
                        OptionCommas = c.String(),
                        OptionDecPlaces = c.String(),
                        OptionCurrencyName = c.String(),
                        DefaultCashorBankAcc = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccountingProduct",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ProductCode = c.Int(nullable: false),
                        ProductName = c.String(),
                        ProductQty = c.Int(nullable: false),
                        ProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccountingPurchaseInvoiceDetail",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PurchaseInvoiceDetailId = c.Int(nullable: false),
                        PurchaseInvoiceId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccountingPurchaseInvoice",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PurchaseInvoiceId = c.Int(nullable: false),
                        PurchaseInvoiceNo = c.Int(nullable: false),
                        PurchaseInvoiceDate = c.String(),
                        PurchaseInvoicePOno = c.Int(nullable: false),
                        PurchaseSupplierName = c.String(),
                        PurchaseInvoiceBillToLine1 = c.String(),
                        PurchaseInvoiceShipToLine1 = c.String(),
                        PurchaseProductAmt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PurchaseTandC = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccountingPurchaseOrderDetail",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PurchaseOrderDetailId = c.Int(nullable: false),
                        PurchaseOrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccountingPurchaseOrder",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PurchaseOrderId = c.Int(nullable: false),
                        PurchaseOrderNo = c.Int(nullable: false),
                        PurchaseOrderDate = c.String(),
                        PurchaseOrderDeliveryDate = c.String(),
                        PurchaseSupplierName = c.String(),
                        PurchaseOrderBillToLine1 = c.String(),
                        PurchaseOrderShipToLine1 = c.String(),
                        PurchaseProductAmt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PurchaseTandC = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccountingPurchaseQuotation",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PurchaseQuotationId = c.Int(nullable: false),
                        PurchaseQuotationNo = c.Int(nullable: false),
                        PurchaseQuotationDate = c.String(),
                        PurchaseQuatationValidFor = c.Int(nullable: false),
                        PurchaseSupplierName = c.String(),
                        PurchaseQuotationBillToLine1 = c.String(),
                        PurchaseQuotationShipToLine1 = c.String(),
                        PurchaseProductAmt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PurchaseTandC = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccountingSalesInvoiceDetail",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        SalesInvoiceDetailId = c.Int(nullable: false),
                        SalesInvoiceId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccountingSalesInvoice",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        SalesInvoiceId = c.Int(nullable: false),
                        SalesInvoiceNo = c.Int(nullable: false),
                        SalesInvoiceDate = c.String(),
                        SalesInvoicePOno = c.Int(nullable: false),
                        SalesCustomerName = c.String(),
                        SalesInvoiceBillToLine1 = c.String(),
                        SalesInvoiceShipToLine1 = c.String(),
                        SalesProductAmt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalesTandC = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccountingSalesOrder",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        SalesOrderId = c.Int(nullable: false),
                        SalesOrderNo = c.Int(nullable: false),
                        SalesOrderDate = c.String(),
                        SalesOrderDeliveryDate = c.String(),
                        SalesCustomerName = c.String(),
                        SalesOrderBillToLine1 = c.String(),
                        SalesOrderShipToLine1 = c.String(),
                        SalesProductAmt = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalesTandC = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccountingSalesOrderDetail",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        SalesOrderDetailId = c.Int(nullable: false),
                        SalesOrderId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccountingSalesQuotation",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        SalesQuotationId = c.Int(nullable: false),
                        SalesQuotationno = c.Int(nullable: false),
                        SalesQuotaionDate = c.String(),
                        SalesQuotationValidFor = c.Int(nullable: false),
                        SalesSalesman = c.String(),
                        CustomerName = c.String(),
                        CustomerBilltoLine1 = c.String(),
                        CustomerShiptoLine1 = c.String(),
                        CustomerTotalAmt = c.String(),
                        SalesQuotationTandC = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccountingSupplier",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        SalesProductId = c.Int(nullable: false),
                        SalesProductCode = c.Int(nullable: false),
                        SalesProductName = c.String(),
                        SalesProductQty = c.Int(nullable: false),
                        SalesProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalesProductDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(maxLength: 256),
                        UpdatedDate = c.DateTime(nullable: false),
                        UpdatedBy = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AccountingSupplier");
            DropTable("dbo.AccountingSalesQuotation");
            DropTable("dbo.AccountingSalesOrderDetail");
            DropTable("dbo.AccountingSalesOrder");
            DropTable("dbo.AccountingSalesInvoice");
            DropTable("dbo.AccountingSalesInvoiceDetail");
            DropTable("dbo.AccountingPurchaseQuotation");
            DropTable("dbo.AccountingPurchaseOrder");
            DropTable("dbo.AccountingPurchaseOrderDetail");
            DropTable("dbo.AccountingPurchaseInvoice");
            DropTable("dbo.AccountingPurchaseInvoiceDetail");
            DropTable("dbo.AccountingProduct");
            DropTable("dbo.AccountingOption");
            DropTable("dbo.AccountingCustomer");
            DropTable("dbo.AccountingCompanyDetail");
        }
    }
}
