using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class ProductReviewsContext:DbContext
    {
        ProductReviewsContext context;
        public ProductReviewsContext():base("name=MyConnectionString")
        {
            context = new ProductReviewsContext();
        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
    }
}