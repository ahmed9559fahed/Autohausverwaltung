using System.Data.Entity.Migrations;

namespace CarManagement.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CarManagement.Data.DBModels.DbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CarManagement.Data.DBModels.DbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
