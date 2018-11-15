using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarManagement.Data1.DBModels;

namespace CarManagement.Data1.Interfaces
{
    public interface IDatabaseService
    {
        void AddCar(DbCar dbCar);
        void DeleteCar(Guid id);
        void UpdateCar(Guid id, DbCar newCar);
        void UpdateCostumer(Guid id, DbCostumer newCostumer);
        void AddSeal(DbSeal dbSeal);
        void AddCostumer(DbCostumer dbCustomer);
        bool CanLogin(DbUser user);
        List<DbCar> GetCars();
        List<DbSeal> GetSeals();
        DbCostumer GetCostumerById(Guid id);

    }
}
