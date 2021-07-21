using SportApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SportApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalendarOfTraining : ContentPage
    {
        public CalendarOfTraining()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Frame boxView = sender as Frame;
            PowerTraining SelectedItem = (PowerTraining)boxView.BindingContext;

            System.Diagnostics.Debug.WriteLine(" clicked item = " + SelectedItem.DayOfTraining);
        }
    }
}