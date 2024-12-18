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
        public string? Quantity { get;set; }
       [DisplayName("Стоимость")]
        public string? Price {  get; set; }
        [DisplayName("ФИО поставщика")]
        public string? Provider { get; set; }
        [DisplayName("ФИО получателя")]
        public string? Recipient { get; set; }
        [DisplayName("Дата поставки")]
        public string? DateOrder { get; set; }
    }
}
