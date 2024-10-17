class Program

static void Main(string[] args)
{
    Console.WriteLine("Hellow cash register");

    Bin myBin = new("quarters",(float)0.25,40);
    myBin.ModifyQuantity(+6);
    Console.WriteLine(myBin.CountValue());
}
