KeyEvent keyEvent = new KeyEvent();
keyEvent.KeyDown += (sender, e) =>
{
    switch (e.ch) 
    {
        case 'C':
            {
                MyColor(true);
                break;
            }
        case 'B':
            {
                MyColor(false);
                break;
            }
        case 'S':
            {

            }
            break;
    }
};
ConsoleTitle();
char ch=' ';
do
{
    Console.Write("Введите команду:");
    ConsoleKeyInfo key = Console.ReadKey();
    ch = key.KeyChar;
}
while (ch!='E');
void CC(ConsoleColor color)
{
    Console.ForegroundColor = color;
}
void Command(string s1,string s2)
{
    CC(ConsoleColor.Red);
    Console.Write(s1);
    CC(ConsoleColor.White);
    Console.Write(" - "+s2+"\n");
}
void ConsoleTitle()
{
    CC(ConsoleColor.Green);
    Console.WriteLine("*********************************\n" +
        "Программа настройки консоли\n" +
        "*********************************");
    CC(ConsoleColor.Yellow);
    Console.WriteLine("Управляющие команды:");
    Command("C", "Поменять цвет текста");
    Command("B", "Поменять цвет фона");
    Command("S", "Поменять размер окна");
    Command("T", "Поменять заголовок");
    Command("R", "Сбросить изменения");
    Command("E", "Выход");
    Console.WriteLine();
}
void MyColor(bool F_or_B)
{
    Console.WriteLine("Введите цвет:");
    string s=Console.ReadLine()!;
    switch(s)
    {
        case "Black":
            {
                if(F_or_B) Console.ForegroundColor= ConsoleColor.Black;
                else Console.BackgroundColor= ConsoleColor.Black;
            }
            break;
        case "Yellow":
            {
                if (F_or_B) Console.ForegroundColor = ConsoleColor.Yellow;
                else Console.BackgroundColor = ConsoleColor.Yellow;
            }
            break;
        case "Green":
            {
                if (F_or_B) Console.ForegroundColor = ConsoleColor.Green;
                else Console.BackgroundColor = ConsoleColor.Green;
            }
            break;
        case "Red":
            {
                if (F_or_B) Console.ForegroundColor = ConsoleColor.Red;
                else Console.BackgroundColor = ConsoleColor.Red;
            }
            break;
        case "Blue":
            {
                if (F_or_B) Console.ForegroundColor = ConsoleColor.Blue;
                else Console.BackgroundColor = ConsoleColor.Blue;
            }
            break;
        case "White":
            {
                if (F_or_B) Console.ForegroundColor = ConsoleColor.White;
                else Console.BackgroundColor = ConsoleColor.White;
            }
            break;
    }
}
class MyEventsArgs : EventArgs
{
    public char ch;
}
class KeyEvent
{
    public event EventHandler<MyEventsArgs>? KeyDown;
    public void OnKeyDown(char ch)
    {
        MyEventsArgs c= new MyEventsArgs();
        if(KeyDown != null)
        {
            c.ch = ch;
            KeyDown(this, c);
        }
    }
}
