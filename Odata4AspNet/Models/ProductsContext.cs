using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Odata4AspNet.Models
{
    public class ProductsContext : DbContext
    {
        public ProductsContext()
                : base("name=ProductsContext")
        {
            Database.SetInitializer<ProductsContext>(new ProductsContextInitializer());
        }
        public DbSet<Product> Products { get; set; }
    }
}