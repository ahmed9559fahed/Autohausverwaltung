using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer.DBModels;
using DataLayer.Interfaces;

namespace DataLayer.Services
{
   public class DatabaseService : IDatabaseService

    {
        public DatabaseService()
        {
            DbContext = new DbContext();
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
            if (oldCar != null)
            {
                DbContext.CarsTable.Remove(entity: oldCar);
                DbContext.SaveChanges();
            }
           
        

            DbContext.CarsTable.Add(newCar);
            DbContext.SaveChanges();
        }

        public void UpdateCostumer(Guid id, DbCostumer newCostumer)
        {
            var oldCostumer = DbContext.CostomersTable.FirstOrDefault(x => x.Id == id);
            if (oldCostumer != null)
            {
                DbContext.CostomersTable.Remove(entity: oldCostumer);
                DbContext.SaveChanges();
            }
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
            //for (int i = 0; i < 50; i++)
            //{
            //    if (i < 10)
            //    {
            //        var car=new DbCar()
            //        {
            //            Id=Guid.NewGuid(),
            //            Color = "Red",
            //            CostumerId = Guid.NewGuid(),
            //            Model = "2000",
            //            Price = 20000,
            //            RegisterDate =new DateTime(2001,02,01),
            //                                    TuvUntil = new DateTime(2020, 02, 01),
            //            Type = "BMW"
            //        };
            //        DbContext.CarsTable.Add(car);
            //        DbContext.SaveChanges();

            //    }
            //    else if(i<20)
            //    {
            //        var car = new DbCar()
            //        {
            //            Id = Guid.NewGuid(),
            //            Color = "White",
            //            CostumerId = Guid.NewGuid(),
            //            Model = "1997",
            //            Price = 50000,
            //            RegisterDate = new DateTime(2001, 02, 01),
            //            TuvUntil = new DateTime(2020, 02, 01),
            //            Type = "Mercedes"
            //        };
            //        DbContext.CarsTable.Add(car);
            //        DbContext.SaveChanges();

            //    }
            //    else if (i < 30)
            //    {
            //        var car = new DbCar()
            //        {
            //            Id = Guid.NewGuid(),
            //            Color = "Blue",
            //            CostumerId = Guid.NewGuid(),
            //            Model = "2005",
            //            Price = 25000,
            //            RegisterDate = new DateTime(2001, 02, 01),
            //            TuvUntil = new DateTime(2020, 02, 01),
            //            Type = "Fiat"
            //        };
            //        DbContext.CarsTable.Add(car);
            //        DbContext.SaveChanges();
            //    }
            //    else if (i < 40)
            //    {
            //        var car = new DbCar()
            //        {
            //            Id = Guid.NewGuid(),
            //            Color = "Black",
            //            CostumerId = Guid.NewGuid(),
            //            Model = "2006",
            //            Price = 100000,
            //            RegisterDate = new DateTime(2001, 02, 01),
            //            TuvUntil = new DateTime(2020, 02, 01),
            //            Type = "Dodge"
            //        };
            //        DbContext.CarsTable.Add(car);
            //        DbContext.SaveChanges();
            //    }
            //    else if (i < 50)
            //    {
            //        var car = new DbCar()
            //        {
            //            Id = Guid.NewGuid(),
            //            Color = "Black",
            //            CostumerId = Guid.NewGuid(),
            //            Model = "2016",
            //            Price = 200000,
            //            RegisterDate = new DateTime(2001, 02, 01),
            //            TuvUntil = new DateTime(2020, 02, 01),
            //            Type = "Porsh"
            //        };
            //        DbContext.CarsTable.Add(car);
            //        DbContext.SaveChanges();

            //    }

            //}

            //foreach (var dbCar in DbContext.CarsTable.ToList())
            //{
            //    var costumer=new DbCostumer()
            //    {
            //        Address = "Uetersen",
            //        FirstName = "Ahmed",
            //        Name = "Fahed",
            //        Id = dbCar.CostumerId,
            //        TelefonNr = "2456486762548"
            //    };
            //    DbContext.CostomersTable.Add(costumer);
            //    DbContext.SaveChanges();
            //}

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