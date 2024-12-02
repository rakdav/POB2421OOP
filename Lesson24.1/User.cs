using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson24
{
    internal class User
    {
        [DisplayName("Имя")]
        public string Name { get; set; }
        [DisplayName("Фамилия")]
        public string SurName { get; set; }
        [DisplayName("Возраст")]
        public int Age { get; set; }
        public User(string name, string surName, int age)
        {
            Name = name;
            SurName = surName;
            Age = age;
        }
    }
}
