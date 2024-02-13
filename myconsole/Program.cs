namespace myconsole;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, what is your name?");
        string myName= Console.ReadLine();
        Console.WriteLine($"Hello, my name is {myName}!");
    }
}
