using System;
using System.Collections.ObjectModel;
using Autohausverwaltung.Data.DBModels;
using Autohausverwaltung.Data.Interfaces;

namespace Autohausverwaltung.Data.Services
{
    public class DatabaseService:IDatabaseServiec

    {
        public DatabaseService()
        {
            DbContext=new DbContext();
        }
        public DbContext DbContext { get; set; }
        public void AddCar(DbcCar dbCar)
        {
            throw new NotImplementedException();
        }

        public void DeleteCar(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCar(Guid id, DbcCar newCar)
        {
            throw new NotImplementedException();
        }

        public void UpdateCostumer(Guid id, DbCostomer newCostumer)
        {
            throw new NotImplementedException();
        }

        public void AddSeal(DbSeal dbSeal)
        {
            throw new NotImplementedException();
        }

        public void AddCostumer(DbCostomer dbCustomer)
        {
            throw new NotImplementedException();
        }

        public bool CanLogin(DbUser user)
        {
            throw new NotImplementedException();
        }

        public Collection<DbcCar> GetCars()
        {
            throw new NotImplementedException();
        }

        public Collection<DbSeal> GetSeals()
        {
            throw new NotImplementedException();
        }

        public DbCostomer GetCostumerById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
