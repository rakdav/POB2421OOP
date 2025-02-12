Console.WriteLine();
class Product
{
    public string? Name;
    public decimal? Price;
    public string? Manufacturer;
    public Product(string? name, decimal? price, string? manufacturer)
    {
        Name = name;
        Price = price;
        Manufacturer = manufacturer;
    }
    public virtual decimal? GetDiscount(IUser user,DateOnly dateSale)
    {
        if (user.Spend > 50000) Price *= 0.9m;
        else if (user.Spend > 10000) Price *= 0.95m;
        Dictionary<int, int> calendar = new Dictionary<int, int>()
        {
            {1,7},
            {2,14},
            {3,8},
            {4,15},
            {5,9},
            {6,1},
            {7,12},
            {8,9},
            {9,1},
            {10,12},
            {11,21},
            {12,31}
        };
        foreach (var cal in calendar)
        {
            if (cal.Value == dateSale.Day && cal.Key == dateSale.Month) Price *= 0.8m;
        }
        return Price;
    }
}


public interface IUser
{
    public string Name { get; set; }
    public decimal Balance { get; set; }
    public decimal? Spend { get; set;}
    public int Age { get; set; }
    public void RediceBalance(decimal price, int quantity);
}
public class User : IUser
{
    public string Name { get; set; }
    public decimal Balance { get; set; }
    public decimal? Spend { get; set; }
    public int Age { get; set; }

    public User(string name, decimal balance, int age)
    {
        Name = name;
        Balance = balance;
        Age = age;
        Spend = 0;
    }
    public void RediceBalance(decimal price, int quantity)
    {
        decimal total = price * quantity;
        Spend += total;
        Balance -= total;
    }
}
