using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autohausverwaltung.Data.ModelMapping;

namespace Autohausverwaltung.Data.DBModels
{
    public class DbContext:System.Data.Entity.DbContext
    {
        public DbContext(): base("DbConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DbContext, Migrations.Configuration>());

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DbCarMapping());
            modelBuilder.Configurations.Add(new DbUserMapping());
            modelBuilder.Configurations.Add(new DbSealsMapping());
            modelBuilder.Configurations.Add(new DbCostumerMapping());
        }
        public DbSet<DbcCar> CarsTable { get; set; }
        public DbSet<DbUser> UserTable { get; set; }
        public DbSet<DbSeal> SealsTable { get; set; }
    }
}
