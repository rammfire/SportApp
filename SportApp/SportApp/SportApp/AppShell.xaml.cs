using System;
using System.Collections.Generic;
using Xamarin.Forms;
using SportApp.ViewModels;
using SportApp.Views;

namespace SportApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AnthropometryView), typeof(AnthropometryView));
        }

    }
}
