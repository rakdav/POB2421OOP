//Thread thread = Thread.CurrentThread;
//thread.Name = "Main";
//Console.WriteLine(thread.Name);
//Console.WriteLine(thread.ExecutionContext);
//Console.WriteLine(thread.IsAlive);
//Console.WriteLine(thread.IsBackground);
//Console.WriteLine(thread.ManagedThreadId);
//Console.WriteLine(thread.Priority);
//thread.Priority = ThreadPriority.Highest;
//Console.WriteLine(thread.Priority);
//Console.WriteLine(thread.ThreadState);

//Console.WriteLine(Thread.GetDomain());
//Console.WriteLine(Thread.GetDomainID());
//for (int i = 0; i < 100; i++)
//{
//    Thread.Sleep(1000);
//    Console.WriteLine(i);
//}
//thread.Interrupt();
//thread.Join();
//thread.Start();

using System.Threading.Channels;

Thread myThread1 = new Thread(Print1);
Thread myThread2 = new Thread(new ThreadStart(Print2));
Thread myThread3= new Thread(()=>Console.WriteLine("Hello, threads3"));
Thread myThread4 = new Thread(Print3);
Console.WriteLine("Start main");
//myThread1.Start();
//myThread2.Start();
//myThread3.Start();

myThread4.Start();


myThread4.Join();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Главный поток:{i}");
  //  if (i ==2) myThread4.Interrupt();
    Thread.Sleep(300);
}
Console.WriteLine("Finish main");
void Print1() => Console.WriteLine("Hello, from Thread1");
void Print2() => Console.WriteLine("Hello, from Thread2");
void Print3()
{
	for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Второй поток:{i}");
        Thread.Sleep(400);
    }
}

