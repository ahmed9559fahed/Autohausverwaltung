using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using CarManagement.Business.Models;
using CarManagement.Business.Service;
using CarManagement.GUI.Properties;
using DevExpress.Mvvm;

namespace CarManagement.GUI.Views
{
    public class EditCarViewModel:ViewModelBase
    {
        public EditCarViewModel()
        {
            CarService=new CarService();
            SaveCommand=new DelegateCommand(Save);
            CancelCommand=new DelegateCommand(Cancel);
            LoadDataCommand=new DelegateCommand(Load);
        }

        private void Load()
        {
            if (Parameter != null)
            {
                var car = Parameter as Car;

                Type = car.Type;
                Model = car.Model;
                FirstName = car.FirstName;
                Name = car.Name;
                RegisterDate = car.RegisterDate;
                TuvUntil = car.TuvUntil;
                Price = car.Price;
                TelefonNr = car.TelefonNr;
                Color = car.Color;
                Address = car.Color;
                Id = car.Id;
                CostumerId = car.CostumerId;
            }
            else
            {
                RegisterDate = TuvUntil = DateTime.Now;
            }
        }


        private void Cancel()
        {
            NavigationService.Navigate(typeof(CarsView).FullName, null, this);
        }
        public ICommand LoadDataCommand { get; set; }
         
        private void Save()
        {

            var ifExist = CarService.GetCars().FirstOrDefault(x => x.Id == Id);
            if (ifExist != null)
            {
                CarService.UpdateCar(Id,new Car()
                {
                    Address = this.Address,
                    Color = this.Color,
                    CostumerId = Guid.NewGuid(),
                    FirstName = this.FirstName,
                    Name = this.Name,
                    Id = Guid.NewGuid(),
                    Model = this.Model,
                    Price = this.Price,
                    Type = this.Type,
                    RegisterDate = this.RegisterDate,
                    TuvUntil = this.TuvUntil,
                    TelefonNr = this.TelefonNr
                });
                NavigationService.Navigate(typeof(CarsView).FullName, null, this);
            }
            else
            {
                var result = CarService.AddCar(new Car()
                {
                    Address = this.Address,
                    Color = this.Color,
                    CostumerId = Guid.NewGuid(),
                    FirstName = this.FirstName,
                    Name = this.Name,
                    Id = Guid.NewGuid(),
                    Model = this.Model,
                    Price = this.Price,
                    Type = this.Type,
                    RegisterDate = this.RegisterDate,
                    TuvUntil = this.TuvUntil,
                    TelefonNr = this.TelefonNr
                });
                if (result)
                {

                    NavigationService.Navigate(typeof(CarsView).FullName, null, this);
                }
                else
                {
                    MessageBox.Show(Resources.EditCarViewModel_Save_Missing_Data);
                }
            }
        }
        private INavigationService NavigationService => GetService<INavigationService>();

        public string Type
        {
            get { return GetProperty(() => Type); }
            set { SetProperty(() => Type, value); }
        }

        public string Model {
            get { return GetProperty(() => Model); }
            set { SetProperty(() => Model, value); }
        }
        public string FirstName {
            get { return GetProperty(() => FirstName); }
            set { SetProperty(() => FirstName, value); }
        }
        public string Name {
            get { return GetProperty(() => Name); }
            set { SetProperty(() => Name, value); }
        }
        public string Address {
            get { return GetProperty(() => Address); }
            set { SetProperty(() => Address, value); }
        }
        public string TelefonNr {
            get { return GetProperty(() => TelefonNr); }
            set { SetProperty(() => TelefonNr, value); }
        }
        public DateTime TuvUntil {
            get { return GetProperty(() => TuvUntil); }
            set { SetProperty(() => TuvUntil, value); }
        } 
        public DateTime RegisterDate {
            get { return GetProperty(() => RegisterDate); }
            set { SetProperty(() => RegisterDate, value); }
        } 
        public string Color {
            get { return GetProperty(() => Color); }
            set { SetProperty(() => Color, value); }
        }
        public double Price {
            get { return GetProperty(() => Price); }
            set { SetProperty(() => Price, value); }
        }
        public Guid Id { get; set; }
        public Guid CostumerId { get; set; }
        public CarService CarService { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand CancelCommand { get; set; }

    }
}
