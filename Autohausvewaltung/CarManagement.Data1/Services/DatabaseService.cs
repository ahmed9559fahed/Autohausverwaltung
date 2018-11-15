using System;
using System.Collections.Generic;
using System.Linq;
using CarManagement.Data.DBModels;
using CarManagement.Data1.Interfaces;

namespace CarManagement.Data.Services
{
   public class DatabaseService : IDatabaseService

    {
        public DatabaseService()
        {
            DbContext = new CarManagement.Data.DBModels.DbContext();
        }
        public DbContext DbContext { get; set; }
        public void AddCar(DbCar dbCar)
        {
            DbContext.CarsTable.Add(dbCar);
            DbContext.SaveChanges();
        }

        public void DeleteCar(Guid id)
        {
            var dbCar = DbContext.CarsTable.FirstOrDefault(x => x.Id == id);
            if (dbCar != null) DbContext.CarsTable.Remove(dbCar);
            DbContext.SaveChanges();
        }

        public void UpdateCar(Guid id, DbCar newCar)
        {
            var oldCar = DbContext.CarsTable.FirstOrDefault(x => x.Id == id);
            if (oldCar != null) DbContext.CarsTable.Remove(entity: oldCar);
            DbContext.SaveChanges();

            DbContext.CarsTable.Add(newCar);
            DbContext.SaveChanges();
        }

        public void UpdateCostumer(Guid id, DbCostumer newCostumer)
        {
            var oldCostumer = DbContext.CostomersTable.FirstOrDefault(x => x.Id == id);
            if (oldCostumer != null) DbContext.CostomersTable.Remove(entity: oldCostumer);
            DbContext.SaveChanges();

            DbContext.CostomersTable.Add(newCostumer);
            DbContext.SaveChanges();
        }

        public void AddSeal(DbSeal dbSeal)
        {
            DbContext.SealsTable.Add(dbSeal);
            DbContext.SaveChanges();
        }

        public void AddCostumer(DbCostumer dbCustomer)
        {
            DbContext.CostomersTable.Add(dbCustomer);
            DbContext.SaveChanges();
        }

        public bool CanLogin(DbUser user)
        {
            var dbuser = DbContext.UserTable.FirstOrDefault(x => x.UserName == user.UserName);
            if (dbuser != null && dbuser.Password == user.Password)
            {
                return true;
            }

            return false;
        }

        public List<DbCar> GetCars()
        {
            return DbContext.CarsTable.ToList();
        }

        public List<DbSeal> GetSeals()
        {
            return DbContext.SealsTable.ToList();
        }

        public DbCostumer GetCostumerById(Guid id)
        {
            return DbContext.CostomersTable.FirstOrDefault(x => x.Id == id);
        }
    }
}