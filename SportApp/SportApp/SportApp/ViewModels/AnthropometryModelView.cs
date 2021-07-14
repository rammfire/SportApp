using System.Collections.ObjectModel;
using SportApp.Models;
using Xamarin.Forms;
using System.IO;
using System.Text.Json;
using Xamarin.Essentials;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SportApp.ViewModels
{
    class AnthropometryModelView : INotifyPropertyChanged 
    {
        public ObservableCollection<Person> _Person;

        string output;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public string OutPut
        {
            get
            {
                return output;
            }
            set
            {
                output = value;
                OnPropertyChanged();
            }
        }
        public Command SaveCommand { get; }

        public void Serialize()
        {
            _Person = new ObservableCollection<Person>();
            _Person.Add(new Person() { Abdomen = "90", Ankles = "10" });

            string fileName = FileSystem.AppDataDirectory + "WeatherForecast.json";
            string jsonString = JsonSerializer.Serialize(_Person);
            File.WriteAllText(fileName, jsonString);
            Debug.WriteLine(FileSystem.AppDataDirectory);
            OutPut = FileSystem.AppDataDirectory + "WeatherForecast.json";
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(ObservableCollection<Person>));

            //using (StreamWriter sw = new StreamWriter("persons.xml"))
            //{
            //    xmlSerializer.Serialize(sw, _Person);
            //}
        }

        public AnthropometryModelView()
        {
            SaveCommand = new Command(Serialize);
            OutPut = "Hello";
        }
    }
}
