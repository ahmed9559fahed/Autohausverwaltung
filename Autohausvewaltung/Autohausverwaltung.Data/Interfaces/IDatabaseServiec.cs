using System;
using System.Collections.Generic;
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
        List<DbcCar> GetCars();
        List<DbSeal> GetSeals();
        DbCostomer GetCostumerById(Guid id);

    }
}
