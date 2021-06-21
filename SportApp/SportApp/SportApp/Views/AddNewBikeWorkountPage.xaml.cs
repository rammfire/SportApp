using SportApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SportApp.Models;

namespace SportApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNewBikeWorkountPage : ContentPage
    {
        public Item Item { get; set; }
        public AddNewBikeWorkountPage()
        {
            InitializeComponent();
            BindingContext = new AddNewBikeWorkountViewModel();
        }
    }
}