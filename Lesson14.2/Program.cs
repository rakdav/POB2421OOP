using System.Net.Http.Headers;
using System.Reflection.PortableExecutable;

//int[] Mult(int[] mas, Predicate<int> func)
//{
//    List<int> result = new List<int>();
//    for (int i = 0; i < mas.Length; i++)
//    {
//        if (func(mas[i])) result.Add(mas[i]);
//    }
//    return result.ToArray();
//}
//DateTime[] FilterDate(DateTime[] mas, Predicate<DateTime> func)
//{
//    List<DateTime> result = new List<DateTime>();
//    for (int i = 0; i < mas.Length; i++)
//    {
//        if (func(mas[i])) result.Add(mas[i]);
//    }
//    return result.ToArray();
//}

//string[] FilterString(string[] mas, Predicate<string> func)
//{
//    List<string> filterMas = new ();
//    for(int i = 0; i < mas.Length; i++)
//    {
//        if (func(mas[i])) filterMas.Add(mas[i]);
//    }
//    return filterMas.ToArray();
//}

//string[] strMas = new string[5]
//{
//    "erwr","rwrew","erew","rewrw","ewrwwwrew"
//};
//foreach (string str in FilterString(strMas, x => x.Length >= 5))
//{
//    Console.WriteLine(str);
//}

//int[] mas = new int[10];
//Random random = new Random();
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10, 100);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//foreach (int i in Mult(mas, x => x % 2 == 0))
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();

//DateTime[] mdate = new DateTime[3]
//{
//    new DateTime(2024,12,5),
//    new DateTime(2024,10,5),
//    new DateTime(2024,7,9)
//};
//foreach (DateTime i in FilterDate(mdate, x => x>DateTime.Now))
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();

//Person[] FilterPerson(Person[] mas, Predicate<Person> func)
//{
//    List<Person> filterMas = new();
//    for (int i = 0; i < mas.Length; i++)
//    {
//        if (func(mas[i])) filterMas.Add(mas[i]);
//    }
//    return filterMas.ToArray();
//}
//Person[] people = {
//                    new Person { Name="Vasya",Age=34},
//                    new Person {Name="Alex",Age=17},
//                    new Person {Name="Sam",Age=37},
//                    };
//foreach (Person i in FilterPerson(people, x => x.Age>30))
//{
//    Console.WriteLine(i + " ");
//}
//Console.WriteLine();
//class Person
//{
//    private int age;
//    public string? Name { get; set; }
//    public int Age 
//    { 
//        get=>age;
//        set { if (value > 0&&value<120) age = value; } 
//    }
//    public override string? ToString()
//    {
//        return Name+" "+Age;
//    }
//}
//double Add(double x, double y) => x + y;
//double Sub(double x, double y) => x - y;
//double Mult(double x, double y) => x * y;
//double Div(double x, double y) => x / y;
//Operation[] delMas=new Operation[4];
//delMas[0] = Add; delMas[1]=Sub; delMas[2]=Mult; delMas[3]=Div;
//Console.Write("Введите 1 число:");
//double x = double.Parse(Console.ReadLine()!);
//Console.Write("Введите 1 число:");
//double y = double.Parse(Console.ReadLine()!);
//Console.Write("Введите операцию:");
//char op =char.Parse(Console.ReadLine()!);
//switch (op)
//{
//    case '+': Console.WriteLine(delMas[0](x, y)); break;
//    case '-': Console.WriteLine(delMas[1](x, y)); break;
//    case '*': Console.WriteLine(delMas[2](x, y)); break;
//    case '/': Console.WriteLine(delMas[3](x, y)); break;
//}
//delegate double Operation(double x, double y);

//void Add(double x, double y) =>Console.WriteLine(x + y);
//void Sub(double x, double y) => Console.WriteLine(x - y);
//void Mult(double x, double y) => Console.WriteLine(x * y);
//void Div(double x, double y) => Console.WriteLine(x / y);
//Operation delMas=Add;
//delMas += Sub;
//delMas += Mult;
//delMas += Div;

//Console.Write("Введите 1 число:");
//double x = double.Parse(Console.ReadLine()!);
//Console.Write("Введите 1 число:");
//double y = double.Parse(Console.ReadLine()!);
////delMas(x,y);
//Operation op = delegate (double x, double y)
//{
//    Console.WriteLine(x * y);
//};
//FactDeleaget fact = delegate (int x)
//{
//    long f = 1;
//    for (int i = 1; i <= x; i++) f *= i;
//    return f;
//};
//op(x, y);
//Console.WriteLine(fact(10));
//delegate void Operation(double x, double y);
//delegate long FactDeleaget(int x);
UserInfo[] userInfos = 
{
    new UserInfo("Sam","Brown",150000),
    new UserInfo("Jorn","Right",120000),
    new UserInfo("Garry","Town",180000),
    new UserInfo("Hilary","Clinton",110000)
};
ArrSort.Sort(userInfos, UserInfo.UserSalary);
foreach(UserInfo i in userInfos)
    Console.WriteLine(i);
class ArrSort
{
    public static void Sort<T>(IList<T> sortArray,Func<T,T,bool> res)
    {
        bool mySort = true;
        do
        {
            mySort = false;
            for (int i = 0; i < sortArray.Count-1; i++)
            {
                if (res(sortArray[i + 1], sortArray[i]))
                {
                    T j = sortArray[i];
                    sortArray[i] = sortArray[i + 1];
                    sortArray[i+1] = j;
                    mySort=true;
                }
            }
        }
        while (mySort);
    }
}
class UserInfo
{
    public string? Name { get; set; }
    public string? Family { get; set; }
    public decimal? Salary { get; set; }
    public UserInfo(string? name, string? family, decimal? salary)
    {
        Name = name;
        Family = family;
        Salary = salary;
    }
    public override string? ToString()
    {
        return Name+" "+Family+" "+Salary;
    }
    public static bool UserSalary(UserInfo userInfo1, UserInfo userInfo2)
    {
        return userInfo1.Salary > userInfo2.Salary;
    }
}
