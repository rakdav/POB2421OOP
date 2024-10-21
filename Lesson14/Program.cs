//Action
using System.Threading.Channels;

void DoOperation(int a, int b, Action<int, int> op) => op(a, b);
void Add(int a, int b) => Console.WriteLine($"{a}+{b}={a+b}");
void Sub(int a, int b) => Console.WriteLine($"{a}-{b}={a - b}");
//Func
int DoOperationInt(int n,Func<int,int> op)=>op(n);
int DoubleNumber(int n) => 2 * n;
int SquareNumber(int n) => n * n;
//Predicate
Predicate<int> isPositive = (int x) => x > 0;
//Анонимные методы
MessageHandler handler = delegate (string mes)
{
    Console.WriteLine(mes);
};

void ShowMessage(string mes,MessageHandler handler)
{
    handler(mes);
}
Operation operation = delegate (int x, int y)
{
    return x + y;
};

//главная программа
//DoOperation(19, 4, Add);
//DoOperation(19, 4, Sub);
//int res1=DoOperationInt(5,DoubleNumber);
//int res2=DoOperationInt(5, SquareNumber);
//Console.WriteLine("res1="+res1);
//Console.WriteLine("res2="+res2);
//Console.WriteLine(isPositive(8));
//Console.WriteLine(isPositive(-7));
//handler("hello world");
//ShowMessage("hello", delegate (string name)
//{
//    Console.WriteLine(name);
//});
//int res3 = operation(4, 80);
//Console.WriteLine(res3);
//Message hello = () => Console.WriteLine("Hello from lambda");
//hello();
//var hel=() => Console.WriteLine("hel");
//hel();
//var welcome = (string mes = "my message") => Console.WriteLine(mes);
//welcome("Привет!!!");
//var sum = (int x, int y) => x + y;
//Console.WriteLine(sum(4,8));
//Operation sub = (x, y) => x - y;
//Console.WriteLine(sub(4,2));
//var div = (int x, int y) =>
//{
//    if (y != 0) return x / y;
//    return 0;
//};
//Console.WriteLine(div(6,2));

//var mymes = () => Console.WriteLine("C# hello");
//var mtpres = () => Console.WriteLine("My language");
//mymes += mtpres;
//mymes();
//mymes -= mtpres;
//mymes();
int Sum(int[] mas,IsEqual func)
{
    int s = 0;
    foreach (int item in mas) s += item;
    return s;
} 
int Mult(int[] mas,Predicate<int> func)
{
    int s = 1;
    foreach (int item in mas) s *= item;
    return s;
}
int[] integers= new int[10];
Random random = new Random();
for(int i=0;i<integers.Length;i++)
{
    integers[i] = random.Next(10, 100);
    Console.Write(integers[i]+" ");
}
Console.WriteLine();
int SumEven = Sum(integers,x=>x%2==0);
Console.WriteLine(SumEven);
int SumPos=Sum(integers, x=>x>0);
Console.WriteLine(SumPos);
Console.WriteLine(Mult(integers,x=>x%2!=0));
Console.WriteLine(Mult(integers, x => x<0));

delegate void MessageHandler(string mes);
delegate int Operation(int x,int y);
delegate void Message();
delegate bool IsEqual(int x);