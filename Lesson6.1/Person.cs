﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._1
{
    internal class Person
    {
        public string? Name { get; set; } = "";

        public Person()
        {

        }

        public Person(string name)
        {
            Name = name;
        }
        public void Print()
        {
            Console.WriteLine("Меня зовут:" + Name);
        }
    }
}
