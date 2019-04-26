namespace OData.Api.Migrations
{
    using OData.Api.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OData.Api.Models.ODataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(OData.Api.Models.ODataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            // New code 
            context.Products.AddOrUpdate(new Product[] {
        new Product() { Id = 1, Name = "Hat", Price = 15, Category = "Apparel" },
        new Product() { Id = 2, Name = "Socks", Price = 5, Category = "Apparel" },
        new Product() { Id = 3, Name = "Scarf", Price = 12, Category = "Apparel" },
        new Product() { Id = 4, Name = "Yo-yo", Price = 4.95M, Category = "Toys" },
        new Product() { Id = 5, Name = "Puzzle", Price = 8, Category = "Toys" },
    });
        }
    }
}
