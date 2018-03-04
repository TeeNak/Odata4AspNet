namespace Odata4AspNet.Migrations
{
    using Odata4AspNet.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Odata4AspNet.Models.ProductsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Odata4AspNet.Models.ProductsContext";
        }

        protected override void Seed(Odata4AspNet.Models.ProductsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Products.AddOrUpdate(x => x.Id,
                new Product() { Id = 1, Name = "Canned Juice", Price = 60.00M, Category = "Food" },
                new Product() { Id = 2, Name = "Fried chicken", Price = 120.00M, Category = "Food" },
                new Product() { Id = 3, Name = "Hamburger", Price = 150.00M, Category = "Food" }
            );
        }
    }
}
