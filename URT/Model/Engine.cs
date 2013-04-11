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

        private double Unwrap(double p)
        {
            var length = _track.Length;
            while (p < 0) p += length;
            while (p > length) p -= length;
            return p;
        }

        public void Update(TimeSpan dt)
        {
            var carsByPosition = _cars.OrderBy(c => Unwrap(c.Position)).ToList();

            for (int i = 0; i < carsByPosition.Count; i++)
            {
                int nextIndex = (i + 1 == carsByPosition.Count) ? 0 : i + 1;
                carsByPosition[i].Drive(carsByPosition[nextIndex]);
            }

            foreach (var car in _cars)
            {
                car.Update(dt);
            }
        }
    }
}
