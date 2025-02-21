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

namespace Les46._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            //myRectangle.Style.Setters.Clear();
            Style existingStyle = (Style)this.Resources["rectangleStyle"];
            Style newStyle = new Style(typeof(System.Windows.Shapes.Rectangle),existingStyle);
            Setter[] styleSetters = new Setter[]
            {
                new Setter(Shape.FillProperty, new SolidColorBrush(Colors.Blue)),
                new Setter(WidthProperty, 250.0),
                new Setter(HeightProperty, 200.0),
            };
            foreach (Setter setter in styleSetters)
            {
                newStyle.Setters.Add(setter);
            }
            myRectangle.Style = newStyle;
        }
    }
}