using System.Linq;

List<Car> GetCars()
{
    return new List<Car>
                {
                    new Car { VIN = "ABC123", Make = "Ford",Model = "F-250", Year = 2000 },
                    new Car { VIN = "DEF123", Make = "BMW",Model = "Z-3", Year = 2005 },
                    new Car { VIN = "ABC456", Make = "Audi",Model = "TT", Year = 2008 },
                    new Car { VIN = "HIJ123", Make = "VW",Model = "Bug",  Year = 1956  },
                    new Car { VIN = "DEF456", Make = "Ford",Model = "F-150", Year = 1998 }
                };
}
bool result = GetCars().All(c => c.Year > 1960);
Console.WriteLine(result);
result = GetCars().Any(c => c.Year <= 1960);
Console.WriteLine(result);
var cars=GetCars();
var carsByVin = cars.ToDictionary(c=>c.VIN);
Console.WriteLine(carsByVin["ABC456"].Make);
var carsLookUp = cars.ToLookup(c=>c.Make);
IEnumerable<Car> list =carsLookUp["Ford"];
foreach(var car in list)
{
    Console.WriteLine(car.Year);
}
var numbers = Enumerable.Range(1, 3);
var zip = numbers.Zip(cars, (i, c) => new
{
    Number = i,
    CarMake=c.Make
});
foreach (var item in zip)
{
    Console.WriteLine(item);
}
int[] scores = { 88, 56, 23, 99, 65, 93, 78, 23, 99, 90 };

foreach (var s in scores.OrderBy(i => i).Skip(9))
{ Console.Write(s+" "); }
Console.WriteLine();
foreach (var s in scores.OrderBy(i => i).SkipWhile(s => s < 80))
{ Console.Write(s+" "); }
Console.WriteLine();
foreach (var s in scores.SkipWhile(s => s ==80))
{ Console.Write(s + " "); }
Console.WriteLine();
foreach (var item in scores.OrderBy(i => i).Skip(3).Take(2))
{
    Console.Write(item+" ");
}
Console.WriteLine();
var query = cars.GroupBy(c => c.Make);
foreach(IGrouping<string,Car> group in query)
{
    Console.WriteLine(group.Key);
    foreach(Car c in group)
    {
        Console.WriteLine(c.Year+" "+c.VIN+" "+c.Color);
    }
}

var vehicles = new List<Tuple<string, string, int>>
            {
                Tuple.Create("123", "VW", 1999),
                Tuple.Create("234", "Ford", 2009),
                Tuple.Create("567", "Audi", 2005),
                Tuple.Create("678", "Ford", 2003),
                Tuple.Create("789", "Mazda", 2003),
                Tuple.Create("999", "Ford", 1965)
            };
var fordCars = vehicles
                        .Where(v => v.Item2 == "Ford")
                        .Select(v => new Car
                        {
                            VIN = v.Item1,
                            Make = v.Item2,
                            Year = v.Item3
                        });
foreach (var item in fordCars)
{
    Console.WriteLine("Car VIN:{0} Make:{1} Year:{2}",
              item.VIN, item.Make, item.Year);
}

var fords = from v in vehicles
            let makeYear = v.Item2 + " " + v.Item3
            where makeYear.StartsWith("Ford")
            select new
            {
                VIN=v.Item1,
                MakeYear = makeYear,
            };
foreach (var item in fords)
{
    Console.WriteLine("Car VIN:{0} MakeYear:{1}",
                        item.VIN, item.MakeYear);
}
Console.WriteLine("Select many");
var repairs = new List<Tuple<string, List<string>>>
                    {
                        Tuple.Create("ABC123",
                                    new List<string> {"Rotate Tires", "Change oil"}),
                        Tuple.Create("DEF123",
                                    new List<string> {"Fix Flat", "Wash Vehicle"}),
                        Tuple.Create("ABC456",
                                    new List<string> {"Alignment", "Vacuum", "Wax"}),
                        Tuple.Create("HIJ123",
                                    new List<string> {"Spark plugs", "Air filter"}),
                        Tuple.Create("DEF456",
                                    new List<string> {"Wiper blades", "PVC valve"}),
                    };
var manyQuery = repairs.SelectMany(t =>
        t.Item2.Select(r => new { VIN = t.Item1, Repair = r }));
foreach (var item in manyQuery)
{
    Console.WriteLine("VIN:{0} Repair:{1}", item.VIN, item.Repair);
}
var makes = new string[] { "Audi", "BMW", "Ford", "Mazda", "VW" };
var newQuery = makes.Join(cars,
    make => make, car => car.Make,
    (make, innerCar) => new { Make = make, Car = innerCar });
