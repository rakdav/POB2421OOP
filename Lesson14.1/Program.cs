
List<Car> GetCars()
{
    return new List<Car>
                {
                    new Car { VIN = "ABC123", Make = "Ford",
                            Model = "F-250", Year = 2010 },
                    new Car { VIN = "DEF123", Make = "BMW",
                            Model = "Z-3", Year = 2005 },
                    new Car { VIN = "ABC456", Make = "Audi",
                            Model = "TT", Year = 2008 },
                    new Car { VIN = "HIJ123", Make = "VW",
                            Model = "Bug",  Year = 1956  },
                    new Car { VIN = "DEF456", Make = "Ford",
                            Model = "F-150", Year = 2005 }
                };
}
//традиционный способ
//bool FilterYear(Car car) { return car.Year > 2000; }
//bool FilterModel(Car car) { return car.Model.StartsWith("F"); }

//List<Car> cars = GetCars();
//List<Car> filtered = new List<Car>();
//foreach (Car car in cars)
//{
//    if (FilterYear(car) && FilterModel(car))
//    {
//        filtered.Add(car);
//    }
//}
//foreach(var i in filtered) 
//    Console.WriteLine(i.Model+" "+i.Year);
//Console.WriteLine();
//2
List<FilterPredicate> predicates = new List<FilterPredicate>();
//predicates.Add(delegate (Car car) { return car.Year > 2000; });
//predicates.Add(delegate (Car car) { return car.Model.StartsWith("F");});
//predicates.Add((Car car)=>car.Year > 2000);
//predicates.Add((Car car)=>car.Model.StartsWith("F"));
predicates.Add(car => car.Year > 2000);
predicates.Add(car => car.Model.StartsWith("F"));
bool CheckPredicates(Car car, IList<FilterPredicate> predicates)
{
    foreach (FilterPredicate p in predicates)
    {
        if (!p(car)) { return false; }
    }
    return true;
}
List<Car> cars = GetCars();
List<Car> filtered = new List<Car>();
foreach (Car car in cars)
{
    if (CheckPredicates(car, predicates)) { filtered.Add(car); }
}
foreach (var i in filtered)
    Console.WriteLine(i.Model + " " + i.Year);


public class Car
{
    public string VIN { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
}
public delegate bool FilterPredicate(Car car);


