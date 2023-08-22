using Sharing.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Sharing.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}