using System;
using System.Collections.Generic;

namespace URT.Model
{
    class Engine
    {
        private readonly IList<Car> _cars = new List<Car>();
        public IList<Car> Cars { get { return _cars; } }

        public void Update(TimeSpan dt)
        {
            foreach (var car in _cars)
            {
                car.Drive();
            }

            foreach (var car in _cars)
            {
                car.Update(dt);
            }
        }
    }
}
