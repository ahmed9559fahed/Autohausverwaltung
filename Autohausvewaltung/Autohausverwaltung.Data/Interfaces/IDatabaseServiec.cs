using System;
using System.Collections.ObjectModel;
using Autohausverwaltung.Data.DBModels;

namespace Autohausverwaltung.Data.Interfaces
{
    public interface IDatabaseServiec
    {
        void AddCar(DbcCar dbCar);
        void DeleteCar(Guid id);
        void UpdateCar(Guid id,DbcCar newCar);
        void UpdateCostumer(Guid id, DbCostomer newCostumer);
        void AddSeal(DbSeal dbSeal);
        void AddCostumer(DbCostomer dbCustomer);
        bool CanLogin(DbUser user);
        Collection<DbcCar> GetCars();
        Collection<DbSeal> GetSeals();
        DbCostomer GetCostumerById(Guid id);

    }
}
