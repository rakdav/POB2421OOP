using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lesson47._3
{
    public class Phone : INotifyPropertyChanged
    {
        private string title;
        private string company;
        private int price;
        public string Title
        {
            get => title;
            set
            {
                title= value;
                OnProperyChanged(nameof(Title));
            }
        }
        public string Company
        {
            get => company;
            set
            {
                company = value;
                OnProperyChanged(nameof(Company));
            }
        }
        public int Price
        {
            get => price;
            set
            {
                price = value;
                OnProperyChanged(nameof(Price));
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnProperyChanged([CallerMemberName] string prop = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
