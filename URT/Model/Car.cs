namespace URT.Model
{
    class Car
    {
        private readonly IDriver _driver;
        private double _position;

        public Car(IDriver driver, double position)
        {
            _driver = driver;
            _position = position;
        }

        public double Position
        {
            get { return _position; }
        }
    }
}
