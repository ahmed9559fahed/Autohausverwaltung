using System.Data.Entity.ModelConfiguration;
using CarManagement.Data.DBModels;

namespace CarManagement.Data.ModelMapping
{
    public class DbSealsMapping:EntityTypeConfiguration<DbSeal>
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
