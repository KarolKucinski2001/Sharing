using Sharing.Models;
using Sharing.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sharing.ViewModels
{
    public class AddChargingPointsViewModel:BaseViewModel
    {
        public ICommand AddChargingPointCommand { get; }

        private ChargingPoint newChargingPoint;
        public ChargingPoint NewChargingPoint
        {
            get => newChargingPoint;
            set
            {
                newChargingPoint = value;
                OnPropertyChanged(nameof(NewChargingPoint));
            }
        }
        private string successMessage;
        public string SuccessMessage
        {
            get => successMessage;
            set
            {
                successMessage = value;
                OnPropertyChanged(nameof(SuccessMessage));
            }
        }

        private string errorMessage;
        public string ErrorMessage
        {
            get => errorMessage;
            set
            {
                errorMessage = value;
                OnPropertyChanged(nameof(ErrorMessage));
            }
        }
        public AddChargingPointsViewModel()
        {
            NewChargingPoint = new ChargingPoint();
            AddChargingPointCommand = new Command(AddChargingPoint);
        }

        private async void AddChargingPoint()
        {
            // Sprawdź czy wszystkie wymagane pola są wypełnione
            if (string.IsNullOrWhiteSpace(NewChargingPoint.Name) ||
                string.IsNullOrWhiteSpace(NewChargingPoint.Address) ||
                string.IsNullOrWhiteSpace(NewChargingPoint.City) ||
                string.IsNullOrWhiteSpace(NewChargingPoint.PostalCode) ||
                NewChargingPoint.Latitude == 0 ||
                NewChargingPoint.Longitude == 0 ||
                string.IsNullOrWhiteSpace(NewChargingPoint.ChargerType) ||
                NewChargingPoint.Power == 0 ||
                string.IsNullOrWhiteSpace(NewChargingPoint.ContactInfo) ||
                NewChargingPoint.Cost == 0)
            {
                ErrorMessage = "Wypełnij wszystkie wymagane pola.";
                SuccessMessage = string.Empty;
                return;
            }

            var dataService = new DataService();
            await dataService.AddChargingPointAsync(NewChargingPoint);

            SuccessMessage = "Punkt ładowania został pomyślnie dodany.";
            ErrorMessage = string.Empty;
            

            // Po dodaniu punktu ładowania możesz wyczyścić pola lub zaimplementować odpowiednią nawigację
            NewChargingPoint = new ChargingPoint();
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
    //private string chargingPointName;
    //public string ChargingPointName
    //{
    //    get => chargingPointName;
    //    set => SetProperty(ref chargingPointName, value);
    //}

    //private string address;
    //public string Address
    //{
    //    get => address;
    //    set => SetProperty(ref address, value);
    //}

    //private string city;
    //public string City
    //{
    //    get => city;
    //    set => SetProperty(ref city, value);
    //}

    //private string postalCode;
    //public string PostalCode
    //{
    //    get => postalCode;
    //    set => SetProperty(ref postalCode, value);
    //}

    //// Pozostałe właściwości

    //public ICommand AddChargingPointCommand { get; }
    //public ICommand CancelCommand { get; }

    //public AddChargingPointsViewModel()
    //{
    //    AddChargingPointCommand = new Command(async () => await AddChargingPoint());
    //    CancelCommand = new Command(async () => await Cancel());
    //}

    //private async Task AddChargingPoint()
    //{
    //    if (IsBusy)
    //        return;

    //    IsBusy = true;

    //    try
    //    {
    //        // Upewnij się, że pola są wypełnione
    //        if (string.IsNullOrWhiteSpace(ChargingPointName) ||
    //            string.IsNullOrWhiteSpace(Address) ||
    //            string.IsNullOrWhiteSpace(City) ||
    //            string.IsNullOrWhiteSpace(PostalCode))
    //        {
    //            // Obsłuż brak wymaganych danych
    //            return;
    //        }

    //        // Tworzenie obiektu ChargingPoint
    //        var newChargingPoint = new ChargingPoint(ChargingPointName, Address, City, PostalCode);

    //        // Tutaj możesz kontynuować z logiką dodawania punktu ładowania do bazy danych lub serwisu
    //        // np. DataStore.AddChargingPoint(newChargingPoint);

    //        // Po dodaniu punktu ładowania możesz nawigować użytkownika z powrotem lub do innych widoków
    //    }
    //    catch (Exception ex)
    //    {
    //        // Obsłuż błędy
    //    }
    //    finally
    //    {
    //        IsBusy = false;
    //    }
    //}

    //private async Task Cancel()
    //{
    //    // Tutaj nawiguj użytkownika z powrotem, np. za pomocą DependencyService
    //}
    //public Command cmdAddchargingPoint { get; set; }

    //public AddChargingPointsViewModel()
    //{
    //    cmdAddchargingPoint = new Command(addChargingPoint);
    //}

    //private void addChargingPoint(object obj)
    //{
    //    throw new NotImplementedException();
    //}
}

