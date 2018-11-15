using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarManagement.Business.Models;

namespace CarManagement.Business1.Interface
{
    public interface ICarService
    {
        void AddCar(Car car);
        void DeleteCar(Guid id);
        void UpdateCar(Guid id, Car newCar);
        void AddSeal(Seal seal);
        bool CanLogIn(User user);
        Collection<Car> GetCars();
        Collection<Seal> GetSeals();
    }
}
