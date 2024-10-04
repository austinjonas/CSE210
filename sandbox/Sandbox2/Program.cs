namespace Sandbox2;

class Program
{
    static void Awesome_function(int x)
    {
        Console.WriteLine($"the arguement recieved by the awesome function is {x}.");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, big guy World!");
        Awesome_function(188999);
    }
}
