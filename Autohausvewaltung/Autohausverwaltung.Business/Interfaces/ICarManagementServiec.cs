using System;
using System.Collections.ObjectModel;
using CarManagement.Business.Models;

namespace CarManagement.Business.Interfaces
{
    public interface ICarManagementServiec
    {
        void AddCar(Car car);
        void DeleteCar(Guid id);
        void UpdateCar(Guid id,Car newCar);
        void AddSeal(Seal seal);
        bool CanLogIn(User user);
        Collection<Car> GetCars();
        Collection<Seal> GetSeals();


    }
}
