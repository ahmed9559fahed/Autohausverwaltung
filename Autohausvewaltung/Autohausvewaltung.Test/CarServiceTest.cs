using System;
using CarManagement.Business.Interface;
using CarManagement.Business.Models;
using CarManagement.Business.Service;
using CarManagement.Data.Interfaces;
using CarManagement.Data.DBModels;
using NUnit.Framework;
using Rhino.Mocks;

namespace CarManagement.Test
{
    [TestFixture]
    public class CarServiceTest
    {
        public CarService CarService { get; set; } 
       

        [Test]
        public void EntriedCarWithoutType_WhenAddNewCar_ThenCarNotAdded()
        {
            CarService = new CarService();
            var car = new Car();
            car.Id = Guid.NewGuid();
            car.Address = "Test";
            car.FirstName = "Afa";
            car.Color = "WHite";
            car.Name = "Fahed";
            var result = CarService.AddCar(car);

            Assert.IsFalse(result);
        }


        [Test]
        public void EntriedCarWithAllFields_WhenAddNewCar_ThenCarWasAdded()
        {

            var dbServiceMock = MockRepository.Mock<IDatabaseService>();
            dbServiceMock.Stub(x => x.AddCar(new DbCar())).Return(true);
            dbServiceMock.Stub(x => x.AddCostumer(new DbCostumer())).Return(true);

            var carService = new CarService(dbServiceMock);
            var car = new Car();
            car.Id = Guid.NewGuid();
            car.Address = "Test";
            car.FirstName = "Afa";
            car.Color = "WHite";
            car.Name = "Fahed";
            car.Type = "vhjhjgh";
            car.CostumerId = Guid.NewGuid();
            var result = carService.AddCar(car);

            Assert.IsTrue(result);












        }
    }
}
