int[] Mult(int[] mas, Predicate<int> func)
{
    List<int> result = new List<int>();
    for (int i = 0; i < mas.Length; i++)
    {
        if (func(mas[i])) result.Add(mas[i]);
    }
    return result.ToArray();
}
DateTime[] FilterDate(DateTime[] mas, Predicate<DateTime> func)
{
    List<DateTime> result = new List<DateTime>();
    for (int i = 0; i < mas.Length; i++)
    {
        if (func(mas[i])) result.Add(mas[i]);
    }
    return result.ToArray();
}
int[] mas = new int[10];
Random random = new Random();
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = random.Next(10, 100);
    Console.Write(mas[i] + " ");
}
Console.WriteLine();
foreach (int i in Mult(mas, x => x % 2 == 0))
{
    Console.Write(i + " ");
}
Console.WriteLine();

DateTime[] mdate = new DateTime[3]
{
    new DateTime(2024,12,5),
    new DateTime(2024,10,5),
    new DateTime(2024,7,9)
};
foreach (DateTime i in FilterDate(mdate, x => x>DateTime.Now))
{
    Console.Write(i + " ");
}
Console.WriteLine();