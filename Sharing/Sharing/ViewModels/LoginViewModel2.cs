using Sharing.Services;
using Sharing.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Sharing.ViewModels
{
    public class LoginViewModel2 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Command cmdLogin { get; set; }
        public Command cmdCreateAccount { get; set; }
        public Command cmdForgotPassword { get; set; }
        public Command cmdSetting { get; set; }

        ILoginService ilog = DependencyService.Get<ILoginService>();    

        public LoginViewModel2()
        {
            cmdLogin = new Command(goToMainPage);
            cmdCreateAccount = new Command(goToCreateAccount);
            cmdForgotPassword = new Command(goToSetting);
            cmdSetting = new Command(goToSetting);
        }

        private void goToSetting(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new SettingPage());
        }

        private void goToCreateAccount(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new CreateAccountPage2());
        }

        private void goToMainPage(object obj)
        {
            if(ilog.login(UserName, Password))
            {
                App.Current.MainPage.Navigation.PushAsync(new MainPage());
            }
            else
            {
                LoginMessage = "Please enter valid user name and password";
                TurnLoginMessage = true;
            }
        }

        ///---------------------------------------
        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserName"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
            }
        }
        private string loginMessage;
        public string LoginMessage
        {
            get { return loginMessage; }
            set
            {
                loginMessage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LoginMessage"));
            }
        }

        private bool turnLoginMessage = false;
        public bool TurnLoginMessage
        {
            get { return turnLoginMessage; }
            set
            {
                turnLoginMessage = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TurnLoginMessage"));
            }
        }
    }
}
