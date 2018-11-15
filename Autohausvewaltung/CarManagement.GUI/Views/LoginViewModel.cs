using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;



namespace CarManagement.GUI.Views
{
    public class LoginViewModel:ViewModelBase
    {
        public LoginViewModel()
        {
            LoginCommand = new DelegateCommand(Login);
        }


        private void Login()
        {
           
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public DelegateCommand LoginCommand { get; set; }
        private INavigationService NavigationService => GetService<INavigationService>();
    }
}
