int x = 0;
Car car1 = new Car(x,2,1);
Car car2 = new Car(x,2,2);
Thread thread1 = new Thread(car1.inc);
Thread thread2 = new Thread(car2.inc);
thread1.Start();
thread2.Start();

class Car
{
    private int x;
    private int s;
    private int number;
    public Car(int _x, int speed, int number)
    {
        this.x = _x;
        this.s = speed;
        this.number = number;   
    }
    public void inc()
    {
        for (int i = 0; i < 50; i++)
        {
            x+=s;
            Thread.Sleep(50);
            Console.WriteLine($"Машина {number}:{getX()}");
        }
    }
    public int getX() => x;
}
