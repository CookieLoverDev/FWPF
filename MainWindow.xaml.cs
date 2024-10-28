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

namespace Counter___Color_Picker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int userValue;
        public string userText {  get; set; }

        public MainWindow()
        {
            InitializeComponent();
            userValue = 0;
            userText = "Current Value: ";
            DataContext = this;
        }

        public void IncreaseButton(object sender, RoutedEventArgs e)
        {
            userValue++;
            ValueText.Text = userText + userValue;
        }

        public void DecreaseButton(object sender, RoutedEventArgs e)
        {
            userValue--;
            ValueText.Text = userText + userValue;
        }

        public void ChangeBlue(object sender, RoutedEventArgs e)
        {
            MainGrid.Background = new SolidColorBrush(Colors.Blue);
        }

        public void ChangeGreen(object sender, RoutedEventArgs e)
        {
            MainGrid.Background = new SolidColorBrush(Colors.Green);
        }

        public void ChangeYellow(object sender, RoutedEventArgs e)
        {
            MainGrid.Background = new SolidColorBrush(Colors.Yellow);
        }
    }
}