using SportApp.Models;
using SportApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SportApp.ViewModels
{
    public class CiclingViewModel : BaseViewModel
    {
        public ObservableCollection<Cicling> Ciclings { get; set; }

        public Command AddNewRide { get; }

        public CiclingViewModel()
        {
            AddNewRide = new Command(OnAddItem);
        }

        private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync(nameof(AddNewBikeWorkountPage));
        }
    }
}
