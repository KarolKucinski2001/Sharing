﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharing.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sharing.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddChargingPointPage : ContentPage
    {
        public AddChargingPointPage()
        {
            InitializeComponent();
            BindingContext = new AddChargingPointsViewModel();
        }
    }
}
