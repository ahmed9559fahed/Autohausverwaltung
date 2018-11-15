using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarManagement.Data1.DBModels;

namespace CarManagement.Data1.ModelMapping
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
