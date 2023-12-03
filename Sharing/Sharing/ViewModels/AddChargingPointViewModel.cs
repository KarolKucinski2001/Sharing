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
            AddChargingPointCommand = new Command(OnAddChargingPointCommand);
        }

        private void OnAddChargingPointCommand()
        {
            var newChargingPoint = new ChargingPointModel
            {
                ChargingPointId = ChargingPointId,
                Address = Address,
                Slots = Slots,
                PricePerHour=PricePerHour
               
            };

            App.Database.InsertChargingPoint(newChargingPoint);
            //App.Database.DeleteAllChargingPoints();
            ChargingPointId = 0;
            Address = string.Empty;
            Slots = 1;
            PricePerHour = 25;

        }
    }
}
