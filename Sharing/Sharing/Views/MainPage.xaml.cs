using Sharing.ViewModels;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Map = Xamarin.Forms.Maps.Map;

namespace Sharing.Views
{
    public partial class MainPage : ContentPage
    {
       // private Map map;

        public MainPage()
        {
            InitializeComponent();

            // Ustaw kontekst danych na instancję modelu widoku
            this.BindingContext = new MainPageViewModel();
        }

        //private async void YourView_Clicked(object sender, EventArgs e)
        //{
        //    // Check if location permission is granted
        //    var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
        //    if (status != PermissionStatus.Granted)
        //    {
        //        // Request permission if not granted
        //        status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
        //        if (status != PermissionStatus.Granted)
        //            return;
        //    }

        //    // Get the current location
        //    var location = await Geolocation.GetLocationAsync();
        //    if (location == null)
        //        return;

        //    // Create a new map instance if not already created
        //    if (map == null)
        //    {
        //        map = new Map
        //        {
        //            MapType = MapType.Street
        //        };

        //        // Add the map to the grid
        //        Grid grid = (Grid)this.Content;
        //        grid.Children.Add(map);
        //    }

        //    // Set the map's initial position to the current location
        //    map.MoveToRegion(MapSpan.FromCenterAndRadius(
        //        new Position(location.Latitude, location.Longitude),
        //        Distance.FromKilometers(1)));
        //}
    }
}
