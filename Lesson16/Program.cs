using System.Text.Json;

Person person = new Person() { Name="Маша",Age=17,Weight=60};
var options = new JsonSerializerOptions
{
    WriteIndented = true,
    AllowTrailingCommas = false,
    IgnoreReadOnlyProperties = true
};
string json=JsonSerializer.Serialize(person,options);
Console.WriteLine(json);
Person? fromJson=JsonSerializer.Deserialize<Person>(json);
Console.WriteLine(fromJson!.Name+" "+fromJson!.Weight+" "+
    fromJson!.Age);
List<Person> list=new List<Person>();
list.Add(person);
list.Add(new Person() { Name = "Вася", Age = 34, Weight = 70 });
list.Add(new Person() { Name = "Боря", Age = 23, Weight = 68 });
string jsonList=JsonSerializer.Serialize(list);
Console.WriteLine(jsonList);
List<Person> listDes=JsonSerializer.Deserialize<List<Person>>(jsonList)!;
foreach(Person i in listDes) 
    Console.WriteLine(i!.Name + " " + i!.Weight + " " +i!.Age);
People people=new People();
people.list= listDes;
string peopleJson=JsonSerializer.Serialize(people);
Console.WriteLine(peopleJson);
class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }
}

class People
{
    public List<Person> list { get; set; } = new();
}
