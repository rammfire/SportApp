using System;
using System.Collections.Generic;
using SportApp.ViewModels;
using SportApp.Views;
using Xamarin.Forms;

namespace SportApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(AddNewBikeWorkountPage), typeof(AddNewBikeWorkountPage));
        }

    }
}
