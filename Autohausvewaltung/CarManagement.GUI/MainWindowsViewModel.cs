using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarManagement.GUI.Views;
using DevExpress.Mvvm;

namespace CarManagement.GUI
{
    public class MainWindowsViewModel:ViewModelBase
    {
        public MainWindowsViewModel()
        {
            HomeCommand = new DelegateCommand(() => NavigationService.Navigate(typeof(HomeView).FullName, null, this));
            Login = new DelegateCommand(() => NavigationService.Navigate(typeof(LoginView).FullName, null, this));
        }

        public DelegateCommand HomeCommand { get; set; }
        public DelegateCommand Login { get; set; }
        private INavigationService NavigationService => GetService<INavigationService>();
    }
   
}
