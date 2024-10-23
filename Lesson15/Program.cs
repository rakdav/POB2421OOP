MyEvent myEvent = new MyEvent();
UserInfo user = new UserInfo("Alex", "Hilton", 45);
myEvent.UserEvent += user.UserInfoHandler;
myEvent.OnUserEvent();

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
        return Name + " " + Family + " " + Salary;
    }
    public void UserInfoHandler()
    {
        Console.WriteLine("Событие вызвано!");
        Console.WriteLine($"Имя:{Name} Фамилия:{Family} Зарплата:{Salary}");
    }
}
class MyEvent
{
    UI[] events=new UI[5];
    public event UI UserEvent
    {
        add => events[1] = value;
        remove=> events[1] = null!;
    }
    public void OnUserEvent() => events[1]();
}
delegate void UI();
