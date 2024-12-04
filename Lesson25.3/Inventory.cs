using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson25._3
{
    internal class Inventory
    {
        [DisplayName("Название")]
        public string? Name { get; set; }
        [DisplayName("Количество")]
        public int Quantity { get; set; }
        [DisplayName("Цена")]
        public decimal? Price { get; set; }
        [DisplayName("Пояснение")]
        public string? Description { get; set; }
    }
}
