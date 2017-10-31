namespace SweetList.Entity.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SweetList.Entity.SweetListDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SweetList.Entity.SweetListDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            
            context.Countries.Add(new Domain.Country() { Name = "Albania" });
            context.Countries.Add(new Domain.Country() { Name = "Croatia" });
            context.Countries.Add(new Domain.Country() { Name = "Denmark" });
            context.Countries.Add(new Domain.Country() { Name = "Finland" });
            context.Countries.Add(new Domain.Country() { Name = "Georgia" });
            context.Countries.Add(new Domain.Country() { Name = "Hungary" });
            context.Countries.Add(new Domain.Country() { Name = "Iceland" });
            context.Countries.Add(new Domain.Country() { Name = "Kosovo" });
            context.Countries.Add(new Domain.Country() { Name = "Latvia" });
            context.Countries.Add(new Domain.Country() { Name = "Malta" });
            context.Countries.Add(new Domain.Country() { Name = "Norway" });
            context.Countries.Add(new Domain.Country() { Name = "Poland" });
            context.Countries.Add(new Domain.Country() { Name = "Sweden" });

            context.Customers.Add(new Domain.Customer() { Name = "Customer 1", CountryId = 1 });

            context.SaveChanges();
        }
    }
}
