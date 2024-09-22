using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace практика_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Car> cars {  get; set; }
        public MainWindow()
        {
            InitializeComponent();
            cars = new List<Car>();
            CarsDataGrid.ItemsSource = cars;
        }

        private void AddCarButton_Click(object sender, RoutedEventArgs e)
        {
            string CarMake = CarMakeTextBox.Text;
            string Model = ModelTextBox.Text;
            string YearOfManufacture = YearOfManufactureTextBox.Text;

            Car newCar = new Car
            {
                CarMake = CarMake,
                Model = Model,
                YearOfManufacture = YearOfManufacture
            };

            cars.Add(newCar);
            CarMakeTextBox.Clear();
            ModelTextBox.Clear();
            YearOfManufactureTextBox.Clear();
        }
    }
    public class Car
    {
        public string CarMake { get; set; }
        public string Model { get; set; }
        public string YearOfManufacture { get; set; }
    }

}