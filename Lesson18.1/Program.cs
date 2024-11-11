//алгоритмы синхронизации

//Критические секции
//int x = 100;
//object locker = new();
//for (int i = 0; i < 6; i++)
//{
//    Thread myThread = new Thread(Print);
//    myThread.Name = $"Поток {i}";
//    myThread.Start();
//}

//void Print()
//{
//    lock (locker)
//    {
//        //x = 1;
//        for (int i = 0; i < 6; i++)
//        {
//            Console.WriteLine($"{Thread.CurrentThread.Name}:{x}");
//            x--;
//            Thread.Sleep(100);
//        }
//    }
//}

//мониторы
//int x = 100;
//object locker = new();
//for (int i = 0; i < 6; i++)
//{
//    Thread myThread = new Thread(Print);
//    myThread.Name = $"Поток {i}";
//    myThread.Start();
//}

//void Print()
//{
//    bool acquireLock = false;
//    try
//    {
//        Monitor.Enter(locker, ref acquireLock);
//        //x = 1;
//        for (int i = 0; i < 6; i++)
//        {
//            Console.WriteLine($"{Thread.CurrentThread.Name}:{x}");
//            x--;
//            Thread.Sleep(100);
//        }
//    }
//    finally
//    {
//        if (acquireLock) { Monitor.Exit(locker); }
//    }
//}

//класс AutoResetEvent

//int x = 100;
//AutoResetEvent waitHandler= new AutoResetEvent(true);
//for (int i = 0; i < 6; i++)
//{
//    Thread myThread = new Thread(Print);
//    myThread.Name = $"Поток {i}";
//    myThread.Start();
//}

//void Print()
//{
//    waitHandler.WaitOne();
//        //x = 1;
//        for (int i = 0; i < 6; i++)
//        {
//            Console.WriteLine($"{Thread.CurrentThread.Name}:{x}");
//            x--;
//            Thread.Sleep(100);
//        }
//    waitHandler.Set();
//}

//Мьютекс
//int x = 100;
//Mutex mutexObj = new();
//for (int i = 0; i < 6; i++)
//{
//    Thread myThread = new Thread(Print);
//    myThread.Name = $"Поток {i}";
//    myThread.Start();
//}
//void Print()
//{
//    mutexObj.WaitOne();
//        //x = 1;
//        for (int i = 0; i < 6; i++)
//        {
//            Console.WriteLine($"{Thread.CurrentThread.Name}:{x}");
//            x--;
//            Thread.Sleep(100);
//        }
//    mutexObj.ReleaseMutex();
//}

//Семафоры
for (int i = 0; i < 6; i++)
{
    Reader reader = new Reader(i);
}
class Reader
{
    static Semaphore sem = new Semaphore(3, 3);
    Thread myThread;
    int count = 3;

    public Reader(int i)
    {
        myThread = new Thread(Read);
        myThread.Name = $"Читатель:{i}";
        myThread.Start();
    }
    public void Read()
    {
        while (count>0) 
        {
            sem.WaitOne();
            Console.WriteLine($"Входит {Thread.CurrentThread.Name}");
            Console.WriteLine($"{Thread.CurrentThread.Name} читает");
            Thread.Sleep(1000);
            Console.WriteLine($"{Thread.CurrentThread.Name} уходит");
            sem.Release();
            count--;
            Thread.Sleep(1000);
        }
    }
}