using System.Collections.ObjectModel;

namespace URT.Model
{
    class MainViewModel: ViewModel
    {
        private readonly ObservableCollection<Car> _cars = new ObservableCollection<Car>();
        public ObservableCollection<Car> Cars { get { return _cars; } }
    }
}
