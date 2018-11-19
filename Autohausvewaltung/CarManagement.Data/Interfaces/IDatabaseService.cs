using System;
using System.Collections.Generic;
using CarManagement.Data.DBModels;


namespace CarManagement.Data.Interfaces
{
    public interface IDatabaseService
    {
        bool AddCar(DbCar dbCar);
        void DeleteCar(Guid id);
        void UpdateCar(Guid id, DbCar newCar);
        void UpdateCostumer(Guid id, DbCostumer newCostumer);
        void AddSeal(DbSeal dbSeal);
        bool AddCostumer(DbCostumer dbCustomer);
        bool CanLogin(DbUser user);
        List<DbCar> GetCars();
        List<DbSeal> GetSeals();
        DbCostumer GetCostumerById(Guid id);

    }
}
