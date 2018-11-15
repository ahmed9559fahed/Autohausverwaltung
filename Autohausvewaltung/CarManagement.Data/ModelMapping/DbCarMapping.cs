using System.Data.Entity.ModelConfiguration;
using DataLayer.DBModels;

namespace DataLayer.ModelMapping
{
    class DbCarMapping : EntityTypeConfiguration<DbCar>
    {
        public DbCarMapping()
        {
            ToTable("Cars");
            HasKey(t => t.Id);
            Property(t => t.Color).HasColumnName("Color");
            Property(t => t.Model).HasColumnName("Model");
            Property(t => t.Type).HasColumnName("Type");
            Property(t => t.TuvUntil).HasColumnName("TuvUntil");
            Property(t => t.Price).HasColumnName("Price");
            Property(t => t.RegisterDate).HasColumnName("RegisterDate");
            Property(t => t.CostumerId).HasColumnName("CostumerId");
        }
    }
}
