using System.Data.Entity.ModelConfiguration;
using CarManagement.Data.DBModels;

namespace CarManagement.Data.ModelMapping
{
    class DbUserMapping : EntityTypeConfiguration<DbUser>
    {
        public DbUserMapping()
        {
            ToTable("Users");
            HasKey(t => t.Id);
            Property(t => t.UserName).HasColumnName("UserName");
            Property(t => t.Password).HasColumnName("Password");
        }
    }
}
