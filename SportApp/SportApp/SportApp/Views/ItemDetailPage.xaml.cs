using System.ComponentModel;
using SportApp.ViewModels;
using Xamarin.Forms;

namespace SportApp.Views
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