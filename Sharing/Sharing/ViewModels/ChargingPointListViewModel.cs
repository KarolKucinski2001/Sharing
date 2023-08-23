using Sharing.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sharing.ViewModels
{
    public class ChargingPointListViewModel : BaseViewModel
    {
        public ObservableCollection<ChargingPointModel> ChargingPoints { get; set; } = new ObservableCollection<ChargingPointModel>();

        public ChargingPointListViewModel()
        {
            LoadChargingPoints();
            ReserveChargingPointCommand = new Command(ReserveChargingPoint);
        }

        private ChargingPointModel selectedChargingPoint;
        private DateTime selectedReservationTime;
        private double reservationPrice;

        public ChargingPointModel SelectedChargingPoint
        {
            get { return selectedChargingPoint; }
            set { SetProperty(ref selectedChargingPoint, value); }
        }

        public DateTime SelectedReservationTime
        {
            get { return selectedReservationTime; }
            set { SetProperty(ref selectedReservationTime, value); }
        }

        private void LoadChargingPoints()
        {
            // Wczytaj istniejące ładowarki z bazy danych lub innej usługi
            var chargingPoints = App.Database.GetChargingPoints();

            // Wyczyść kolekcję i dodaj wczytane ładowarki
            ChargingPoints.Clear();
            foreach (var chargingPoint in chargingPoints)
            {
                ChargingPoints.Add(chargingPoint);
            }
        }

        public ICommand ReserveChargingPointCommand { get; }

        private async void ReserveChargingPoint()
        {
            if (SelectedChargingPoint != null)
            {
                // Tutaj możesz dodać logikę do sprawdzania dostępności ładowarki, np. czy jest dostępna w wybranym czasie.
                // Pamiętaj, że ta część logiki zależy od implementacji rezerwacji w Twojej aplikacji.

                // Sprawdź dostępność ładowarki
                bool isAvailable = await CheckChargingPointAvailability(SelectedChargingPoint, SelectedReservationTime);

                if (isAvailable)
                {
                    // Jeśli ładowarka jest dostępna, utwórz nową rezerwację
                    var reservation = new ReservationModel
                    {
                        ChargingPointId = SelectedChargingPoint.ChargingPointId,
                        ReservationTime = SelectedReservationTime,
                        //Price = ReservationPrice
                        // Dodaj inne właściwości rezerwacji, jeśli są potrzebne
                    };

                    // Dodaj rezerwację do bazy danych
                    App.Database.InsertReservation(reservation);

                    // Dodaj rezerwację do ładowarki
                    SelectedChargingPoint.Reservations.Add(reservation);

                    // Aktualizuj ładowarkę w bazie danych
                    App.Database.UpdateReservation(reservation);

                    // Aktualizuj widok
                    LoadChargingPoints();
                }
                else
                {
                    // Ładowarka jest niedostępna w wybranym czasie
                    await Application.Current.MainPage.DisplayAlert("Błąd", "Ładowarka jest niedostępna w wybranym czasie.", "OK");
                }
            }
        }

        private async Task<bool> CheckChargingPointAvailability(ChargingPointModel chargingPoint, DateTime reservationTime)
        {
            // Tutaj możesz zaimplementować logikę sprawdzania dostępności ładowarki,
            // na przykład sprawdzić, czy nie ma już innej rezerwacji w danym czasie.
            // Zwróć true, jeśli ładowarka jest dostępna, lub false, jeśli jest zajęta w danym czasie.

            // Przykładowa implementacja:
            // Załóżmy, że ładowarka jest dostępna, jeśli nie ma żadnych innych rezerwacji w danym czasie.
            var reservations = chargingPoint.Reservations;
            bool isAvailable = !reservations.Any(r => r.ReservationTime == reservationTime);

            return isAvailable;
        }
    }
}
