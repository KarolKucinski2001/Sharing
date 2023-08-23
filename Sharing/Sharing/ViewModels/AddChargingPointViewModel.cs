using System.ComponentModel;
using Sharing.Models;
using Sharing.Services;
using Xamarin.Forms;

namespace Sharing.ViewModels
{
    public class AddChargingPointViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int pricePerHour;
        public int PricePerHour
        {
            get { return pricePerHour; }
            set
            {
                if (pricePerHour != value)
                {
                    pricePerHour = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PricePerHour)));
                }
            }
        }

        private int chargingPointId;
        public int ChargingPointId
        {
            get { return chargingPointId; }
            set
            {
                if (chargingPointId != value)
                {
                    chargingPointId = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ChargingPointId)));
                }
            }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set
            {
                if (address != value)
                {
                    address = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Address)));
                }
            }
        }

        private int slots;
        public int Slots
        {
            get { return slots; }
            set
            {
                if (slots != value)
                {
                    slots = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Slots)));
                }
            }
        }

        private Command addChargingPointCommand;
        public Command AddChargingPointCommand
        {
            get { return addChargingPointCommand; }
            set { addChargingPointCommand = value; }
        }

        public AddChargingPointViewModel()
        {
            AddChargingPointCommand = new Command(OnAddChargingPointClicked);
        }

        private void OnAddChargingPointClicked()
        {
            // Tworzenie nowej ładowarki na podstawie wprowadzonych danych
            var newChargingPoint = new ChargingPointModel
            {
                ChargingPointId = ChargingPointId,
                Address = Address,
                Slots = Slots,
                PricePerHour=PricePerHour
               
            };

            // Dodaj nową ładowarkę do bazy danych lub innej usługi zarządzającej danymi ładowarki
            App.Database.InsertChargingPoint(newChargingPoint);
           

            // Wyczyść pola po dodaniu
            ChargingPointId = 0;
            Address = string.Empty;
            Slots = 0;
            PricePerHour = 25;

            // Wyślij wiadomość lub zaktualizuj widok, aby potwierdzić dodanie ładowarki
            //MessagingCenter.Send(this, "ChargingPointAdded");
        }
    }
}
