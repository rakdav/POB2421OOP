using System.Security.Authentication;
List<Person> persons = new List<Person>()
{
    new Person(){Id=1, Name="Иван"},
    new Person(){Id=2,Name="Борис"},
    new Person(){Id=3,Name="Федор"}
};  
List<Product> priceList = new List<Product>
{
    new Product(){Name="Asus",ProductType=TypeOfProduct.MotherBoard,Price=15000,Id=1},
    new Product(){Name="Intel",ProductType=TypeOfProduct.Cpu,Price=9000,Id=2},
    new Product(){Name="NVidia",ProductType=TypeOfProduct.VideoCard,Price=12000,Id=3},
     new Product(){Name="GeForce",ProductType=TypeOfProduct.MotherBoard,Price=17500,Id=4},
    new Product(){Name="AMD",ProductType=TypeOfProduct.Cpu,Price=11000,Id=5},
    new Product(){Name="MegaByte",ProductType=TypeOfProduct.VideoCard,Price=14000,Id=6}
};
Console.Write("Введите ваше имя:");
string name = Console.ReadLine()!;
Console.Write("Введите ваш баланс:");
decimal balance=decimal.Parse(Console.ReadLine()!);
Person person = persons.FirstOrDefault(p=>p.Name==name)!;
decimal discount = 0;

if (person == null)
    Console.WriteLine("Такого пользователя нет!");
else
{
    person.Balance=balance;
    decimal Startbalance = balance;
    SalePerson salePerson=new SalePerson();
    salePerson.Customer=person;
    salePerson.Sales = new List<Sale>();
    do
    {
        Console.Clear();
        Console.WriteLine($"Ваш баланс:{person.Balance}");
        Console.WriteLine("Список товаров:");
        foreach (var item in priceList)
        {
            if (Startbalance - person.Balance > 50000)
            {
                discount = 0.1M;
            }
            Console.WriteLine($"Id:{item.Id}. Name:{item.Name} Type:{item.ProductType}"+
                $" Price:{item.Price-item.Price*discount}");
            
        }
        Console.WriteLine("Список покупок:");
        foreach (var item in salePerson.Sales)
        {
            Console.WriteLine(item.Product.Name + " " + item.Count + " " + item.Total());
        }
        if (person.Balance > 0)
        {
            Console.Write("Введите номер товара:");
            int id = int.Parse(Console.ReadLine()!);
            Console.Write("Введите его количество:");
            int count = int.Parse(Console.ReadLine()!);
            Sale sale = new Sale();
            sale.Product = priceList.First(p => p.Id == id);
            sale.Count = count;
            if (person.Balance >= sale.Total())
            {
                sale.Discount = discount;
                salePerson.Sales.Add(sale);
                person.Balance -= sale.Total();
            }
            else
            {
                Console.WriteLine("Не хватает средств для покупки!");
                Console.ReadKey();
            }
        }
        else
        {
            Console.WriteLine("На счету нет денег!");
            Console.ReadKey();
        }
    }
    while (true);
}
enum TypeOfProduct
{
    MotherBoard,
    Cpu,
    VideoCard
}
class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public TypeOfProduct ProductType { get; set; }
    public decimal Price { get; set; }
}
class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Balance { get; set; }
}
class Sale 
{
    public Product Product { get; set; }
    public int Count { get; set; }
    public decimal Discount { get; set; }
    public decimal Total() => Count * Product.Price- Count * Product.Price*Discount;
}
class SalePerson
{
    public Person Customer { get; set; }
    public List<Sale> Sales { get; set;}
    public decimal GetTotal(int count) => Sales.Sum(p => p.Total());
}
