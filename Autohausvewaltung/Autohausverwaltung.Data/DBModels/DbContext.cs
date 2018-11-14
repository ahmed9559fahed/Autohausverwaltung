using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autohausverwaltung.Data.DBModels
{
    public class DbContext:System.Data.Entity.DbContext
    {
        public DbContext()
        {
            
        }

        public DbSet<DbcCar> CarsTable { get; set; }
        public DbSet<DbUser> UserTable { get; set; }
        public DbSet<Seals> SealsTable { get; set; }
    }
}
