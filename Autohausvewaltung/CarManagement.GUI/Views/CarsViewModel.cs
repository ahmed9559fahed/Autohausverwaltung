using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;
using CarManagement.Business.Models;
using CarManagement.Business.Service;
using CarManagement.GUI.Properties;
using DevExpress.Mvvm;


namespace CarManagement.GUI.Views
{
    public class CarsViewModel:ViewModelBase
    {
        public CarsViewModel()
        {
         
            CarService=new CarService();
            RefreshData();
            EditCommand=new DelegateCommand(EditCar);
            AddCommand = new DelegateCommand(AddCar);
            RemoveCommand = new DelegateCommand(RemoveCar);
        }

        private void EditCar()
        {
            if (SelectedCar != null)
            {
             OldSelectedCar = SelectedCar;
            NavigationService.Navigate(typeof(EditCarView).FullName, SelectedCar, this);
            RefreshData();
        }
            else
            {
                MessageBox.Show(Resources.CarsViewModel_EditCar_Select_Car_at_the_First);
            }
    }
        private void AddCar()
        {

            NavigationService.Navigate(typeof(EditCarView).FullName, null, this);
            RefreshData();
        }
        private void RemoveCar()
        {
             CarService.DeleteCar(SelectedCar.Id);
            RefreshData();
            SelectedCar = SelectedCar;
        }

        private void RefreshData()
        {
        
            Cars = new ObservableCollection<Car>(CarService.GetCars().ToList());
            SelectedCar = OldSelectedCar;
        }
        public CarService CarService { get; set; }
        public ObservableCollection<Car> Cars
        {
            get { return GetProperty(() => Cars); }
            set { SetProperty(() => Cars, value); }
        }

        public static Car OldSelectedCar;
        public Car SelectedCar
        {
            get { return GetProperty(() => SelectedCar); }
            set { SetProperty(() => SelectedCar, value); }
        }

        
        public ICommand EditCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand RemoveCommand { get; set; }

        private INavigationService NavigationService => GetService<INavigationService>();
    }
}
