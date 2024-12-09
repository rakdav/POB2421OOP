using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson26
{

    [Serializable]
    public class Product
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int Period { get; set; }
        public string? Manufactorer { get; set; }
        public string? Category { get; set; }

        public override string? ToString()
        {
            return Name+" "+Price+" "+Period+" "+Manufactorer
                +" "+Category;
        }
    }
}
