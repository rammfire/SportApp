using SportApp.Models;
using Xamarin.Forms;
using System.IO;
using System.Xml.Serialization;

namespace SportApp.ViewModels
{
    class AnthropometryModelView : BaseModelView
    {
        public Command SaveCommand { get; }

        string _wrist;
        string _forearm;
        string _biceps;
        string _neck;
        string _shoulderGirdle;
        string _chest;
        string _abdomen;
        string _pelvis;
        string _hips;
        string _ankles;

        public string Wrist { get { return _wrist; } set { _wrist = value; OnPropertyChanged(); } }
        public string Forearm { get { return _forearm; } set { _forearm = value; OnPropertyChanged(); } }
        public string Biceps { get { return _biceps; } set { _biceps = value; OnPropertyChanged(); } }
        public string Neck { get { return _neck; } set { _neck = value; OnPropertyChanged(); } }
        public string ShoulderGirdle { get { return _shoulderGirdle; } set { _shoulderGirdle = value; OnPropertyChanged(); } }
        public string Chest { get { return _chest; } set { _chest = value; OnPropertyChanged(); } }
        public string Abdomen { get { return _abdomen; } set { _abdomen = value; OnPropertyChanged(); } }
        public string Pelvis { get { return _pelvis; } set { _pelvis = value; OnPropertyChanged(); } }
        public string Hips { get { return _hips; } set { _hips = value; OnPropertyChanged(); } }
        public string Ankles { get { return _ankles; } set { _ankles = value; OnPropertyChanged(); } }

        public void Serialize()
        {

            Person pers = new Person() { Wrist = this.Wrist, Forearm = this.Forearm, Biceps = this.Biceps,
                                         Neck = this.Neck, ShoulderGirdle = this.ShoulderGirdle, Chest = this.Chest,
                                         Abdomen = this.Abdomen, Pelvis = this.Pelvis, Hips = this.Hips, Ankles = this.Ankles};
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

            using (StreamWriter sw = new StreamWriter("/storage/emulated/0/Android/data/com.companyname.sportapp/cache/persons.xml"))
            {
                xmlSerializer.Serialize(sw, pers);
            }
        }

        public void Deserialize()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));
                Person pers = new Person();

                using (StreamReader sr = new StreamReader("/storage/emulated/0/Android/data/com.companyname.sportapp/cache/persons.xml"))
                {
                    pers = xmlSerializer.Deserialize(sr) as Person;
                    Wrist = pers.Wrist; Forearm = pers.Forearm; Biceps = pers.Biceps;
                    Neck = pers.Neck; ShoulderGirdle = pers.ShoulderGirdle; Chest = pers.Chest;
                    Abdomen = pers.Abdomen; Pelvis = pers.Pelvis; Hips = pers.Hips; Ankles = pers.Ankles;
                }
            }
            catch (System.Exception)
            {

            }
        }

        public AnthropometryModelView()
        {
            SaveCommand = new Command(Serialize);
            Deserialize();
        }
    }
}
