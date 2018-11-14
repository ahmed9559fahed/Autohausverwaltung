using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autohausverwaltung.Business.Models;
using Autohausverwaltung.Data.DBModels;
using Autohausverwaltung.Data.ModelMapping;

namespace Autohausverwaltung.Business.Interfaces
{
    public interface IDatabaseServiec
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
