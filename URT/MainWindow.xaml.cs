using System.Windows;
using URT.Model;
using URT.ViewModel;

namespace URT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var vm = new MainViewModel();
            vm.Cars.Add(new CarViewModel(vm.Track, new Car(null, 0.2)));
            vm.Cars.Add(new CarViewModel(vm.Track, new Car(null, 0.4)));
            vm.Cars.Add(new CarViewModel(vm.Track, new Car(null, 0.8)));
            DataContext = vm;
        }
    }
}
