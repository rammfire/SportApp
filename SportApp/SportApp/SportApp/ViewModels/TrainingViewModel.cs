﻿using System.Collections.ObjectModel;
using System;
using SportApp.Models;
namespace SportApp.ViewModels
{
    public class TrainingViewModel : BaseModelView
    {
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
