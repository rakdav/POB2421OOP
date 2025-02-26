using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lesson47._3.View
{
    /// <summary>
    /// Логика взаимодействия для PhoneView.xaml
    /// </summary>
    public partial class PhoneView : Window
    {
        public Phone Phone { get; private set; }
        public PhoneView(Phone phone)
        {
            InitializeComponent();
            Phone = phone;
            DataContext = Phone;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
