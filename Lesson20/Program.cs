using System.Net.Http.Headers;
using System.Threading.Channels;

//Task task1 = new Task(()=>
//Console.WriteLine("Hello task1!"));
//task1.Start();
//Task task2 = Task.Factory.StartNew(() =>
//Console.WriteLine("Hello task2!"));
//Task task3 = Task.Run(() => 
//Console.WriteLine("Hello task3!"));
//task1.Wait();
//task2.Wait();
//task3.Wait();

//Console.WriteLine("Main store");
//Task task = new Task(()=>
//{
//    Console.WriteLine("Task start");
//    Thread.Sleep(1000);
//    Console.WriteLine("Task end");
//});
////task.Start();
//task.RunSynchronously();
//Console.WriteLine("Main ends");
////task.Wait();

//Task task = new Task(()=>
//{
//    Console.WriteLine($"Task{Task.CurrentId} starts");
//    Thread.Sleep( 1000 );
//    Console.WriteLine($"Task{Task.CurrentId} ends");
//});
//task.Start();
//Console.WriteLine($"task id:{task.Id}");
//Console.WriteLine($"task complete:{task.IsCompleted}");
//Console.WriteLine($"task status:{task.Status}");
//task.Wait();

//Вложенные задачи
//var outer = Task.Factory.StartNew(() =>
//{
//    Console.WriteLine("Outer task starting ...");
//    var inner = Task.Factory.StartNew(()=>
//    {
//        Console.WriteLine("Inner task starting ...");
//        Thread.Sleep(2000);
//        Console.WriteLine("Inner task finished.");
//    },TaskCreationOptions.AttachedToParent);
//});
//outer.Wait();
//Console.WriteLine("End of Main");

//Массив задач
//Task[] tasks=new Task[3]
//{
//    new Task(()=>Console.WriteLine("Task 1")),
//    new Task(()=>Console.WriteLine("Task 2")),
//    new Task(()=>Console.WriteLine("Task 3"))
//};
//foreach (var task in tasks) task.Start();
//Task.WaitAll(tasks);

//Task[] tasks = new Task[3];
//int j = 1;
//for (int i = 0; i < tasks.Length; i++)
//{
//    tasks[i] = Task.Factory.StartNew(()=>
//    {
//        Thread.Sleep(1000);
//        Console.WriteLine("Task "+j++);
//    });
//}
//Task.WaitAll(tasks);
//Console.WriteLine("Завершение метода Main");

//Возвращение результатов из задач
int Sum(int a, int b) => a + b;
long Fact(int n)
{
    long f = 1;
    for (int i = 1; i < n; i++) f *= i;
    return f;
}
//int n1=4, n2=10;
//Task<int> sumTask = new Task<int>(() => Sum(n1, n2));
//sumTask.Start();
//Console.WriteLine($"{n1}+{n2}={sumTask.Result}");
//Random random = new Random();
//Task<long>[] tasks = new Task<long>[5];
//for (int i = 0; i < tasks.Length; i++)
//{
//    tasks[i] = new Task<long>(
//        () => Fact(random.Next(10,20)));
//    tasks[i].Start();
//}
//for (int i = 0; i < tasks.Length; i++)
//{
//    tasks[i] = new Task<long>(() => random.Next(100, 10000));
//    tasks[i].Start();
//}
//for (int i = 0; i < tasks.Length; i++)
//Console.WriteLine(tasks[i].Result);

//Задачи продолжения
void PrintTask(Task t)
{
    Console.WriteLine($"Id задачи:{Task.CurrentId}");
    Console.WriteLine($"Id предущая задача:{t.Id}");
    Thread.Sleep(1000);
}
//Task task1=new Task(() =>
//{
//    Console.WriteLine($"Id задачи:{Task.CurrentId}");
//});
//Task task2 = task1.ContinueWith(PrintTask);
//task1.Start();
//task2.Wait();
//void PrintResult(int sum) => Console.WriteLine($"Sum:{sum}");
//Task<int> sumTask = new Task<int>(()=>Sum(4,5));
//Task printTask = sumTask.ContinueWith(t => PrintResult(t.Result));
//sumTask.Start();
//printTask.Wait();

//Parallel.Invoke
//Parallel.Invoke(Print,
//    () =>
//    {
//        Console.WriteLine($"Выполняется задача {Task.CurrentId}");
//        Thread.Sleep(3000);
//    },
//    ()=>Square(10));
//void Print()
//{
//    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
//    Thread.Sleep(3000);
//}
void Square(int n,ParallelLoopState pls)
{
    if (n == 8) pls.Break();
    Console.WriteLine($"Выполняется задача {Task.CurrentId}");
    Thread.Sleep(3000);
    Console.WriteLine($"Результат:{n * n}");
}
//Parallel.For
//Parallel.For(1, 5, Square);

//Parallel.ForEach
ParallelLoopResult result = Parallel.ForEach<int>(
    new List<int>() { 1, 5, 8, 3 }, Square);
if(!result.IsCompleted) Console.WriteLine(result.LowestBreakIteration);