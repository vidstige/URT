using System.Collections.ObjectModel;
using URT.ViewModel;

namespace URT.Model
{
    class MainViewModel: ViewModel.ViewModel
    {
        private readonly ObservableCollection<CarViewModel> _cars = new ObservableCollection<CarViewModel>();
        public ObservableCollection<CarViewModel> Cars { get { return _cars; } }
    }
}
