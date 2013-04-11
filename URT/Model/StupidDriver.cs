using URT.ViewModel;

namespace URT.Model
{
    class StupidDriver: IDriver
    {
        private readonly double _comfortVelocity;
        private double _targetVelocity = 0.2d;
        private const double MaxAceleration = 0.1d;
        private const double ComfortDistance = 0.05d;

        public StupidDriver(double comfortVelocity)
        {
            _comfortVelocity = comfortVelocity;
            _targetVelocity = _comfortVelocity;
        }

        public double GetAcceleration(Car car, Car next, ITrack track)
        {
            var distance = track.Distance(car, next);
            if (distance < ComfortDistance)
            {
                _targetVelocity = next.Velocity / 2;
            }
            if (distance > ComfortDistance * 5)
            {
                _targetVelocity = _comfortVelocity;
            }
            var a = (_targetVelocity - car.Velocity);
            if (a > MaxAceleration) a = MaxAceleration;
            if (a < -MaxAceleration) a = -MaxAceleration;
            return a;
        }
    }
}