using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleAccounting.Model
{
    /// <summary>
    /// this is for creating tables
    /// </summary>


   interface ISimpleAccountingContext
    {

        IDbSet<AccountingCompanyDetail> AccountingCompanyDetails { get; set; }
        IDbSet<AccountingCustomer> AccountingCustomers { get; set; }

        IDbSet<AccountingOption> AccountingOptions { get; set; }
        IDbSet<AccountingProduct> AccountingProducts { get; set; }
        IDbSet<AccountingPurchaseInvoice> AccountingPurchaseInvoices { get; set; }

        IDbSet<AccountingPurchaseInvoiceDetail> AccountingPurchaseInvoiceDetails { get; set; }
        IDbSet<AccountingPurchaseOrder> AccountingPurchaseOrders { get; set; }

        
        IDbSet<AccountingPurchaseOrderDetail> AccountingPurchaseOrderDetail { get; set; }
        IDbSet<AccountingPurchaseQuotation> AccountingPurchaseQuotations { get; set; }
        IDbSet<AccountingSalesInvoice> AccountingSalesInvoices { get; set; }
        IDbSet<AccountingSalesInvoiceDetail> AccountingSalesInvoiceDetails { get; set; }
        IDbSet<AccountingSalesOrder> AccountingSalesOrder { get; set; }
        IDbSet<AccountingSalesOrderDetail> AccountingSalesOrderDetails { get; set; }
        IDbSet<AccountingSalesQuotation> AccountingSalesQuotations { get; set; }
        IDbSet<AccountingSupplier> AccountingSuppliers { get; set; }
        
        


        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();
    }




    class SimpleAccountingContext : DbContext, ISimpleAccountingContext
    {
        public SimpleAccountingContext():base("name=MyConnectionString")
        {
         
        }

        public static SimpleAccountingContext Create()
        {
            return new SimpleAccountingContext();
        }
        public IDbSet<AccountingCompanyDetail> AccountingCompanyDetails
        {
            get;

            set;
        }

        public IDbSet<AccountingCustomer> AccountingCustomers
        {
            get;

            set;
        }

        public IDbSet<AccountingOption> AccountingOptions
        {
            get;

            set;
        }

        public IDbSet<AccountingPurchaseInvoice> AccountingPurchaseInvoices
        {
            get;

            set;
        }

        public IDbSet<AccountingPurchaseOrder> AccountingPurchaseOrders
        {
            get;

            set;
        }

    

        public IDbSet<AccountingPurchaseQuotation> AccountingPurchaseQuotations
        {
            get;

            set;
        }

        public IDbSet<AccountingProduct> AccountingProducts
        {
            get;

            set;
        }


        public IDbSet<AccountingSalesInvoice> AccountingSalesInvoices
        {
            get;

            set;
        }

        public IDbSet<AccountingSalesOrder> AccountingSalesOrder
        {
            get;

            set;
        }


        public IDbSet<AccountingSupplier> AccountingSuppliers
        {
            get;

            set;
        }

        public IDbSet<AccountingPurchaseInvoiceDetail> AccountingPurchaseInvoiceDetails
        {
            get;

            set;
        }

        public IDbSet<AccountingPurchaseOrderDetail> AccountingPurchaseOrderDetail
        {
            get;

            set;
        }

        public IDbSet<AccountingSalesInvoiceDetail> AccountingSalesInvoiceDetails
        {
            get;

            set;
        }

        public IDbSet<AccountingSalesOrderDetail> AccountingSalesOrderDetails
        {
            get;

            set;
        }

        public IDbSet<AccountingSalesQuotation> AccountingSalesQuotations
        {
            get;

            set;
        }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }


        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditableEntity
                    && (x.State == System.Data.Entity.EntityState.Added || x.State == System.Data.Entity.EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    string identityName = Thread.CurrentPrincipal.Identity.Name;
                    DateTime now = DateTime.UtcNow;

                    if (entry.State == System.Data.Entity.EntityState.Added)
                    {
                        entity.CreatedBy = identityName;
                        entity.CreatedDate = now;
                    }
                    else
                    {
                        base.Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        base.Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                    }

                    entity.UpdatedBy = identityName;
                    entity.UpdatedDate = now;
                }
            }

            return base.SaveChanges();
        }
    }

}

