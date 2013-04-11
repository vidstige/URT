using System;

namespace URT.Model
{
    class Car
    {
        private readonly IDriver _driver;
        private double _position;
        private double _velocity;

        public event Action<Car> PositionUpdated; 

        public Car(IDriver driver, double position)
        {
            _driver = driver;
            _position = position;
        }

        public double Position { get { return _position; } }
        public double Velocity { get { return _velocity; } }

        public void Drive(Car next, ITrack track)
        {
            double a = _driver.GetAcceleration(this, next, track);
            _velocity += a;
        }

        public void Update(TimeSpan dt, ITrack track)
        {
            _position += _velocity * dt.TotalSeconds;
            while (_position > track.Length) _position -= track.Length;

            var tmp = PositionUpdated;
            if (tmp != null) tmp(this);
        }
    }
}
