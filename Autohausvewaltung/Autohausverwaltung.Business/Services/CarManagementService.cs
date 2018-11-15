using System;
using System.Collections.ObjectModel;
using CarManagement.Business.Interfaces;
using CarManagement.Business.Models;
using CarManagement.Data.DBModels;
using CarManagement.Data.Services;

namespace CarManagement.Business.Services
{
    public class CarManagementService:ICarManagementServiec

    {
        public CarManagementService()
        {
            DbService=new DatabaseService();
        }
        public DatabaseService DbService { get; set; }

        public void AddCar(Car car)
        {
            var dbCostumer = new DbCostomer()
            {
                Address = car.Address,
                FirstName = car.FirstName,
                Name = car.Name,
                Id = Guid.NewGuid(),
                TelefonNr = car.TelefonNr
            };
            var dbCar=new DbcCar()
            {
                Id = Guid.NewGuid(),
                Color = car.Color,
                CostumerId = dbCostumer.Id,
                Model = car.Model,
                Price = car.Price,
                RegisterDate = car.RegisterDate,
                TuvUntil = car.TuvUntil,
                Type = car.Type
            };
            DbService.AddCostumer(dbCostumer);
            DbService.AddCar(dbCar);
        }

        public void DeleteCar(Guid id)
        {
           DbService.DeleteCar(id);
        }

        public void UpdateCar(Guid id, Car car)
        {
            var dbCostumer = new DbCostomer()
            {
                Address = car.Address,
                FirstName = car.FirstName,
                Name = car.Name,
                Id = Guid.NewGuid(),
                TelefonNr = car.TelefonNr
            };
            var dbCar = new DbcCar()
            {
                Id = Guid.NewGuid(),
                Color = car.Color,
                CostumerId = dbCostumer.Id,
                Model = car.Model,
                Price = car.Price,
                RegisterDate = car.RegisterDate,
                TuvUntil = car.TuvUntil,
                Type = car.Type
            };
            DbService.UpdateCar(dbCar.Id,dbCar);
            DbService.UpdateCostumer(dbCostumer.Id,dbCostumer);
        }

        public void AddSeal(Seal seal)
        {
           var dbSeal=new DbSeal()
           {
               CarId = seal.CarId,
               CostumerId = seal.CostumerId,
               Id = Guid.NewGuid(),
               SealDate = seal.SealDate,
               UserId = seal.UserId
           };
            DbService.AddSeal(dbSeal);
        }

        public bool CanLogIn(User user)
        {
            var dbUser=new DbUser()
            {
                Id=user.Id,
                UserName = user.UserName,
                Password=user.Password

            };
            return DbService.CanLogin(dbUser);
        }

        public Collection<Car> GetCars()
        {
            var cars=new Collection<Car>();
            var dbCarsCollection= DbService.GetCars();
            
            foreach (var dbcCar in dbCarsCollection)
            {
                var costumer = DbService.GetCostumerById(dbcCar.CostumerId);
                var car = new Car()
                {
                    Id = dbcCar.Id,
                    CostumerId = dbcCar.CostumerId,
                    Address = costumer.Address,
                    TuvUntil = dbcCar.TuvUntil,
                    Color = dbcCar.Color,
                    FirstName = costumer.FirstName,
                    Model = dbcCar.Model,
                    TelefonNr = costumer.TelefonNr,
                    Name = costumer.Name,
                    Price = dbcCar.Price,
                };
                cars.Add(car);
            }

            return cars;
        }

        public Collection<Seal> GetSeals()
        {
            var dbSeals= DbService.GetSeals();
            var seals=new Collection<Seal>();
            foreach (var dbSeal in dbSeals)
            {
                var seal=new Seal()
                {
                    CarId = dbSeal.CarId,
                    CostumerId = dbSeal.CostumerId,
                    Id = dbSeal.Id,
                    SealDate = dbSeal.SealDate,
                    UserId = dbSeal.UserId
                };
                seals.Add(seal);
            }

            return seals;
        }
    }
}
