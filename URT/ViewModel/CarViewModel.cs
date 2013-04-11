using System;
using URT.Model;

namespace URT.ViewModel
{
    class CarViewModel: ViewModel
    {
        private readonly Car _car;
        private readonly Track _track;

        public CarViewModel(Track track, Car car)
        {
            _track = track;
            _car = car;
            _car.PositionUpdated += CarOnPositionUpdated;
        }

        private void CarOnPositionUpdated(Car car)
        {
            RaisePropertyChanged("X");
            RaisePropertyChanged("Y");
            RaisePropertyChanged("Angle");
        }

        public double Angle
        {
            get { return _track.MapAngle(_car.Position); }
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
