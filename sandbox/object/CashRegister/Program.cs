class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, this is Cash Register");

        Bin myBin = new();
        myBin.ModifyQuantity(+6)
        Console.WriteLine(myBin.CountValue());
    }
}