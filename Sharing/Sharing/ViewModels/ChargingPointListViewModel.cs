using Sharing.Models;
using Sharing.ViewModels;
using Sharing.Views;
using Sharing;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Sharing.ViewModels
{
    public class ChargingPointListViewModel : BaseViewModel
    {
        public ObservableCollection<ChargingPointModel> ChargingPoints { get; set; } = new ObservableCollection<ChargingPointModel>();

        private ChargingPointModel selectedChargingPoint;

        public ChargingPointModel SelectedChargingPoint
        {
            get { return selectedChargingPoint; }
            set { SetProperty(ref selectedChargingPoint, value); }
        }

        public ChargingPointListViewModel()
        {
            LoadChargingPoints();
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

        // Obsługa zdarzenia ItemTapped
        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is ChargingPointModel selectedItem)
            {
                // Tutaj możesz wykonać działania na wybranym elemencie ChargingPointModel,
                // np. nawigować do innej strony lub wykonać inne operacje.
            }
        }
    }
}