namespace URT.Model
{
    class Car
    {
        private readonly IDriver _driver;

        public Car(IDriver driver)
        {
            _driver = driver;
        }
    }
}
