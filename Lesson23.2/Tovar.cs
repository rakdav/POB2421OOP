using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson23._2
{
    internal class Tovar
    {
        public string? Name { get; set; }
        public int Count { get; set; }
        public decimal CostPrice { get; set; }
        public decimal Total { get; set; }
        public decimal Price { get; set; }
        public decimal Remainder { get; set; }
        public DateTime Start { get; set; }
        public void Print()
        {
            Console.WriteLine(Name +" "+Count+" "+CostPrice+" "+
                Total+" "+Price+" "+Remainder+" "+Start);
        }
    }
    
}
