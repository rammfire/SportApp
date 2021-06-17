using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SportApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            ShowMessage = new Command(async () => await Browser.OpenAsync("https://tcmk74.ru"));
        }



        public ICommand ShowMessage { get; }
        public ICommand OpenWebCommand { get; }
    }
}