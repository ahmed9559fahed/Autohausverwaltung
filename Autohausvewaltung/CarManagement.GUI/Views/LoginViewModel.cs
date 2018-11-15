using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarManagement.GUI.Properties;
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
            //To Replace with icar service
            var canLogin = true;
            if (canLogin)
            {
                NavigationService.Navigate(typeof(CarsView).FullName, null, this);
            }
            else
            {
                MessageBox.Show(Resources.LoginViewModel_Login_UserName_or_Password_not_korrekt);
                UserName = Password = "";
            }


        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public DelegateCommand LoginCommand { get; set; }
        private INavigationService NavigationService => GetService<INavigationService>();
    }
}
