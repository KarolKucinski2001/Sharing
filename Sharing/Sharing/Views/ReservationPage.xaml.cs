using Xamarin.Forms;
using Sharing.ViewModels;
using Xamarin.Forms.Xaml;

namespace Sharing.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReservationPage : ContentPage
    {
        public ReservationPage(ReservationViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        // Reszta zawartości ReservationPage
    }
}
