using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarManagement.Business.Interface;
using CarManagement.Business.Models;
using CarManagement.Business.Service;
using NUnit.Framework;

namespace CarManagement.Test
{
    [TestFixture]
    public class CarServiceTest
    {
        public CarService CarService { get; set; } 
        public CarServiceTest()
        {
            
        }

        [Test]
        public void EntriedCarWithoutType_WhenAddNewCar_ThenCarNotAdded()
        { CarService=new CarService();
        var car =new Car();
            car.Id=Guid.NewGuid();
            car.Address = "Test";
            car.FirstName = "Afa";
            car.Color = "WHite";
            car.Name = "Fahed";
            var result= CarService.AddCar(car);

            Assert.IsFalse(result);
        }


        [Test]
        public void EntriedCarWithAllFields_WhenAddNewCar_ThenCarWasAdded()
        {
            CarService = new CarService();
            var car = new Car();
            car.Id = Guid.NewGuid();
            car.Address = "Test";
            car.FirstName = "Afa";
            car.Color = "WHite";
            car.Name = "Fahed";
            car.Type = "BMW";
            car.CostumerId=Guid.NewGuid();
           
            var result = CarService.AddCar(car);

            Assert.IsTrue(result);
        }
    }
}
