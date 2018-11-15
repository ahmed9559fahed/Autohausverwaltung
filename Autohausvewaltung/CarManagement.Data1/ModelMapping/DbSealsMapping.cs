using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarManagement.Data1.DBModels;

namespace CarManagement.Data1.ModelMapping
{
    class DbSealsMapping : EntityTypeConfiguration<DbSeal>
    {
        public DbSealsMapping()
        {
            ToTable("DbSeal");
            HasKey(t => t.Id);
            Property(t => t.CarId).HasColumnName("CarId");
            Property(t => t.SealDate).HasColumnName("SealDate");
            Property(t => t.UserId).HasColumnName("UserId");
        }
    }
}