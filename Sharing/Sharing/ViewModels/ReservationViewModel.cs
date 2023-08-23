using System;
using System.Collections.Generic;
using System.Text;

namespace Sharing.ViewModels
{
    using System;
    using System.Windows.Input;
    using Xamarin.Forms;

    namespace Sharing.ViewModels
    {
        public class ReservationViewModel : BaseViewModel
        {
            private DateTime selectedReservationTime;
            private double reservationPrice;

            public DateTime SelectedReservationTime
            {
                get { return selectedReservationTime; }
                set { SetProperty(ref selectedReservationTime, value); }
            }

            public double ReservationPrice
            {
                get { return reservationPrice; }
                set { SetProperty(ref reservationPrice, value); }
            }

            public ICommand ReserveCommand { get; }

            public ReservationViewModel()
            {
                ReserveCommand = new Command(Reserve);
            }

            private void Reserve()
            {
                // Tutaj umieść logikę rezerwacji ładowarki, używając SelectedReservationTime i ReservationPrice
            }
        }
    }

}
