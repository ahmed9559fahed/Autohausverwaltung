using System.Data.Entity.ModelConfiguration;
using CarManagement.Data.DBModels;


namespace CarManagement.Data.ModelMapping
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
