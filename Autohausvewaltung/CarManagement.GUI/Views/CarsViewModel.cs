using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CarManagement.Business1.Interface;
using CarManagement.Business1.Models;
using CarManagement.Business1.Service;
using DevExpress.Mvvm;


namespace CarManagement.GUI.Views
{
    public class CarsViewModel:ViewModelBase
    {
        public CarsViewModel()
        {
            CarService=new CarService();
            Cars = new ObservableCollection<Car>(new List<Car>());
        }

        public CarService CarService { get; set; }
        public ObservableCollection<Car> Cars
        {
            get { return GetProperty(() => Cars); }
            set { SetProperty(() => Cars, value); }
        }
    }
}
