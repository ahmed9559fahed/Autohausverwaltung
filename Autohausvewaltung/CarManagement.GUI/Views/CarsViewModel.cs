using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using CarManagement.Business.Models;
using CarManagement.Business.Service;
using DevExpress.Mvvm;


namespace CarManagement.GUI.Views
{
    public class CarsViewModel:ViewModelBase
    {
        public CarsViewModel()
        {
         
            Cars = new ObservableCollection<Car>(new List<Car>());
            EditCommand=new DelegateCommand(EditCar);
            AddCommand = new DelegateCommand(AddCar);
            RemoveCommand = new DelegateCommand(RemoveCar);
        }

        private void EditCar()
        {
            NavigationService.Navigate(typeof(HomeView).FullName, null, this);
        }
        private void AddCar()
        {
            NavigationService.Navigate(typeof(HomeView).FullName, null, this);
        }
        private void RemoveCar()
        {
            NavigationService.Navigate(typeof(HomeView).FullName, null, this);
        }
        public CarService CarService { get; set; }
        public ObservableCollection<Car> Cars
        {
            get { return GetProperty(() => Cars); }
            set { SetProperty(() => Cars, value); }
        }

        public ICommand EditCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand RemoveCommand { get; set; }

        private INavigationService NavigationService => GetService<INavigationService>();
    }
}
