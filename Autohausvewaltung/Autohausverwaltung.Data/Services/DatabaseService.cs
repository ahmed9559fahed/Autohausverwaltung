using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
using System.Linq;
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
            DbContext.CarsTable.Add(dbCar);
            DbContext.SaveChanges();
        }

        public void DeleteCar(Guid id)
        {
            var dbCar = DbContext.CarsTable.FirstOrDefault(x => x.Id == id);
            DbContext.CarsTable.Remove(dbCar);
            DbContext.SaveChanges();
        }

        public void UpdateCar(Guid id, DbcCar newCar)
        {
            var oldCar = DbContext.CarsTable.FirstOrDefault(x => x.Id == id);
            DbContext.CarsTable.Remove(oldCar);
            DbContext.SaveChanges();

            DbContext.CarsTable.Add(newCar);
            DbContext.SaveChanges();
        }

        public void UpdateCostumer(Guid id, DbCostomer newCostumer)
        {
            var oldCostumer = DbContext.CostomersTable.FirstOrDefault(x => x.Id == id);
            DbContext.CostomersTable.Remove(oldCostumer);
            DbContext.SaveChanges();

            DbContext.CostomersTable.Add(newCostumer);
            DbContext.SaveChanges();
        }

        public void AddSeal(DbSeal dbSeal)
        {
            DbContext.SealsTable.Add(dbSeal);
            DbContext.SaveChanges();
        }

        public void AddCostumer(DbCostomer dbCustomer)
        {
            DbContext.CostomersTable.Add(dbCustomer);
            DbContext.SaveChanges();
        }

        public bool CanLogin(DbUser user)
        {
            var dbuser = DbContext.UserTable.FirstOrDefault(x => x.UserName == user.UserName);
            if (dbuser!=null&& dbuser.Password==user.Password)
            {
                return true;
            }

            return false;
        }

        public List<DbcCar> GetCars()
        {
            return DbContext.CarsTable.ToList();
        }

        public List<DbSeal> GetSeals()
        {
            return DbContext.SealsTable.ToList();
        }

        public DbCostomer GetCostumerById(Guid id)
        {
            return DbContext.CostomersTable.FirstOrDefault(x => x.Id == id);
        }
    }
}
