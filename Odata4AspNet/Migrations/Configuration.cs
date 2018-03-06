namespace Odata4AspNet.Migrations
{
    using CsvHelper;
    using Odata4AspNet.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<Odata4AspNet.Models.ProductsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Odata4AspNet.Models.ProductsContext";
        }

    }
}
