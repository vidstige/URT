using System.Windows;
using URT.Model;

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
            vm.Cars.Add(new Car(10, 10, null));
            vm.Cars.Add(new Car(20, 30, null));
            vm.Cars.Add(new Car(30, 80, null));
            DataContext = vm;
        }
    }
}
