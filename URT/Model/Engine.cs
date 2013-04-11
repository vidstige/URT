using System;
using System.Collections.Generic;
using System.Linq;

namespace URT.Model
{
    class Engine
    {
        private readonly ITrack _track;
        private readonly IList<Car> _cars = new List<Car>();
        
        public Engine(ITrack track)
        {
            _track = track;
        }

        public IList<Car> Cars { get { return _cars; } }

        public void Update(TimeSpan dt)
        {
            var carsByPosition = _cars.OrderBy(c => c.Position).ToList();

            for (int i = 0; i < carsByPosition.Count; i++)
            {
                int nextIndex = (i + 1 == carsByPosition.Count) ? 0 : i + 1;
                carsByPosition[i].Drive(carsByPosition[nextIndex], _track);
            }

            foreach (var car in _cars)
            {
                car.Update(dt, _track);
            }
        }
    }
}
