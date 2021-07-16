using System.Collections.ObjectModel;
using System;
using SportApp.Models;
namespace SportApp.ViewModels
{
    public class TrainingViewModel : BaseModelView
    {
        string _tabIndex;
        public string TabIndex { get { return _tabIndex; } set { _tabIndex = value; OnPropertyChanged(); } }
        string dateTime = DateTime.Now.ToString("U");
        ObservableCollection<PowerTraining> powerTrainings;

        public ObservableCollection<PowerTraining> PowerTrainings { get { return powerTrainings; } set { powerTrainings = value; OnPropertyChanged(); } }

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
