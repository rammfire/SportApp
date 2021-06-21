using System;
using System.Collections.Generic;
using System.Text;

namespace SportApp.ViewModels
{
    public class AddNewBikeWorkountViewModel : BaseViewModel
    {
        DateTime dateTime;
        string timeOfStart;
        string timeOfEnd;
        string howLong;
        string dateTimeString;
        string routeName;
        string distance;

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; OnPropertyChanged(); }
        }
        public string TimeOfStart
        {
            get { return timeOfStart; }
            set { timeOfStart = value; OnPropertyChanged(); }
        }
        public string TimeOfEnd
        {
            get { return timeOfEnd; }
            set { timeOfEnd = value; OnPropertyChanged(); }
        }
        public string HowLong
        {
            get { return howLong; }
            set { howLong = value; OnPropertyChanged(); }
        }

        public string DateTimeString
        {
            get { return dateTimeString; }
            set { dateTimeString = value; OnPropertyChanged(); }
        }

        public AddNewBikeWorkountViewModel()
        {
            DateTimeString = DateTime.Today.ToString("D");
        }
    }
}
