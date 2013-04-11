using URT.Model;

namespace URT.ViewModel
{
    class CarViewModel: ViewModel
    {
        private readonly Car _car;
        private Track _track;

        public CarViewModel(Track track, Car car)
        {
            _track = track;
            _car = car;
        }

        public double Angle
        {
            get { return 0; }
        }

        public double X
        {
            get { return _track.MapX(_car.Position); }
        }
        public double Y
        {
            get { return _track.MapY(_car.Position); }
        }
    }

}
