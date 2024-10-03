class Program
{
    static void Main()
    {
        Door moria = new Door("1312", "melon");
        Door morDoor = new Door("4321", "precious");
        Console.WriteLine(moria);
        if (moria.Status == Status.Locked) { Console.WriteLine("Speak friend, and enter "); }
        Console.WriteLine("Program ends.");
    }
}