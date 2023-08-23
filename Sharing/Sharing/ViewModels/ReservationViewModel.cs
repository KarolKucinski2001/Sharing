using Sharing.Models;
using Sharing.ViewModels;
using System.Windows.Input;
using System;
using Xamarin.Forms;

namespace Sharing.ViewModels
{
    public class ReservationViewModel : BaseViewModel
    {
        private ChargingPointModel chargingPoint;

        public DateTime SelectedReservationTime { get; set; }
        public double ReservationPrice { get; set; }
        public ICommand ReserveCommand { get; }

        public ReservationViewModel()
        {
            // Domyślny konstruktor bez parametrów
            ReserveCommand = new Command(Reserve);
        }

        public ReservationViewModel(ChargingPointModel chargingPoint)
        {
            this.chargingPoint = chargingPoint;
            ReserveCommand = new Command(Reserve);
        }

        public void Reserve()
        {
            // Tutaj możesz dodać logikę rezerwacji ładowarki, używając chargingPoint, SelectedReservationTime i ReservationPrice
            // ...

            // Po zakończeniu rezerwacji możesz wrócić do listy ładowarek
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}