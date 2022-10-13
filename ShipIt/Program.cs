internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ship It\n");
        Console.WriteLine("Choose a shipping method for your order.\n" +
                          "1-Next Day - $20\n" +
                          "2-Air - $10\n" +
                          "3-Ground - $5\n");

        var shippingCost = 0.0;
        var shippingMethod = Console.ReadLine();
        var couldParse = int.TryParse(shippingMethod, out var parsedValue);

        if (couldParse)
        {
            if (parsedValue == 1)
                shippingCost = 20.0;
            else if (parsedValue == 2)
                shippingCost = 10.0;
            else if (parsedValue == 3) shippingCost = 5.0;
        }

        Console.WriteLine("You are paying ${0} for shipping. You think outside the box.\n", shippingCost);
    }
}


