using System;
using System.ComponentModel;
using Sharing.Models;
using Sharing.Services;
using Xamarin.Forms;


namespace Sharing.ViewModels
{
    public class CreateAccountViewModel2 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                if (username != value)
                {
                    username = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Username)));
                }
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Password)));
                }
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
                }
            }
        }

        private string errorMessage;
        public string ErrorMessage
        {
            get { return errorMessage; }
            set
            {
                if (errorMessage != value)
                {
                    errorMessage = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ErrorMessage)));
                }
            }
        }

        private Command createAccountCommand;
        public Command CreateAccountCommand
        {
            get { return createAccountCommand; }
            set { createAccountCommand = value; }
        }

        private readonly ILoginService loginService;

        public CreateAccountViewModel2()
        {
            loginService = DependencyService.Get<ILoginService>();
            CreateAccountCommand = new Command(OnCreateAccountCommand);
        }

        private void OnCreateAccountCommand()
        {
            if (App.Database.DoesUserExist(Username))
            {
                ErrorMessage = "Username already exists";
                return;
            }

            var newUser = new UserModel
            {
                UserName = Username,
                Password = Password,
                Email = Email
            };

            App.Database.InsertUser(newUser);
            ErrorMessage = "Succesfuly created";
        }
    }
}
