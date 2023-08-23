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
    public partial class AddChargingPointPage2 : ContentPage
    {
        public AddChargingPointPage2()
        {
            InitializeComponent();
            BindingContext = new AddChargingPointViewModel();
        }
    }
}