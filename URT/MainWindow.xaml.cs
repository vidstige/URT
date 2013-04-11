using System;
using System.Windows;
using System.Windows.Threading;
using URT.Model;
using URT.ViewModel;

namespace URT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer _dispatcherTimer;
        private readonly StupidDriver _driver;
        private readonly Engine _engine;

        public MainWindow()
        {
            InitializeComponent();
            var vm = new MainViewModel();
            _driver = new StupidDriver();
            _engine = new Engine(vm.Track);
            _engine.Cars.Add(new Car(_driver, 0.2));
            _engine.Cars.Add(new Car(_driver, 0.4));
            _engine.Cars.Add(new Car(_driver, 0.8));
            foreach (var car in _engine.Cars)
            {
                vm.Cars.Add(new CarViewModel(vm.Track, car));
            }
            DataContext = vm;

            _dispatcherTimer = new DispatcherTimer(TimeSpan.FromMilliseconds(40), DispatcherPriority.Normal, Tick, Dispatcher);
            _dispatcherTimer.Start();
        }

        private class StupidDriver: IDriver
        {
            private const double TargetVelocity = 0.2d;
            private const double MaxAceleration = 0.1d;
            
            public double GetAcceleration(Car car, Car next)
            {
                var a = (TargetVelocity - car.Velocity);
                if (a > MaxAceleration) a = MaxAceleration;
                if (a < -MaxAceleration) a = -MaxAceleration;
                return a;
            }
        }

        private void Tick(object sender, EventArgs e)
        {
            _engine.Update(TimeSpan.FromMilliseconds(40));
        }
    }
}
