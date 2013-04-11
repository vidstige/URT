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

        public void Drive(Car car)
        {
            double a = _driver.GetAcceleration(this, car);
            _velocity += a;
        }

        public void Update(TimeSpan dt)
        {
            _position += _velocity * dt.TotalSeconds;

            var tmp = PositionUpdated;
            if (tmp != null) tmp(this);
        }
    }
}
