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

namespace les47._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Person Person { get; set; }
        public MainWindow()
        {
            Person = new Person() { Name = "Вася", Surname = "Пупкин", Age = 20, BirthDate = DateTime.Now.AddYears(-20).ToString() };
            InitializeComponent();
            DataContext = Person;
        }
    }
}