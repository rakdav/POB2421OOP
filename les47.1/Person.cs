using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les47._1
{
    public class Person:INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get=>name;
            set
            {
                name=value;
                OnPropertyChanged("Name");
            }
        }
        private string surname;
        public string Surname
        {
            get => surname;
            set
            {
                surname = value;
                OnPropertyChanged("Surname");
            }
        }
        private int age;
        public int Age
        {
            get=> age;
            set
            {
                age = value;
                OnPropertyChanged("Age");
            }
        }
        private string birthDate;
        public string BirthDate
        {
            get => birthDate;
            set
            {
                birthDate = value;
                OnPropertyChanged("BirthDate");
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
