using static System.Console;

namespace HelloWorld;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // WriteLine("Hello World");
        Crying(1, "over you");
    }

    static void Crying(int eye, string tears)
    {
        WriteLine($"{eye} has caused this much {tears}");
    }
}