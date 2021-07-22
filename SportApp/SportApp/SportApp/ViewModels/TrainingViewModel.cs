using System.Collections.ObjectModel;
using System;
using SportApp.Models;
using Xamarin.Forms;
using System.Windows.Input;

namespace SportApp.ViewModels
{
    public class TrainingViewModel : BaseModelView
    {
        public Command SaveCommand { get; }

        string dateTime = DateTime.Now.ToString("U");
        ObservableCollection<PowerTraining> powerTrainings;

        public ObservableCollection<PowerTraining> PowerTrainings { get { return powerTrainings; } set { powerTrainings = value; OnPropertyChanged(); } }
        public ICommand TypeListSelectedCommand => new Command<PowerTraining>(selectedItem);

        void selectedItem(PowerTraining obj)
        {
            PowerTraining item = obj as PowerTraining;

            System.Diagnostics.Debug.WriteLine("clicked item = " + item.DayOfTraining);
        }
        public TrainingViewModel()
        {
                PowerTrainings = new ObservableCollection<PowerTraining>();
                for (int i = 0; i < 20; i++)
                {
                    PowerTrainings.Add(new PowerTraining() { DayOfTraining = dateTime });
                }
        }
    }
}
