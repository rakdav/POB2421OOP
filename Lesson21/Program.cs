//await PrintTask();
//await PrintAsync();
//Console.WriteLine("Основной поток");
//await PrintNameAsync("Arin");
//await PrintNameAsync("Tom");
//await PrintNameAsync("Sam");

//Account account = new Account();
//account.Added += PrintAsync;
//account.Put(500);
//await Task.Delay(2000);

//var task=PrintAsynsTask("Hello");
//Console.WriteLine("Основная программа");
//await task;

//int n1 = await SquareAsync(6);
//int n2= await SquareAsync(7);
//Console.WriteLine($"{6}^2={n1}\n{7}^2={n2}");

//var result = await AddAsync(7, 9);
//Console.WriteLine(result);

//1 cпособ
//await PrintAsynsTask("first");
//await PrintAsynsTask("second");
//await PrintAsynsTask("third");

//2 способ
//var t1= PrintAsynsTask("first");
//var t2= PrintAsynsTask("second");
//var t3= PrintAsynsTask("third");
//await t1;
//await t2;
//await t3;
//await Task.WhenAll(t1,t2,t3);//завершение всех задач

//await Task.WhenAny(t1, t2, t3);
//Console.WriteLine("Hello");
var t1 = SquareAsync(5);
var t2 = SquareAsync(9);
var t3 = SquareAsync(3);
//int[] mas = await Task.WhenAll(t1, t2, t3);
await Task.WhenAny(t1, t2, t3);
Console.WriteLine(t1.Result);
Console.WriteLine(t2.Result);
Console.WriteLine(t3.Result);
//foreach (int i in mas)
//    Console.WriteLine(i);
Console.WriteLine("Ждал");
async void PrintAsync(object? obj,string mes)
{
    await Task.Delay(1000);
    Console.WriteLine(mes);
}
async Task<int> SquareAsync(int n)
{
    await Task.Delay(1000);
    return n * n;
}
ValueTask<int> AddAsync(int a,int b)
{
    return new ValueTask<int>(a + b);
}
//async Task<int> SquareAsync(int n)
//{
//    await Task.Delay(0);
//    return n * n;
//}
async Task PrintAsynsTask(string message)
{
    await Task.Delay(3000);
    Console.WriteLine(message);
}
void Print()
{
    Thread.Sleep(3000);
    Console.WriteLine("Hello");
}
//async Task PrintAsync()
//{
//    await Task.Delay(3000);
//    Console.WriteLine("Hello, async");
//} 
async Task PrintTask()
{
    Console.WriteLine("Начало метода ...");
    await Task.Run(() =>Print());
    Console.WriteLine("Конец метода ...");
}
async Task PrintNameAsync(string name)
{
    await Task.Delay(3000);
    Console.WriteLine(name);
}
class Account
{
    int sum = 0;
    public event EventHandler<string>? Added;
    public void Put(int sum)
    {
        this.sum += sum;
        Added?.Invoke(this, $"На счет поступило {sum} $");
    }
}
