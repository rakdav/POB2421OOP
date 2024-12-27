using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les31
{
    internal class Product
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public decimal? Price { get; set; }
        public Recept? Recept { get; set; }
        public void Print()
        {

        }
    }
}
