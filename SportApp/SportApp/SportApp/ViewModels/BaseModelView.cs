using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SportApp.ViewModels
{
    public class BaseModelView : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
