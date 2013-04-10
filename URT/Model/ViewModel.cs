using System.ComponentModel;

namespace URT.Model
{
    class ViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            var tmp = PropertyChanged;
            if (tmp != null) tmp(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
