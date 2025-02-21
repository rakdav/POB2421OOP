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

namespace Lesson46
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isGradient;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isGradient = !isGradient)
            {
                var gradientBrush = new RadialGradientBrush(Colors.Black, Colors.Blue);
                Resources["EllipseGradient"] = gradientBrush;
            }
            else
            {
                GradientStopCollection gradientStops = new GradientStopCollection();
                gradientStops.Add(new GradientStop(Colors.Yellow, 0.1));
                gradientStops.Add(new GradientStop(Colors.Red, 0.5));
                gradientStops.Add(new GradientStop(Colors.Green, 1.0));
                var gradientBrush = new RadialGradientBrush(gradientStops);
                Resources["EllipseGradient"] = gradientBrush;
            }
        }
    }
}