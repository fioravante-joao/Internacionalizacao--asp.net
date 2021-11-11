namespace MvcAzure.Migrations
{
    using MvcAzure.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcAzure.Data.MvcAzureContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcAzure.Data.MvcAzureContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Medicos.AddOrUpdate(
              m => m.Nome,
              new Medico { Nome = "Andrew Peters" },
              new Medico { Nome = "Brice Lambson" },
              new Medico { Nome = "Rowan Miller" }
            );
        }
    }
}
