using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URT.Model
{
    class Car: ViewModel
    {
        private readonly IDriver _driver;
        private double _x;
        private double _y;
        private int p1;
        private int p2;

        public Car(double x, double y, IDriver driver)
        {
            _x = x;
            _y = y;
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
