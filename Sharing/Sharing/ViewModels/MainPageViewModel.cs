using Sharing.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sharing.ViewModels
{
    public class MainPageViewModel
    {
        public Command NavigateToAddChargingPointCommand { get; }
        public Command NavigateToSearchChargingPointsCommand { get; }
        public Command NavigateToYourChargingPointsCommand { get; }
        public Command LogoutCommand { get; }



        public MainPageViewModel()
        {
            NavigateToAddChargingPointCommand = new Command(goToNavigateToAddChargingPoint);
            NavigateToSearchChargingPointsCommand = new Command(goToNavigateToSearchChargingPointsCommand);
            NavigateToYourChargingPointsCommand = new Command(goToNavigateToYourChargingPointsCommand);
            LogoutCommand = new Command(goToLogoutCommand);
         
        }

        private void goToLogoutCommand(object obj)
        {
            //dodac strone do wylogowania
            App.Current.MainPage.Navigation.PushAsync(new SettingPage());
        }

        private void goToNavigateToYourChargingPointsCommand(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new SettingPage());
        }

        private void goToNavigateToSearchChargingPointsCommand(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new ChargingPointListPage());
        }

        private void goToNavigateToAddChargingPoint(object obj)
        {
            //App.Current.MainPage.Navigation.PushAsync(new AddChargingPointPage());
            App.Current.MainPage.Navigation.PushAsync(new AddChargingPointPage2());
        }

       
    }
}
