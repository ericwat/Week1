internal class Program
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("What is your name? \n");
        var name = Console.ReadLine();

        Console.WriteLine("Hello {0} {1}", name, " Eric");
    }
}
