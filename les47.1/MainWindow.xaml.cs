using System.ComponentModel;
using System.Runtime.CompilerServices;
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
using System.Xml.Linq;

namespace les47._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Person> people = new();
        public Person Person { get; set; }
        
    private int next = 0;
        public MainWindow()
        {
            people.Add(new Person() { Name = "Вася", Surname = "Пупкин", Age = 20, BirthDate = DateTime.Now.AddYears(-20).ToString()});
            people.Add(new Person() { Name = "Боря", Surname = "Васильев", Age = 25, BirthDate = DateTime.Now.AddYears(-25).ToString() });
            people.Add(new Person() { Name = "Иван", Surname = "Соловьев", Age = 18, BirthDate = DateTime.Now.AddYears(-18).ToString() });
            InitializeComponent();
            Person = people[next];
            DataContext = Person;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person = people[++next];
            DataContext = Person;
        }
    }
}