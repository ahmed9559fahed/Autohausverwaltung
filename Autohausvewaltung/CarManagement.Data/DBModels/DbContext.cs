using System.Data.Entity;
using CarManagement.Data.Migrations;
using CarManagement.Data.ModelMapping;

namespace CarManagement.Data.DBModels
{
   public class DbContext:System.Data.Entity.DbContext
    {
        public DbContext() : base("DbConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CarManagement.Data.DBModels.DbContext, Configuration>());

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DbCarMapping());
            modelBuilder.Configurations.Add(new DbUserMapping());
            modelBuilder.Configurations.Add(new DbSealsMapping());
            modelBuilder.Configurations.Add(new DbCostumerMapping());
        }
        public DbSet<DbCar> CarsTable { get; set; }
        public DbSet<DbUser> UserTable { get; set; }
        public DbSet<DbSeal> SealsTable { get; set; }
        public DbSet<DbCostumer> CostomersTable { get; set; }
    }
}