foreach (var item in newQuery)
{
    Console.WriteLine("Make: {0}, Car:{1} {2} {3}",
                        item.Make, item.Car.VIN, item.Car.Make, item.Car.Model);
}
var queryGroup = makes.GroupJoin(cars,
    make => make, car => car.Make,
    (make, innerCars) => new { Make = make, Cars = innerCars });
foreach (var item in queryGroup)
{
    Console.WriteLine(item.Make);
    foreach (var i in item.Cars)
    {
        Console.WriteLine("Car:{0} {1} {2}",
                            i.VIN, i.Make, i.Model);
    }
}
List<Repair> GetRepairs()
{
    return new List<Repair> {
        new Repair {VIN = "ABC123", Desc = "Change Oil", Cost = 29.99m},
        new Repair {VIN = "DEF123", Desc = "Rotate Tires",  Cost =19.99m},
        new Repair {VIN = "HIJ123", Desc = "Replace Brakes",   Cost = 200},
        new Repair {VIN = "DEF456", Desc = "Alignment", Cost = 30},
        new Repair {VIN = "ABC123", Desc = "Fix Flat Tire", Cost = 15},
        new Repair {VIN = "DEF123", Desc = "Fix Windshield",  Cost =420},
        new Repair {VIN = "ABC123", Desc = "Replace Wipers", Cost = 20},
        new Repair {VIN = "HIJ123", Desc = "Replace Tires",   Cost = 1000},
        new Repair {VIN = "DEF456", Desc = "Change Oil", Cost = 30} };
}
var repair = GetRepairs();
var carsWithRepairs = from c in cars
                      join r in repair
                      on c.VIN equals r.VIN
                      orderby c.VIN, r.Cost
                      select new
                      {
                          Vin=c.VIN,
                          Make=c.Make,
                          Desc=r.Desc,
                          Cost=r.Cost,
                      };
foreach (var item in carsWithRepairs)
{
    Console.WriteLine("Car VIN:{0}, Make:{1}, Description:{2} Cost:{3:C}",
        item.Vin, item.Make, item.Desc, item.Cost);
}
var carsOuter = from c in cars
                      join r in repair
                      on c.VIN equals r.VIN into g
                      from r in g.DefaultIfEmpty()
                      orderby c.VIN, r==null?0:r.Cost
                      select new
                      {
                          Vin = c.VIN,
                          Make = c.Make,
                          Desc = r==null?"No":r.Desc,
                          Cost = r==null?0:r.Cost,
                      };
foreach (var item in carsOuter)
{
    Console.WriteLine("Car VIN:{0}, Make:{1}, Description:{2} Cost:{3:C}",
        item.Vin, item.Make, item.Desc, item.Cost);
}
Console.WriteLine();
var colors = new string[] { "Red", "Blue", "Green" };
var carsWithColors = from car in cars
                      from color in colors
                      orderby car.VIN, color
                      select new
                      {
                          Vin=car.VIN,
                          Make=car.Make,
                          Model=car.Model,
                          Color = color
                      };
foreach (var item in carsWithColors)
{
    Console.WriteLine("Car VIN:{0}, Make:{1}, Description:{2} Cost:{3:C}",
        item.Vin, item.Make, item.Model, item.Color);
}
Product[] products = new Product[]
{
new Product { Id = 1, Name = "LED Телевизор", Price = 1200 },
new Product { Id = 2, Name = "Ноутбук", Price = 900 },
new Product { Id = 3, Name = "Кофе-машина", Price = 150 },
new Product { Id = 4, Name = "Bluetooth наушники", Price = 80 },
new Product { Id = 5, Name = "Фитнес браслет", Price = 50 },
new Product { Id = 6, Name = "Внешний жесткий диск", Price = 120 },
new Product { Id = 7, Name = "Беспроводная мышь", Price = 25 },
new Product { Id = 8, Name = "Игровое кресло", Price = 200 },
new Product { Id = 9, Name = "Умные часы", Price = 180 },
new Product { Id = 10, Name = "Игровая клавиатура", Price = 100 },
};
var p150 = products.Where(p => p.Price > 150);
foreach (var item in p150)
{
    Console.WriteLine(item.Name+" "+item.Price);
}
class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
}
class Car
{
    public string VIN { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
}
public class Repair
{
    public string VIN { get; set; }
    public string Desc { get; set; }
    public decimal Cost { get; set; }
}




