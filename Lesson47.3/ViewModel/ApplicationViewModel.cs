using Lesson47._3.Infrastructure.Commands;
using Lesson47._3.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ?? (addCommand=new RelayCommand(obj =>
                {
                    PhoneView phoneView = new PhoneView(new Phone());
                    if (phoneView.ShowDialog() == true)
                    {
                        Phone phone = phoneView.Phone;
                        Phones.Add(phone);
                        SelectedPhone = phone;
                    }
                }));
            }
        }
        private RelayCommand editCommand;
        public RelayCommand EditCommand
        {
            get
            {
                return editCommand ?? (editCommand = new RelayCommand((selectedItem) =>
                {
                    Phone? phone = selectedItem as Phone;
                    if (phone == null) return;
                    PhoneView phoneView = new PhoneView(phone);
                    if (phoneView.ShowDialog() == true)
                    {
                       if(Phones.Contains(phone))
                       {
                            int index = Phones.IndexOf(phone);
                            Phones[index].Title =  phoneView.Phone.Title;
                            Phones[index].Company = phoneView.Phone.Company;
                            Phones[index].Price = phoneView.Phone.Price;
                        }
                    }
                }));
            }
        }
        private RelayCommand deleteCommand;
        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ?? (deleteCommand = new RelayCommand((selectedItem) =>
                {
                    Phone? phone = selectedItem as Phone;
                    if (phone == null) return;
                    if (MessageBox.Show("Вы действительно хотите удалить элемент?","Внимание", MessageBoxButton.OKCancel,MessageBoxImage.Warning)==MessageBoxResult.OK)
                    {
                        if (Phones.Contains(phone))
                        {
                            int index = Phones.IndexOf(phone);
                            Phones.RemoveAt(index);
                        }
                    }
                }));
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
