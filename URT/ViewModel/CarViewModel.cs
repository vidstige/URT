using URT.Model;

namespace URT.ViewModel
{
    class CarViewModel: ViewModel
    {
        private double _x;
        private double _y;
        private readonly Car _car;

        public CarViewModel(double x, double y, Car car)
        {
            _x = x;
            _y = y;
            _car = car;
        }

        public double Angle
        {
            get { return 23; }
        }

        public double X
        {
            get { return _x; }
            private set
            {
                _x = value;
                RaisePropertyChanged("X");
            }
        }
        public double Y
        {
            get { return _y; }
            private set
            {
                _y = value;
                RaisePropertyChanged("Y");
            }
        }
    }

}
