namespace URT.Model
{
    interface IDriver
    {
        double GetAcceleration(Car car, Car nextCar);
    }
}
