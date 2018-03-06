using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Web;

namespace Odata4AspNet.Models
{
    public class ProductsContextInitializer
        : DropCreateDatabaseIfModelChanges<ProductsContext>
    {
        protected override void Seed(Odata4AspNet.Models.ProductsContext context)
        {
            // Requred to issue Update-Database to fill seed data.

            /*
            context.Products.AddOrUpdate(x => x.Id,
                new Product() { Id = 1, Name = "Canned Juice", Price = 60.00M, Category = "Food" },
                new Product() { Id = 2, Name = "Fried chicken", Price = 120.00M, Category = "Food" },
                new Product() { Id = 3, Name = "Hamburger", Price = 150.00M, Category = "Food" }
            );
            */

            Assembly assembly = Assembly.GetExecutingAssembly();

            string resourceName = "Odata4AspNet.Models.SeedData.Products.csv";
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    CsvReader csvReader = new CsvReader(reader);
                    var products = csvReader.GetRecords<Product>().ToArray();
                    context.Products.AddOrUpdate(c => c.Id, products);
                }
            }

        }

    }
}