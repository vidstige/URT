using System.Collections.ObjectModel;

namespace URT.ViewModel
{
    class MainViewModel: ViewModel
    {
        private readonly ObservableCollection<CarViewModel> _cars = new ObservableCollection<CarViewModel>();
        private Track _track;

        public MainViewModel()
        {
            _track = new Track();
        }

        public ObservableCollection<CarViewModel> Cars { get { return _cars; } }

        public Track Track
        {
            get { return _track; }
        }
    }
}
