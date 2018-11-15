using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarManagement.Data1.DBModels;

namespace CarManagement.Data1.ModelMapping
{
    class DbCostumerMapping : EntityTypeConfiguration<DbCostumer>
    {
        public DbCostumerMapping()
        {
            ToTable("Costumers");
            HasKey(t => t.Id);
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.FirstName).HasColumnName("FirstName");
            Property(t => t.TelefonNr).HasColumnName("TelefonNr");
            Property(t => t.Address).HasColumnName("Address");
        }
    }
}
