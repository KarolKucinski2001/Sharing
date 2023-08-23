using Sharing.Models;
using Sharing.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sharing.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChargingPointListPage : ContentPage
    {
        public ChargingPointListPage( )
        {
            InitializeComponent();
            BindingContext = new ChargingPointListViewModel();
        }

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