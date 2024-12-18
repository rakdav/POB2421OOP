using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les29
{
    internal class Nakladnaya
    {
        [DisplayName("Название товара")]
        public string? Name {  get; set; }
        [DisplayName("Количество")]
        public int Quantity { get;set; }
        [DisplayName("Цена")]
        public decimal Price {  get; set; }
        [DisplayName("Постащик")]
        public string? Provider { get; set; }
        [DisplayName("Получатель")]
        public string? Recipient { get; set; }
        [DisplayName("Дата поставки")]
        public DateOnly DateOrder { get; set; }
    }
}
