namespace myconsole;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, what's your name?");
        string myName= Console.ReadLine();
        Console.WriteLine($"Hello, {myName}!");
    }
}
