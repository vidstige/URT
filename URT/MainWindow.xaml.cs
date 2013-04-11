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
            vm.Cars.Add(new CarViewModel(10, 10, null));
            vm.Cars.Add(new CarViewModel(20, 30, null));
            vm.Cars.Add(new CarViewModel(30, 80, null));
            DataContext = vm;
        }
    }
}
