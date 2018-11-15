using System.Data.Entity.ModelConfiguration;
using DataLayer.DBModels;

namespace DataLayer.ModelMapping
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
