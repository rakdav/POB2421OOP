using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson47._3
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        private Phone? selectedPhone;
        public Phone? SelectedPhone
        {
            get => selectedPhone;
            set
            {
                selectedPhone = value;
                OnProperyChanged(nameof(SelectedPhone));
            }
        }
        public ObservableCollection<Phone> Phones { get; set; }
        public ApplicationViewModel()
        {
            Phones = new ObservableCollection<Phone>
            {
                new Phone{Title="Samsung A55",Company="Samsung",Price=40000},
                new Phone{Title="Galaxy s10",Company="Samsung",Price=90000},
                new Phone{Title="IPhone 14",Company="Apple",Price=75000},
                new Phone{Title="IPhone 15",Company="Apple",Price=120000}
            };
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnProperyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
